// <copyright file="WebDisplayer.cs" >
//   Jucardi. All Rights Reserved.
// </copyright>
// <author>juan.diaz</author>
// <date>10/25/2013 6:39:44 PM</date>
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.

using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace DuplicatesFinder.FileDisplayers
{
	internal class WebDisplayer : IFileDisplayer
	{
		#region Constants

		private static readonly string[] EXTENSIONS =
			new string[] { "pdf" };

		#endregion

		#region Fields

		protected WebBrowser browser  = new WebBrowser();
		protected string     tempFile = string.Empty;

		#endregion

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="WebDisplayer"/> class.
		/// </summary>
		public WebDisplayer()
		{
			this.browser.Dock = DockStyle.Fill;
		}

		#endregion

		#region Properties

		/// <summary>
		/// Gets the display control.
		/// </summary>
		/// <value>
		/// The display control.
		/// </value>
		public System.Windows.Forms.Control DisplayControl
		{
			get { return this.browser; }
		}

		/// <summary>
		/// Gets the extensions.
		/// </summary>
		/// <value>
		/// The extensions.
		/// </value>
		public virtual string[] Extensions
		{
			get { return EXTENSIONS; }
		}

		/// <summary>
		/// Gets the temp folder.
		/// </summary>
		/// <value>
		/// The temp folder.
		/// </value>
		protected virtual string TempFolder
		{
			get
			{
				string tempFolder = Path.Combine(Path.GetTempPath(), Program.TEMP_FOLDER);

				if (!Directory.Exists(tempFolder))
					Directory.CreateDirectory(tempFolder);

				return tempFolder;
			}
		}
		#endregion

		#region Methods

		/// <summary>
		/// Loads the file.
		/// </summary>
		/// <param name="file">The file.</param>
		/// <returns></returns>
		public virtual bool LoadFile(string file)
		{
			this.ReleaseResources();

			this.tempFile = this.GetRandomFileName(Path.GetExtension(file));

			try
			{
				using (FileStream fs1 = File.Open(file, FileMode.Open, FileAccess.Read))
				using (FileStream fs2 = new FileStream(this.tempFile, FileMode.Create, FileAccess.Write))
					Util.CopyStream(fs1, fs2);

				this.browser.Url  = new Uri(tempFile);
				this.browser.Refresh();
			}
			catch
			{
				return false;
			}

			return true;
		}

		/// <summary>
		/// Releases the resources.
		/// </summary>
		public virtual void ReleaseResources()
		{
			string tempPath = Path.Combine(Path.GetTempPath(), Program.TEMP_FOLDER);

			if (!Directory.Exists(tempPath))
				return;

			string[] tempFiles = Directory.GetFiles(tempPath);

			foreach (string file in tempFiles)
			{
				try
				{
					File.Delete(file);
				}
				catch
				{
				}
			}
		}

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			if (this.browser != null)
				this.browser.Dispose();
		}

		/// <summary>
		/// Gets the random name of the file.
		/// </summary>
		/// <param name="ext">The ext.</param>
		/// <returns>The temporary file name</returns>
		protected virtual string GetRandomFileName(string ext)
		{
			string ret = null;

			do
			{
				ret = Path.Combine(this.TempFolder, Path.GetRandomFileName());

				if (!string.IsNullOrEmpty(ext))
					ret = Path.ChangeExtension(ret, ext);
			}
			while (File.Exists(ret));

			return ret;
		}

		#endregion
	}
}
