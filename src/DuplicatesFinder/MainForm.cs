// <copyright file="MainForm.cs" >
//   Jucardi. All Rights Reserved.
// </copyright>
// <author>juan.diaz</author>
// <date>8/7/2013 1:09:47 PM</date>
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.

using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Drawing;
using System.Threading;
using System.Diagnostics;
using DuplicatesFinder.Properties;

namespace DuplicatesFinder
{
	public partial class MainForm : Form
	{
		#region Fields

		private Dictionary<long, List<string>>   sizeCollection  = new Dictionary<long, List<string>>();
		private Dictionary<string, List<string>> hashCollection  = new Dictionary<string, List<string>>();
		private long                             progress        = 0;
		private long                             total           = 1;
		private bool                             consoleOpened   = true;
		private int                              lastHeight      = 400;
		private int                              sizeMatchCount  = 0;
		private int                              duplicatesCount = 0;

		#endregion

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="MainForm"/> class.
		/// </summary>
		public MainForm()
		{
			this.InitializeComponent();
			this.Text = string.Format("Jucardi Duplicates Finder - v{0}", Application.ProductVersion);
		}

		#endregion

		#region Properties

		#endregion

		#region Event Handlers

		/// <summary>
		/// Raises the <see cref="E:System.Windows.Forms.Form.Closing" /> event.
		/// </summary>
		/// <param name="e">A <see cref="T:System.ComponentModel.CancelEventArgs" /> that contains the event data.</param>
		protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
		{
			base.OnClosing(e);

			string tempPath = Path.Combine(Path.GetTempPath(), Program.TEMP_FOLDER);

			if (!Directory.Exists(tempPath))
				return;

			string[] tempFiles = Directory.GetFiles(tempPath);

			try
			{
				foreach (string file in tempFiles)
					File.Delete(file);

				Console.WriteLine("Temp files deleted");

				Directory.Delete(tempPath);

				Console.WriteLine("Temp folder deleted");
			}
			catch (Exception)
			{
				Console.WriteLine("Unable to delete temp all files or temp folder");
			}
		}

		/// <summary>
		/// Handles the Resize event of the MainForm control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void OnMainFormResize(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Maximized && !this.consoleOpened)
			{
				this.lastHeight = 400;

				this.btnOpenConsole.BackgroundImage = Resources.ArrowUp;
				this.Size = new Size(600, 400);

				this.consoleOpened = !this.consoleOpened;
			}
		}

		/// <summary>
		/// Handles the Click event of the btnBrowse control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void OnBrowseClick(object sender, EventArgs e)
		{
			if (this.folderBrowserDialog.ShowDialog() != DialogResult.OK)
				return;

			this.txtPath.Text = this.folderBrowserDialog.SelectedPath;
		}

		/// <summary>
		/// Handles the Click event of the btnFind control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void OnFindClick(object sender, EventArgs e)
		{
			if (!Directory.Exists(this.txtPath.Text))
			{
				MessageBox.Show("Folder not found");
				return;
			}

			Thread workingThread = new Thread(new ThreadStart(this.BeginFind));
			workingThread.Start();
		}

		/// <summary>
		/// Handles the Click event of the btnOpenConsole control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void OnOpenConsoleClick(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Maximized)
				return;

			if (this.consoleOpened)
				this.lastHeight = this.Size.Height;

			Image img    = this.consoleOpened ? Resources.ArrowDown : Resources.ArrowUp;
			int   height = this.consoleOpened ? 192 : this.lastHeight;

			this.btnOpenConsole.BackgroundImage = img;
			this.Size = new Size(this.Size.Width, height);

