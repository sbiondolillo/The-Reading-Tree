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
            MessageBox.Show("Not Implemented");
        }

        private void btnCVCe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void btnCVCi_Click(object sender, EventArgs e)
        {
            LevelsMenu level = new LevelsMenu(btnCVCi.Text.ToString());
            level.Show();
            Close();
        }

        private void btnCVCo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void btnCVCu_Click(object sender, EventArgs e)
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
