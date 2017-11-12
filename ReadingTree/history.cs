using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingTree
{
    public static class history
    {
        public static string prev { get; set; }
        
        public static void doTheStuff()
        {
            switch (prev)
            {
                case "ASoundsMenu":
                    {
                        ASoundsMenu previous = new ASoundsMenu();
                        previous.Show();
                        break;
                    }
                case "ESoundsMenu":
                    {
                        ESoundsMenu previous = new ESoundsMenu();
                        previous.Show();
                        break;
                    }
                case "ISoundsMenu":
                    {
                        ISoundsMenu previous = new ISoundsMenu();
                        previous.Show();
                        break;
                    }
                case "OSoundsMenu":
                    {
                        OSoundsMenu previous = new OSoundsMenu();
                        previous.Show();
                        break;
                    }
                case "USoundsMenu":
                    {
                        USoundsMenu previous = new USoundsMenu();
                        previous.Show();
                        break;
                    }
                case "YSoundsMenu":
                    {
                        YSoundsMenu previous = new YSoundsMenu();
                        previous.Show();
                        break;
                    }
                case "BlendsSpellingRulesMenu":
                    {
                        BlendsSpellingRulesMenu previous = new BlendsSpellingRulesMenu();
                        previous.Show();
                        break;
                    }
                case "BlendsInitialMenu":
                    {
                        BlendsInitialMenu previous = new BlendsInitialMenu();
                        previous.Show();
                        break;
                        
                    }
                case "BlendsPhonicsMenu":
                    {
                        BlendsPhonicsMenu previous = new BlendsPhonicsMenu();
                        previous.Show();
                        break;

                    }
                case "BlendsLetterBlendsMenu":
                    {
                        BlendsLetterBlendsMenu previous = new BlendsLetterBlendsMenu();
                        previous.Show();
                        break;

                    }
                case "BlendsFinalDigraphMenu":
                    {
                        BlendsFinalDigraphMenu previous = new BlendsFinalDigraphMenu();
                        previous.Show();
                        break;

                    }
                    defualt:
                    {
                        break;
                    }
                    
            }
        }
    }
}
