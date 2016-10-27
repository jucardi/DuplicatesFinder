// <copyright file="TextDisplayer.cs" >
//   Jucardi. All Rights Reserved.
// </copyright>
// <author>juan.diaz</author>
// <date>10/21/2013 1:04:39 AM</date>
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.

using System;
using System.IO;
using System.Windows.Forms;

namespace DuplicatesFinder.FileDisplayers
{
	internal class TextDisplayer : IFileDisplayer
	{
		#region Constants

		private static readonly string[] TEXT_EXTENSIONS =
			new string[] { "txt", "xml", "cs", "java", "resx", "css", "html", "cpp", "c", "h",
									   "bat", "js", "lua", "php", "py", "sql", "xsl", "aspx", "xaml" };

		#endregion

		#region Fields

		private TextBox txtPreview = new TextBox();

		#endregion

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="TextDisplayer"/> class.
		/// </summary>
		public TextDisplayer()
		{
			this.txtPreview.Dock       = System.Windows.Forms.DockStyle.Fill;
			this.txtPreview.Font       = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPreview.Multiline  = true;
			this.txtPreview.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtPreview.WordWrap   = false;
		}

		#endregion

		#region Properties

		/// <summary>
		/// Gets the display control.
		/// </summary>
		/// <value>
		/// The display control.
		/// </value>
		public Control DisplayControl
		{
			get { return this.txtPreview; }
		}

		/// <summary>
		/// Gets the extensions.
		/// </summary>
		/// <value>
		/// The extensions.
		/// </value>
		public string[] Extensions
		{
			get { return TEXT_EXTENSIONS; }
		}

		#endregion

		#region Methods

		/// <summary>
		/// Loads the file.
		/// </summary>
		/// <param name="file">The file.</param>
		/// <returns></returns>
		public bool LoadFile(string file)
		{
			string contents = null;

			try
			{
				contents = File.ReadAllText(file);
			}
			catch
			{
				return false;
			}

			this.txtPreview.Text = contents;
			return true;
		}

		/// <summary>
		/// Releases the resources.
		/// </summary>
		public void ReleaseResources()
		{
			this.txtPreview.Text = string.Empty;
		}

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			this.txtPreview.Dispose();
		}

		#endregion
	}
}
