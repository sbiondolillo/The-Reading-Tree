using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingTree
{
    public static class History
    {
        static History()
        {
            prev = new Stack<System.Windows.Forms.Form>();
        }
        public static Stack<System.Windows.Forms.Form> prev { get; set; }
        public static List<List<string>> chosenWordsList { get; set; } = new List<List<string>>();

        public static void SetPrev(System.Windows.Forms.Form parentForm)
        {
            prev.Push(parentForm);
        }

        public static System.Windows.Forms.Form GetPrev()
        {
            return prev.Pop();
        }
        
        public static void Show_MainMenu()
        {
            if (prev != null)
            {
                foreach (System.Windows.Forms.Form form in prev)
                {
                    if (form is MainMenu)
                        form.Show();
                    else
                        form.Close();
                }
            }
            prev.Clear();
            
        }
        public static void AddToChosenWords(List<string> wordsToAdd, string groupName, int level)
        {
            bool wordAlreadyChosen = false;

            foreach (string wordToBeAdded in wordsToAdd)
            {
                List<string> newEntry = new List<string>();
                newEntry.Add(wordToBeAdded);
                newEntry.Add(groupName);
                newEntry.Add(level.ToString());

                foreach (List<string> activeList in chosenWordsList)
                {
                    if (newEntry.SequenceEqual(activeList))
                    {
                        wordAlreadyChosen = true;
                    }
                }

                if (!wordAlreadyChosen)
                {
                    chosenWordsList.Add(newEntry);
                }
            }                              
        }
        public static void RemoveFromChosenWords(string word)
        {
            List<string> selectedEntry = null;
            foreach (List<string> entry in chosenWordsList)
            {
                if (entry[0].Equals(word))
                {
                    selectedEntry = entry;
                }
            }
            if (selectedEntry != null)
            {
                chosenWordsList.Remove(selectedEntry);
            }
        }
        public static void ClearChosenWords()
        {
            chosenWordsList = new List<List<string>>();
        }
    }
}
