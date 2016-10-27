// <copyright file="DuplicatesDisplayer.cs" >
//   Jucardi. All Rights Reserved.
// </copyright>
// <author>juan.diaz</author>
// <date>8/7/2013 2:57:24 PM</date>
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.

using DuplicatesFinder.FileDisplayers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DuplicatesFinder
{
	public partial class DuplicatesDisplayer : Form
	{
		#region Fields

		private List<IFileDisplayer>             displayers     = new List<IFileDisplayer>();
		private Dictionary<string, List<string>> collection     = null;

		#endregion

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="DuplicatesDisplayer"/> class.
		/// </summary>
		public DuplicatesDisplayer()
		{
			this.InitializeComponent();
			this.InitializePreviewItems();
			this.treeView.LostFocus += OnTreeViewLostFocus;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="DuplicatesDisplayer"/> class.
		/// </summary>
		/// <param name="info">The info.</param>
		public DuplicatesDisplayer(Dictionary<string, List<string>> info)
			: this()
		{
			this.collection = info;
			this.InitializeDuplicatesDisplay();
			this.UpdateTree();
		}

		#endregion

		#region Properties

		/// <summary>
		/// Gets the current file.
		/// </summary>
		/// <value>
		/// The current file.
		/// </value>
		public string CurrentFile
		{
			get { return this.treeView.SelectedNode.Text; }
		}

		#endregion

		#region Event Handlers

		/// <summary>
		/// Handles the DoubleClick event of the treeView control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void OnTreeViewDoubleClick(object sender, EventArgs e)
		{
			Process.Start("explorer.exe", string.Format("/select, \"{0}\"", this.treeView.SelectedNode.Text));
		}

		/// <summary>
		/// Handles the AfterSelect event of the treeView control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="TreeViewEventArgs"/> instance containing the event data.</param>
		private void OnTreeViewAfterSelect(object sender, TreeViewEventArgs e)
		{
			KeyValuePair<string, string> info = (KeyValuePair<string, string>)this.treeView.SelectedNode.Tag;
			this.lblSize.Text = info.Key;
			this.lblHash.Text = info.Value;
			this.LoadPreview();
		}

		/// <summary>
		/// Handles the KeyDown event of the treeView control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="KeyEventArgs"/> instance containing the event data.</param>
		private void OnTreeViewKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				this.OnTreeViewDoubleClick(sender, e);
			}
			else if (e.KeyCode == Keys.Delete)
			{
				TreeNode selectedNode = this.treeView.SelectedNode;

				string message = string.Format("Would you like to delete the file following file?\r\n\r\n{0}", selectedNode.Text);
				DialogResult result = MessageBox.Show(message, string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				TreeNode parent = selectedNode.Parent;

				if (result == DialogResult.Yes && this.DeleteFile(selectedNode.Text))
				{
					this.treeView.Nodes.Remove(selectedNode);
					this.UpdateTree();
				}

				this.treeView.Update();
				this.treeView.Refresh();
			}
		}

		/// <summary>
		/// Handles the LostFocus event of the treeView control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		/// <exception cref="System.NotImplementedException"></exception>
		private void OnTreeViewLostFocus(object sender, EventArgs e)
		{
			this.treeView.Focus();
		}

		/// <summary>
		/// Handles the Click event of the btnClose control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void OnCloseClick(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion

		#region Methods

		/// <summary>
		/// Initializes this instance.
		/// </summary>
		private void InitializeDuplicatesDisplay()
		{
			foreach (KeyValuePair<string, List<string>> item in this.collection)
			{
				if (item.Value == null || item.Value.Count <= 1)
					continue;

				FileInfo fInfo     = new FileInfo(item.Value[0]);
				KeyValuePair<string, string> info = new KeyValuePair<string, string>(item.Key, Util.ConvertSize(fInfo.Length));

				foreach (string file in item.Value)
				{
					TreeNode fileNode  = new TreeNode(file);
					fileNode.ForeColor = Color.Black;
					fileNode.Tag = info;

					this.treeView.Nodes.Add(fileNode);
				}
			}
		}

		/// <summary>
		/// Loads the preview.
		/// </summary>
		private void LoadPreview()
		{
			this.pnlPreview.Controls.Clear();

			foreach (IFileDisplayer displayer in this.displayers)
				displayer.ReleaseResources();

			foreach (IFileDisplayer displayer in this.displayers)
			{
				if (!this.IsExtensionFromCollection(displayer.Extensions))
					continue;

				if (!displayer.LoadFile(this.CurrentFile))
					continue;

				this.pnlPreview.Controls.Add(displayer.DisplayControl);
				return;
			}

			this.pnlPreview.Controls.Add(this.pboxPreviewNA);
		}

		/// <summary>
		/// Determines whether [is extension from collection] [the specified extension collection].
		/// </summary>
		/// <param name="extensionCollection">The extension collection.</param>
		/// <returns>
		///   <c>true</c> if [is extension from collection] [the specified extension collection]; otherwise, <c>false</c>.
		/// </returns>
		private bool IsExtensionFromCollection(IEnumerable<string> extensionCollection)
		{
			string extension = Path.GetExtension(this.CurrentFile).ToLower().Replace(".", string.Empty);
			bool   isMatch   = false;

			foreach (string ext in extensionCollection)
			{
				if (!ext.Replace(".", string.Empty).ToLower().Equals(extension))
					continue;

				isMatch = true;
				break;
			}

			return isMatch;
		}

		/// <summary>
		/// Deletes the file.
		/// </summary>
		/// <param name="file">The file.</param>
		private bool DeleteFile(string file)
		{
			try
			{
				File.Delete(file);
				return true;
			}
			catch (System.Exception ex)
			{
				string message = string.Format("Unable to delete file '{0}'\r\n\r\n", file, ex.Message);
				MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return false;
		}

		/// <summary>
		/// Updates the tree.
		/// </summary>
		private void UpdateTree()
		{
			Color[] bgColors           = new Color[] { Color.White, Color.FromArgb(192, 192, 255) };
			int     duplicateSetsCount = 0 ;
			string  currentHash        = string.Empty;

			foreach (TreeNode node in this.treeView.Nodes)
			{
				KeyValuePair<string, string> info = (KeyValuePair<string, string>)node.Tag;

				if (!string.Equals(currentHash, info.Key, StringComparison.InvariantCultureIgnoreCase))
				{
					currentHash = info.Key;
					duplicateSetsCount++;
				}

				node.BackColor = bgColors[duplicateSetsCount % bgColors.Length];
			}

			this.lblCount.Text = duplicateSetsCount.ToString();
		}

		#endregion

		#region Designer Extension

		private PictureBox pboxPreviewNA = new PictureBox();

		/// <summary>
		/// Initializes the preview items.
		/// </summary>
		private void InitializePreviewItems()
		{
			this.pboxPreviewNA.BackColor = System.Drawing.Color.White;
			this.pboxPreviewNA.Dock      = System.Windows.Forms.DockStyle.Fill;
			this.pboxPreviewNA.Image     = DuplicatesFinder.Properties.Resources.PreviewNA;
			this.pboxPreviewNA.SizeMode  = System.Windows.Forms.PictureBoxSizeMode.CenterImage;

			foreach (Type type in this.GetType().Assembly.GetTypes())
			{
				if (!type.IsClass || type.IsAbstract || !typeof(IFileDisplayer).IsAssignableFrom(type))
					continue;

				this.displayers.Add(Activator.CreateInstance(type) as IFileDisplayer);
			}
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (this.components != null))
				this.components.Dispose();

			foreach (IFileDisplayer item in this.displayers)
				item.Dispose();

			base.Dispose(disposing);
		}

		#endregion
	}
}
