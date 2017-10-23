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
    public partial class BlendsSpellingRulesMenu : Form
    {
        public BlendsSpellingRulesMenu()
        {
            InitializeComponent();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            Hide();
        }

        private void btn111SpellingRule_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void btn211SpellingRule_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }
    }
}
