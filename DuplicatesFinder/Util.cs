// <copyright file="Util.cs" >
//   Jucardi. All Rights Reserved.
// </copyright>
// <author>juan.diaz</author>
// <date>10/20/2013 9:23:20 AM</date>
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.

using System;
using System.IO;
using System.Text;

namespace DuplicatesFinder
{
	internal class Util
	{
		#region Methods

		/// <summary>
		/// Converts the byte array to a string in hex representation.
		/// </summary>
		/// <param name="inputArray">The input array.</param>
		/// <returns>Hex representation of the byte array.</returns>
		public static string ByteArrayToHex(byte[] inputArray)
		{
			StringBuilder output = new StringBuilder();

			for (int i = 0; i < inputArray.Length; i++)
				output.Append(inputArray[i].ToString("X2"));

			return output.ToString();
		}

		/// <summary>
		/// Converts the size.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>string representation of the size</returns>
		public static string ConvertSize(long value)
		{
			string[] suffixes = { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
			double dValue = (double)value;
			int i = 0;

			while (Math.Round(dValue / 1024) >= 1)
			{
				dValue /= 1024;
				i++;
			}

			string format = i == 0 ? "{0} {1}" : "{0:n3} {1}";

			return string.Format(format, dValue, suffixes[i]);
		}

		/// <summary>
		/// Copies the stream.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <param name="output">The output.</param>
		public static void CopyStream(Stream input, Stream output)
		{
			byte[] buffer = new byte[32768]; // 32Kb buffer.
			int    read   = 0;

			while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
				output.Write(buffer, 0, read);
		}

		#endregion
	}
}
