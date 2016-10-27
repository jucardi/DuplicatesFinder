// <copyright file="IFileDisplayer.cs" >
//   Jucardi. All Rights Reserved.
// </copyright>
// <author>juan.diaz</author>
// <date>10/21/2013 12:48:12 AM</date>
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.

using System;
using System.Windows.Forms;

namespace DuplicatesFinder.FileDisplayers
{
	interface IFileDisplayer : IDisposable
	{
		/// <summary>
		/// Gets the display control.
		/// </summary>
		/// <value>
		/// The display control.
		/// </value>
		Control DisplayControl { get; }

		/// <summary>
		/// Gets the extensions.
		/// </summary>
		/// <value>
		/// The extensions.
		/// </value>
		string[] Extensions { get; }

		/// <summary>
		/// Loads the file.
		/// </summary>
		/// <param name="file">The file.</param>
		/// <returns></returns>
		bool LoadFile(string file);

		/// <summary>
		/// Releases the resources.
		/// </summary>
		void ReleaseResources();
	}
}
