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
    public partial class CVCMenu : Form
    {
        public CVCMenu()
        {
            InitializeComponent();
        }

        private void btnCVCa_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Close();
        }

        private void btnCVCe_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Close();
        }

        private void btnCVCi_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Close();
        }

        private void btnCVCo_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Close();
        }

        private void btnCVCu_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Close();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MainMenu m = new MainMenu();
            m.Show();
            Close();
        }
    }
}
