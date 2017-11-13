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
    public partial class LatinChamPrefixMenu : Form
    {
        public LatinChamPrefixMenu()
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

        private void BTN_Di_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Hide();
        }

        private void BTN_In_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Hide();
        }

        private void BTN_Sub_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Hide();
        }

        private void BTN_Con_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Hide();
        }
    }
}
