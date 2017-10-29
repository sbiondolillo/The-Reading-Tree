/* 
 * Code by Brad Wight
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSV_ReadWrite
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//AddWord(2, "dis-(prefix)", "Testing");
			//DeleteWord(2, "dis-(prefix)", "Testing");
			//GetWords(2, "ng & nk", 12);
		}
		// The locations of the master and temp CSV files
		static string baseFP = Directory.GetCurrentDirectory();
		static string masterFP = baseFP + "/csv/all_levels.csv";
		static string tempFP = baseFP + "/csv/temp.csv";

		public static void AddWord(int lvl, string listname, string word)
		{
			string level = lvl.ToString ();
			listname = listname.Trim ();
			word = word.Trim ().ToLower ();

			// Remove any commas or quotation marks from the word
			if (word.Contains (","))
				word = word.Replace (",", "");
			if (word.Contains ("\""))
				word = word.Replace ("\"", "");

			// Create a File Stream to read from
			FileStream fs = new FileStream (@masterFP, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
			
			// Add a word to the end of the desired list
			using (CsvReader reader = new CsvReader(fs))
			using (CsvWriter writer = new CsvWriter(tempFP))
			{
				CsvRow row = new CsvRow ();
				while (reader.ReadRow (row)) 
				{
					// Locate the list to add the word to
					if (row [0].Equals (level) && row [1].Equals (listname))
					{
						// Check if the word is already in the list
						foreach (string wrd in row)
							if (word.Equals(wrd))
							{
								Console.WriteLine ("Error: That word is already in the list.");
								return;
							}
						// Remove empty strings, add the word, and write to the file
						row.RemoveAll (string.IsNullOrWhiteSpace);
						row.Add (word);
						writer.WriteRow (row);
						Console.WriteLine (String.Format("Added word {0} to list {1} for level {2}", word, listname, level));
					} else
						// Write the rest of the rows
						writer.WriteRow (row);	
				}
			}
			File.Delete(masterFP);

			// Rename temp.csv to all_levels
			File.Move(tempFP, masterFP);
		}


		public static void DeleteWord(int lvl, string listname, string word)
		{
			string level = lvl.ToString ();
			listname = listname.Trim ();
			word = word.Trim ().ToLower ();

			// Create a File Stream to read from
			FileStream fs = new FileStream (@masterFP, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);

			// Remove a word from a list
			using (CsvReader reader = new CsvReader (fs))
			using (CsvWriter writer = new CsvWriter (tempFP)) {
				CsvRow row = new CsvRow ();
				while (reader.ReadRow (row)) 
				{
					// Locate the list to delete the word from
					if (row [0].Equals (level) && row [1].Equals (listname)) 
					{
						// Find the word in the list and remove it
						for (int i = row.Count - 1; i >= 0; i--)
							if (row [i].Equals (word))
								row.RemoveAt (i);
							
						// Remove any empty spaces, then write the row
						row.RemoveAll (string.IsNullOrWhiteSpace);
						writer.WriteRow (row);
						Console.WriteLine (String.Format ("Removed word {0} from list {1} for level {2}", word, listname, level));
					} else
						// Write the rest of the rows
						writer.WriteRow (row);
				}
			}
			File.Delete(masterFP);

			// Rename temp.csv to all_levels
			File.Move(tempFP, masterFP);				
		}

		// Get words from a list
		public static void GetWords(int lvl, string listname, int amount)
		{
			string level = lvl.ToString ();
			listname = listname.Trim ();

			// This list holds the words to display
			List<string> words = new List<string> ();

			using (CsvReader reader = new CsvReader (masterFP))
			{
				CsvRow row = new CsvRow ();
				Random random = new Random ();

				while(reader.ReadRow(row))
				{
					// Locate the list to get words from
					if (row [0].Equals (level) && row [1].Equals (listname))
					{
						// Get rid of any extra empty cells
						row.RemoveAll (string.IsNullOrWhiteSpace);

						// Delete the first two elements because we don't want them in our words
						row.RemoveAt (1);
						row.RemoveAt (0);

						// Check if the amount of words requested is more than the list size
						if (amount > row.Count)
						{
							Console.WriteLine (String.Format ("Not enough words in the list {0}. Printing entire list:", listname));
							foreach (string s in row)
							{
								Console.Write(s);
								Console.Write(" ");
							}
						}

						// Find random words
						for (int i = 0; i < amount; i++) 
						{
							begin:
							int num = random.Next (row.Count);
							string word = row [num];

							// Make sure it's not already in the list (no duplicates)
							foreach (string wrd in words)
								if (word.Equals (wrd))
									goto begin;

							words.Add (word);
						}

						// Show the words
						string amnt = amount.ToString ();
						Console.WriteLine (String.Format ("{0} words from the list {1} on level {2}:", amnt, listname, level));
						foreach (string w in words)
						{
							Console.Write (w);
							Console.Write (" ");
						}
					}
				}
			}
		}
	}
}
