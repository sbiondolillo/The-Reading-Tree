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
            List<string> newEntry = new List<string>();
            int id = -1;
            string name_lvl = groupName + " " + level.ToString();
            bool wordAlreadyChosen = false;
            foreach(List<string> activeList in chosenWordsList)
            {
                if (activeList[0].Equals(name_lvl))
                {
                    id = chosenWordsList.IndexOf(activeList);
                    break;
                }
            }
            if (id != -1)
            {
                foreach (string wordToBeAdded in wordsToAdd)
                {

                    foreach (string active in chosenWordsList[id])
                    {
                        if (active.Equals(wordToBeAdded))
                        {
                            wordAlreadyChosen = true;
                        }
                    }

                    if (!wordAlreadyChosen)
                    {
                        chosenWordsList[id].Add(wordToBeAdded);
                    }
                }
            }
            else
            {
                newEntry.Add(name_lvl);
                foreach (string wordToBeAdded in wordsToAdd)
                {
                    newEntry.Add(wordToBeAdded);
                }
                chosenWordsList.Add(newEntry);
            }
        }
        public static void RemoveFromChosenWords(string word)
        {
            List<string> emptyGroup = null;
            foreach (List<string> entry in chosenWordsList)
            {
                bool found = false;
                for (int i = 1; i < entry.Count; i++)
                {
                    string target = entry[i];
                    if (target.Equals(word))
                    {
                        entry.Remove(target);
                        found = true;
                        break;
                    }
                }
                
                if (entry.Count < 2)
                {
                    emptyGroup = entry;
                }

                if (found)
                {
                    break;
                }
            }

            if (emptyGroup != null)
            {
                chosenWordsList.Remove(emptyGroup);
            }
            
        }
        public static void ClearChosenWords()
        {
            chosenWordsList = new List<List<string>>();
        }
        
        public static List<string> FindInChosenWords(string word)
        {
            List<string> output = new List<string>();
            foreach (List<string> entry in chosenWordsList)
            {
                foreach (string s in entry)
                {
                    if (s.Equals(word))
                    {
                        output.Add(s);
                    }
                }
            }
            return output;
        }
    }
}
