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
    public partial class PrefixesMenu : Form
    {
        public PrefixesMenu()
        {
            InitializeComponent();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            this.Hide();
        }

        private void BTN_NP_Click(object sender, EventArgs e)
        {
            NormPrefixMenu NPmenu = new NormPrefixMenu();
            NPmenu.Show();
            this.Hide();
        }

        private void BTN_LP_Click(object sender, EventArgs e)
        {
            LatinPrefixMenu LPmenu = new LatinPrefixMenu();
            LPmenu.Show();
            this.Hide();
        }

        private void BTN_LCP_Click(object sender, EventArgs e)
        {
            LatinChamPrefixMenu LCPmenu = new LatinChamPrefixMenu();
            LCPmenu.Show();
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
