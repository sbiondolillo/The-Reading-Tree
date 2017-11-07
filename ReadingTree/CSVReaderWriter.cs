/* Based on https://www.codeproject.com/Articles/415732/Reading-and-Writing-CSV-Files-in-Csharp
 * Modified by Brad Wight
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ReadingTree
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
			
		static string baseFP = Directory.GetCurrentDirectory();
		public static string masterFP = baseFP + "/resources/all_levels.csv";

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

	// Class to hold other methods (get words, add & delete words)
	public class Methods
	{
		/* Method to get all the words from a list on all levels
		 * Call this method from the Main method like this:
		 * List<List<string>> allWords = Methods.GetAllWords ("ject (Latin word root)");
		 */
		public static List<List<string>> GetAllWords(string groupname)
		{
			groupname = groupname.Trim();

			// Array to hold multiple lists
			List<List<string>> lists = new List<List<string>>();

			for (int i = 1; i <= 5; i++)
			{
				string lvl = i.ToString();
				using (CsvReader reader = new CsvReader (CsvReader.masterFP))
				{
					CsvRow row = new CsvRow();

					// This list holds the words to display
					List<string> words = new List<string>();

					while (reader.ReadRow(row))
					{
						// Locate the list to get words from
						if (row [0].Equals (lvl) && (row [1].Equals (groupname)))
						{
							// Get rid of any extra empty cells
							row.RemoveAll (string.IsNullOrWhiteSpace);

							// Delete the first two elements because we don't want them in our words
							row.RemoveAt (1);
							row.RemoveAt (0);

							// Add all words in the row to the words list
							foreach (string s in row)
								words.Add (s);
						}
					}
					lists.Insert(i - 1, words);
				}
			}
			//foreach (List<string> wrds in lists)
			//	foreach (string s in wrds)
			//		Console.WriteLine (s);

			return lists;
		}

	}
}

