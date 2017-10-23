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
    public partial class BlendsMenu : Form
    {
        public BlendsMenu()
        {
            InitializeComponent();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            Hide();
        }

        private void btnBlendsInitial_Click(object sender, EventArgs e)
        {
            BlendsInitialMenu blendsInitialMenu = new BlendsInitialMenu();
            blendsInitialMenu.Show();
            Hide();
        }

        private void btnBlendsFinalDigraph_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void btnLetterBlends_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void btnSpellingRules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void btnPhonics_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }
    }
}
