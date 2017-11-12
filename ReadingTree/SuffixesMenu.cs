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
            MainMenu main = new MainMenu();
            main.Show();
            this.Hide();
        }

        private void BTN_Suffix_Click(object sender, EventArgs e)
        {
            SuffixSubMenu SufSubmenu = new SuffixSubMenu();
            SufSubmenu.Show();
            this.Hide();
        }

        private void BTN_LS_Click(object sender, EventArgs e)
        {
            LatinSuffixMenu LSmenu = new LatinSuffixMenu();
            LSmenu.Show();
            this.Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MainMenu m = new MainMenu();
            m.Show();
            Close();
        }
    }
}
