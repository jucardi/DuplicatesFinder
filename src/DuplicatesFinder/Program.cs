// <copyright file="Program.cs" >
//   Jucardi. All Rights Reserved.
// </copyright>
// <author>juan.diaz</author>
// <date>8/7/2013 1:09:47 PM</date>
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.

using System;
using System.Windows.Forms;

namespace DuplicatesFinder
{
	internal static class Program
	{
		public const string TEMP_FOLDER = "$dupefinder";

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		internal static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
