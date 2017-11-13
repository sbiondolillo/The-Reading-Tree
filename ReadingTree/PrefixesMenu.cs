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

        private void BTN_NP_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            NormPrefixMenu NPmenu = new NormPrefixMenu();
            NPmenu.Show();
            Hide();
        }

        private void BTN_LP_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            LatinPrefixMenu LPmenu = new LatinPrefixMenu();
            LPmenu.Show();
            Hide();
        }

        private void BTN_LCP_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            LatinChamPrefixMenu LCPmenu = new LatinChamPrefixMenu();
            LCPmenu.Show();
            Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form previous = History.GetPrev();
            previous.Show();
            Close();
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            History.ClearHistory();
            MainMenu main = new MainMenu();
            main.Show();
            Close();
        }
    }
}
