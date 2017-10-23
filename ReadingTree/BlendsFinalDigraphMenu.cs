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
    public partial class BlendsFinalDigraphMenu : Form
    {
        public BlendsFinalDigraphMenu()
        {
            InitializeComponent();
        }

        private void btnBlendsDigraph_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void btnBlendsFinalMixed_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void btnBlendsFinalDigraph_Click(object sender, EventArgs e)
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
