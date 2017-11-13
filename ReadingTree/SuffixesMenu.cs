using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadingTree
{
    public partial class SuffixesMenu : Form
    {
        public SuffixesMenu()
        {
            InitializeComponent();
        }

        private void BTN_MainMenu_Click(object sender, EventArgs e)
        {
            History.ClearHistory();
            MainMenu main = new MainMenu();
            main.Show();
            Close();
        }

        private void BTN_Suffix_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            SuffixSubMenu SufSubmenu = new SuffixSubMenu();
            SufSubmenu.Show();
            Hide();
        }

        private void BTN_LS_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            LatinSuffixMenu LSmenu = new LatinSuffixMenu();
            LSmenu.Show();
            Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form previous = History.GetPrev();
            previous.Show();
            Close();
        }
    }
}
