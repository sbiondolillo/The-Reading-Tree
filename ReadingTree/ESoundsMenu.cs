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
    public partial class ESoundsMenu : Form
    {
        public ESoundsMenu()
        {
            InitializeComponent();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            Close();
        }

        private void btnEABread_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Close();
        }

        private void btnEAEach_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Close();
        }

        private void btnEE_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Close();
        }

        private void btnEICeiling_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Close();
        }

        private void btnEIlongELongA_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Close();
        }

        private void btnEYValley_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Close();
        }

        private void btnEAA_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Close();
        }

        private void btnEIReindeer_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Close();
        }

        private void btnEighNeighbor_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Close();
        }
    }
}
