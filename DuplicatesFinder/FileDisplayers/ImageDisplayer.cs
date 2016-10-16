// <copyright file="ImageDisplayer.cs" >
//   Jucardi. All Rights Reserved.
// </copyright>
// <author>juan.diaz</author>
// <date>10/21/2013 12:50:48 AM</date>
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DuplicatesFinder.FileDisplayers
{
	internal class ImageDisplayer : IFileDisplayer
	{
		#region Constants

		private static readonly string[] IMAGE_EXTENSIONS =
			new string[] { "jpg", "jpeg", "gif", "bmp", "png", "tiff", "wmf", "emf", "ico", "tga" };

		#endregion

		#region Fields

		private PictureBox pboxPreview = new PictureBox();
		private Stream     imageStream = null;

		#endregion

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="ImageDisplayer"/> class.
		/// </summary>
		public ImageDisplayer()
		{
			this.pboxPreview.BackColor = System.Drawing.Color.White;
			this.pboxPreview.Dock      = System.Windows.Forms.DockStyle.Fill;
			this.pboxPreview.SizeMode  = System.Windows.Forms.PictureBoxSizeMode.Zoom;
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
			get { return this.pboxPreview; }
		}

		/// <summary>
		/// Gets the extensions.
		/// </summary>
		/// <value>
		/// The extensions.
		/// </value>
		public string[] Extensions
		{
			get { return IMAGE_EXTENSIONS; }
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
			this.ReleaseResources();
			this.imageStream = new MemoryStream();

			try
			{
				using (FileStream fs = File.Open(file, FileMode.Open, FileAccess.Read))
					Util.CopyStream(fs, imageStream);

				this.pboxPreview.Image = Image.FromStream(this.imageStream);
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
		public void ReleaseResources()
		{
			Image currentImg = this.pboxPreview.Image;
			this.pboxPreview.Image = null;

			if (currentImg != null)
				currentImg.Dispose();

			if (this.imageStream != null)
			{
				this.imageStream.Flush();
				this.imageStream.Dispose();
			}

			GC.Collect();
		}

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			this.ReleaseResources();
			this.pboxPreview.Dispose();
		}

		#endregion
	}
}
