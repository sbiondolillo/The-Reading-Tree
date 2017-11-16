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

        public static string masterFP = "..\\resources\\all_levels.csv";

        // Read a row from the file
        public bool ReadRow(CsvRow row)
        {
            row.RowText = ReadLine();

            if (String.IsNullOrEmpty(row.RowText))
                return false;

            int rows = 0;
            int position = 0;

            while (position < row.RowText.Length)
            {
                string value;

                // Parse a word
                int start = position;
                while (position < row.RowText.Length && row.RowText[position] != ',')
                    position++;
                value = row.RowText.Substring(start, position - start);

                // Add a field to the list
                if (rows < row.Count)
                    row[rows] = value;
                else
                    row.Add(value);
                rows++;

                // Go to the next word
                while (position < row.RowText.Length && row.RowText[position] != ',')
                    position++;
                if (position < row.RowText.Length)
                    position++;
            }
            // Delete extras
            while (row.Count > rows)
                row.RemoveAt(rows);

            return (row.Count > 0);
        }

    }

    // Class to write to a csv file
    public class CsvWriter : StreamWriter
    {
        public static string masterFP = "..\\resources\\all_levels.csv";
        public static string tempFP = "..\\resources\\tempFP.csv";
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
                    build.Append(',');
                build.Append(value);
                first = false;
            }
            row.RowText = build.ToString();
            WriteLine(row.RowText);
        }
        public static void AddWord(int lvl, string listname, string word)
        {
            string level = lvl.ToString();
            listname = listname.Trim();
            word = word.Trim().ToLower();

            // Remove any commas or quotation marks from the word
            if (word.Contains(","))
                word = word.Replace(",", "");
            if (word.Contains("\""))
                word = word.Replace("\"", "");

            // Create a File Stream to read from
            FileStream fs = new FileStream(@masterFP, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);

            // Add a word to the end of the desired list
            using (CsvReader reader = new CsvReader(fs))
            using (CsvWriter writer = new CsvWriter(tempFP))
            {
                CsvRow row = new CsvRow();
                while (reader.ReadRow(row))
                {
                    // Locate the list to add the word to
                    if (row[0].Equals(level) && row[1].Equals(listname))
                    {
                        // Check if the word is already in the list
                        foreach (string wrd in row)
                            if (word.Equals(wrd))
                            {
                                Console.WriteLine("Error: That word is already in the list.");
                                return;
                            }
                        // Remove empty strings, add the word, and write to the file
                        row.RemoveAll(string.IsNullOrWhiteSpace);
                        row.Add(word);
                        writer.WriteRow(row);
                        Console.WriteLine(String.Format("Added word {0} to list {1} for level {2}", word, listname, level));
                    }
                    else
                        // Write the rest of the rows
                        writer.WriteRow(row);
                }
            }
            File.Delete(masterFP);

            // Rename temp.csv to all_levels
            File.Move(tempFP, masterFP);
        }
        public static void DeleteWord(int lvl, string listname, string word)
        {
            string level = lvl.ToString();
            listname = listname.Trim();
            word = word.Trim().ToLower();

            // Create a File Stream to read from
            FileStream fs = new FileStream(@masterFP, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);

            // Remove a word from a list
            using (CsvReader reader = new CsvReader(fs))
            using (CsvWriter writer = new CsvWriter(tempFP))
            {
                CsvRow row = new CsvRow();
                while (reader.ReadRow(row))
                {
                    // Locate the list to delete the word from
                    if (row[0].Equals(level) && row[1].Equals(listname))
                    {
                        // Find the word in the list and remove it
                        for (int i = row.Count - 1; i >= 0; i--)
                            if (row[i].Equals(word))
                                row.RemoveAt(i);

                        // Remove any empty spaces, then write the row
                        row.RemoveAll(string.IsNullOrWhiteSpace);
                        writer.WriteRow(row);
                        Console.WriteLine(String.Format("Removed word {0} from list {1} for level {2}", word, listname, level));
                    }
                    else
                        // Write the rest of the rows
                        writer.WriteRow(row);
                }
            }
            File.Delete(masterFP);

            // Rename temp.csv to all_levels
            File.Move(tempFP, masterFP);
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
                using (CsvReader reader = new CsvReader(CsvReader.masterFP))
                {
                    CsvRow row = new CsvRow();

                    // This list holds the words to display
                    List<string> words = new List<string>();

                    while (reader.ReadRow(row))
                    {
                        // Locate the list to get words from
                        if (row[0].Equals(lvl) && (row[1].Equals(groupname)))
                        {
                            // Get rid of any extra empty cells
                            row.RemoveAll(string.IsNullOrWhiteSpace);

                            // Delete the first two elements because we don't want them in our words
                            row.RemoveAt(1);
                            row.RemoveAt(0);

                            // Add all words in the row to the words list
                            foreach (string s in row)
                                words.Add(s);
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