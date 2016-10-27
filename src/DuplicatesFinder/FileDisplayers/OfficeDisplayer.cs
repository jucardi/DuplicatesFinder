// <copyright file="OfficeDisplayer.cs" >
//   Jucardi. All Rights Reserved.
// </copyright>
// <author>juan.diaz</author>
// <date>10/26/2013 12:45:29 PM</date>
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.

using System;
using Microsoft.Office.Interop.Word;
using System.Windows.Forms;

namespace DuplicatesFinder.FileDisplayers
{
	internal class OfficeDisplayer : WebDisplayer
	{
		#region Constants

		private static readonly string[] EXTENSIONS =
			new string[] {  "doc", "docx", "xls", "xlsx", "ppt", "pptx", "pps", "ppsx" };

		#endregion

		#region Properties

		/// <summary>
		/// Gets the extensions.
		/// </summary>
		/// <value>
		/// The extensions.
		/// </value>
		public override string[] Extensions
		{
			get { return EXTENSIONS; }
		}

		#endregion

		#region Methods

		/// <summary>
		/// Loads the file.
		/// </summary>
		/// <param name="file">The file.</param>
		/// <returns></returns>
		public override bool LoadFile(string file)
		{
			try
			{
				this.browser.Url = new Uri(this.ConvertDocument(file));
				this.browser.Refresh();
			}
			catch
			{
				return false;
			}

			return true;
		}

		/// <summary>
		/// Converts the document.
		/// </summary>
		/// <param name="fileName">Name of the file.</param>
		private string ConvertDocument(string fileName)
		{
			// All declarations are objects due to the methods signatures to invoke.
			// When using 'ref', the object cast must be explicit.
			object           m           = System.Reflection.Missing.Value;
			object           oldFileName = (object)fileName;
			object           readOnly    = (object)false;
			object           newFileName = null;
			object           fileType    = (object)WdSaveFormat.wdFormatPDF; // File format to save the temporary file.
			ApplicationClass ac          = null;

			try
			{
				// Create a new Microsoft.Office.Interop.Word.ApplicationClass.
				ac = new ApplicationClass();

				// Open document
				Document doc = ac.Documents.Open(ref oldFileName, ref m, ref readOnly,
						ref m, ref m, ref m, ref m, ref m, ref m, ref m,
						 ref m, ref m, ref m, ref m, ref m, ref m);

				// Create a temp file to convert the document to HTML  format.
				newFileName = this.GetRandomFileName("pdf");

				// Save the file.
				doc.SaveAs(ref newFileName, ref fileType,
						ref m, ref m, ref m, ref m, ref m, ref m, ref m,
						ref m, ref m, ref m, ref m, ref m, ref m, ref m);
			}
			finally
			{
				// Close the application class
				if (ac != null)
					ac.Quit(ref readOnly, ref m, ref m);
			}

			this.tempFile = newFileName.ToString();
			return newFileName.ToString();
		}

		#endregion
	}
}
