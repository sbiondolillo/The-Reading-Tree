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
        public static List<string> ChosenWordsList { get; set; } = new List<string>();

        public static void SetPrev(System.Windows.Forms.Form parentForm)
        {
            prev.Push(parentForm);
        }

        public static System.Windows.Forms.Form GetPrev()
        {
            return prev.Pop();
        }
        
        public static void ClearHistory()
        {
            if (prev != null)
            {
                foreach (System.Windows.Forms.Form form in prev)
                {
                    if (form is MainMenu)
                        form.Hide();
                    else
                        form.Close();
                }
            }
            prev = new Stack<System.Windows.Forms.Form>();
        }
        public static void AddToChosenWords(List<string> wordsToAdd)
        {           
            foreach(String w in wordsToAdd)
            {
                if (!ChosenWordsList.Contains(w))
                    ChosenWordsList.Add(w);
            }
                //ChosenWordsList.AddRange(wordsToAdd);                                  
        }
        public static void RemoveFromChosenWords(string word)
        {
            ChosenWordsList.Remove(word);
        }
        public static void ClearChosenWords()
        {
            ChosenWordsList = new List<string>();
        }
    }
}
