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
                        ASoundsMenu ASoundsMenu = new ASoundsMenu();
                        ASoundsMenu.Show();
                        break;
                    }
                case "ESoundsMenu":
                    {
                        ESoundsMenu ASoundsMenu = new ESoundsMenu();
                        ASoundsMenu.Show();
                        break;
                    }
                case "ISoundsMenu":
                    {
                        ISoundsMenu ASoundsMenu = new ISoundsMenu();
                        ASoundsMenu.Show();
                        break;
                    }
                case "OSoundsMenu":
                    {
                        OSoundsMenu ASoundsMenu = new OSoundsMenu();
                        ASoundsMenu.Show();
                        break;
                    }
                case "USoundsMenu":
                    {
                        USoundsMenu ASoundsMenu = new USoundsMenu();
                        ASoundsMenu.Show();
                        break;
                    }
                case "YSoundsMenu":
                    {
                        YSoundsMenu ASoundsMenu = new YSoundsMenu();
                        ASoundsMenu.Show();
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
