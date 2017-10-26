/* Based on https://www.codeproject.com/Articles/415732/Reading-and-Writing-CSV-Files-in-Csharp
 * Modified by Brad Wight
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSV_ReadWrite
{
	// Class to hold one csv row
	public class CsvRow : List<string>
	{
		public string RowText { get; set; }
	}

	// Class to read from a csv file
	public class CsvReader : StreamReader
	{
		public CsvReader(string file) : base(file)
		{
		}
		public CsvReader(Stream stream) : base(stream)
		{
		}

		// Read a row from the file
		public bool ReadRow(CsvRow row)
		{
			row.RowText = ReadLine ();

			if (String.IsNullOrEmpty (row.RowText))
				return false;

			int rows = 0;
			int position = 0;

			while (position < row.RowText.Length)
			{
				string value;

				// Parse a word
				int start = position;
				while (position < row.RowText.Length && row.RowText [position] != ',')
					position++;
				value = row.RowText.Substring (start, position - start);

				// Add a field to the list
				if (rows < row.Count)
					row [rows] = value;
				else
					row.Add (value);
				rows++;

				// Go to the next word
				while (position < row.RowText.Length && row.RowText [position] != ',')
					position++;
				if (position < row.RowText.Length)
					position++;
			}
			// Delete extras
			while (row.Count > rows)
				row.RemoveAt (rows);

			return (row.Count > 0);
		}
	}

	// Class to write to a csv file
	public class CsvWriter : StreamWriter
	{
		public CsvWriter(string file) : base(file)
		{
		}
		public CsvWriter(Stream stream) : base(stream)
		{
		}

		public void WriteRow(CsvRow row)
		{
			StringBuilder build = new StringBuilder();
			bool first = true;

			foreach (string value in row)
			{
				if (!first)
					build.Append (',');
				build.Append (value);
				first = false;
			}
			row.RowText = build.ToString ();
			WriteLine (row.RowText);
		}
	}
}

