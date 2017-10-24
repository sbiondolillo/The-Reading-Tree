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
            this.Hide();
        }

        private void btnEABread_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void btnEAEach_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void btnEE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void btnEICeiling_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void btnEIlongELongA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void btnEYValley_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void btnEAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void btnEIReindeer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void btnEighNeighbor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }
    }
}
