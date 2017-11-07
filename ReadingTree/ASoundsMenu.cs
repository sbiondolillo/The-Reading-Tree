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
    public partial class ASoundsMenu : Form
    {
        public ASoundsMenu()
        {
            InitializeComponent();
        }

        private void btnAESounds_Click(object sender, EventArgs e)
        {
            LevelsMenu level = new LevelsMenu(btnAESounds.Text.ToString());
            level.Show();
            Close();
        }

        private void btnAISounds_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void btnAUSounds_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void btnAYSounds_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            Hide();
        }
    }
}