			this.consoleOpened = !this.consoleOpened;
		}

		/// <summary>
		/// Called when [duplicate size found].
		/// </summary>
		/// <param name="file">The file.</param>
		private void OnDuplicateSizeFound(string file, long size)
		{
			this.sizeMatchCount++;
			this.UpdateCounts();

			if (!this.chkDisplayDetails.Checked)
				return;

			this.AddMessage("Possible Duplicate found.", Color.Orange);
			this.AddMessage(string.Format("  - File Size: {0}", Util.ConvertSize(size)), Color.Green);
			this.AddMessage(string.Format("  - File: {0}", file.Replace(this.txtPath.Text, string.Empty)), Color.White);

			this.AddMessage(string.Empty, Color.Black);
		}

		/// <summary>
		/// Called when a duplicated file is found
		/// </summary>
		/// <param name="hash">The hash.</param>
		/// <param name="file">The file.</param>
		private void OnDuplicateFound(string file, string hash)
		{
			this.duplicatesCount++;
			this.UpdateCounts();

			if (!this.chkDisplayDetails.Checked)
				return;

			this.AddMessage("Duplicate found.", Color.Red);
			this.AddMessage(string.Format("  - Hash: {0}", hash), Color.Green);
			this.AddMessage(string.Format("  - File: {0}", file.Replace(this.txtPath.Text, string.Empty)), Color.White);

			this.AddMessage(string.Empty, Color.Black);
		}

		/// <summary>
		/// Called when [status changed].
		/// </summary>
		/// <param name="working">if set to <c>true</c> [working].</param>
		private void OnStatusChanged(bool working)
		{
			if (this.InvokeRequired)
			{
				this.Invoke(new Action<bool>(this.OnStatusChanged), new object[] { working });
				return;
			}

			this.txtPath.Enabled       = !working;
			this.btnBrowse.Enabled     = !working;
			this.btnFind.Enabled       = !working;
			this.pBar.Visible          = working;
			this.workingTimer.Enabled  = working;
			this.progressTimer.Enabled = working;
			this.lblStatus.Text        = working ? "Working" : "Ready";
			this.lblProgress.Text      = string.Empty;

			if (!working)
			{
				using (DuplicatesDisplayer display = new DuplicatesDisplayer(this.hashCollection))
					display.ShowDialog();

				this.sizeCollection.Clear();
				this.hashCollection.Clear();
				this.txtLog.Clear();

				this.duplicatesCount         = 0;
				this.sizeMatchCount          = 0;
				this.UpdateCounts();
			}
		}

		/// <summary>
		/// Handles the Tick event of the workingTimer control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void OnWorkingTimerTick(object sender, EventArgs e)
		{
			if (this.lblProgress.Text == "....")
			{
				this.lblProgress.Text = string.Empty;
				return;
			}

			this.lblProgress.Text = string.Format("{0}.", this.lblProgress.Text);
		}

		/// <summary>
		/// Handles the Tick event of the progressTimer control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void OnProgressTimerTick(object sender, EventArgs e)
		{
			double value = ((double)this.progress / (double)this.total) * (double)100;

			this.pBar.Value = (int)Math.Ceiling(value);
		}

		#endregion

		#region Methods

		/// <summary>
		/// Adds the message.
		/// </summary>
		/// <param name="message">The message.</param>
		private void AddMessage(string message, Color color)
		{
			if (this.InvokeRequired)
			{
				this.Invoke(new Action<string, Color>(this.AddMessage), new object[] { message, color });
				return;
			}

			this.txtLog.DeselectAll();
			this.txtLog.SelectionColor = color;
			this.txtLog.AppendText(string.Format("{0}\r\n", message));
			this.txtLog.ScrollToCaret();
		}

		/// <summary>
		/// Changes the status message.
		/// </summary>
		/// <param name="message">The message.</param>
		private void ChangeStatusMessage(string message)
		{
			if (this.InvokeRequired)
			{
				this.Invoke(new Action<string>(this.ChangeStatusMessage), message);
				return;
			}

			this.lblStatus.Text = message;
		}

		/// <summary>
		/// Begins the find.
		/// </summary>
		private void BeginFind()
		{
			this.OnStatusChanged(true);

			this.AddMessage(string.Empty, Color.Black);
			this.ChangeStatusMessage("Analyzing file sizes");
			this.AddMessage("Analyzing file sizes...", Color.LightBlue);
			this.AddMessage(string.Empty, Color.Black);
			this.AnalyzeFolder(this.txtPath.Text);

			this.AddMessage(string.Empty, Color.Black);
			this.ChangeStatusMessage("Comparing hashes");
			this.AddMessage("Analyzing file hashes on possible duplicates...", Color.LightBlue);
			this.AddMessage(string.Empty, Color.Black);
			this.CompareHashes();

			this.OnStatusChanged(false);
		}

		/// <summary>
		/// Analyzes the folder.
		/// </summary>
		/// <param name="folder">The folder.</param>
		private void AnalyzeFolder(string folder)
		{
			try
			{
				string[] files = Directory.GetFiles(folder);
				string[] folders = Directory.GetDirectories(folder);

				foreach (string file in files)
				{
					FileInfo fInfo = new FileInfo(file);

					if (this.sizeCollection.ContainsKey(fInfo.Length))
					{
						this.sizeCollection[fInfo.Length].Add(file);
						this.OnDuplicateSizeFound(file, fInfo.Length);
					}
					else
					{
						List<string> newList = new List<string>();
						newList.Add(file);
						this.sizeCollection.Add(fInfo.Length, newList);
					}
				}

				foreach (string directory in folders)
					this.AnalyzeFolder(directory);
			}
			catch (Exception ex)
			{
				this.AddMessage(string.Format("Error occurred while reading the folder '{0}'\r\n{1}", folder, ex.ToString()), Color.Red);
			}

		}

		/// <summary>
		/// Analyzes the file list.
		/// </summary>
		/// <param name="fileList">The file list.</param>
		private void AnalyzeFileList(List<string> fileList)
		{
			foreach (string file in fileList)
			{
				string hashString = null;

				try
				{
					hashString = this.CalculateHash(file);
				}
				catch (System.Exception ex)
				{
					this.AddMessage(string.Format("Unable to read file '{0}'\r\n{1}", file, ex.Message), Color.Red);
					continue;
				}

				if (this.hashCollection.ContainsKey(hashString))
				{
					this.hashCollection[hashString].Add(file);
					this.OnDuplicateFound(file, hashString);
				}
				else
				{
					List<string> newList = new List<string>();
					newList.Add(file);
					this.hashCollection.Add(hashString, newList);
				}
			}
		}

		/// <summary>
		/// Calculates the hash.
		/// </summary>
		/// <param name="file">The file.</param>
		/// <returns></returns>
		private string CalculateHash(string file)
		{
			this.ChangeStatusMessage(string.Format("Reading {0}", Path.GetFileName(file)));

			using (MD5 md5 = MD5.Create())
			{
				using (FileStream fs = File.Open(file, FileMode.Open, FileAccess.Read))
				{
					this.total    = fs.Length;
					this.progress = 0;

					byte[] buffer = new byte[2048];
					int    offset = 0;
					int    read   = 0;

					while ((read = fs.Read(buffer, 0, buffer.Length)) > 0)
					{
						offset += md5.TransformBlock(buffer, 0, read, buffer, 0);
						progress += read;
					}

					md5.TransformFinalBlock(new byte[0], 0, 0);
					return Util.ByteArrayToHex(md5.Hash);
				}
			}
		}

		/// <summary>
		/// Compares the hashes.
		/// </summary>
		private void CompareHashes()
		{
			foreach (KeyValuePair<long, List<string>> item in this.sizeCollection)
			{
				if (item.Value.Count <= 1)
					continue;

				this.AnalyzeFileList(item.Value);
			}
		}

		/// <summary>
		/// Updates the counts.
		/// </summary>
		private void UpdateCounts()
		{
			if (this.InvokeRequired)
			{
				this.Invoke(new Action(this.UpdateCounts));
				return;
			}

			this.lblDuplicatesCount.Text = this.duplicatesCount.ToString();
			this.lblSizeMatchCount.Text  = this.sizeMatchCount.ToString();
		}

		#endregion
	}
}
