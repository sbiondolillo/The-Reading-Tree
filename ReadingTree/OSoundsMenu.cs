/*
 * OSoundsMenu Class
 * Samuel Biondolillo
 * CSCN210M:HY1 Fall 2017
 * Goal: Create a class for the Reading Tree menu which points to the different
 *       sub-groups of words which focus on 'O' Sounds
 * Version  0.0.1   10/10/17
 */
 
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
    public partial class OSoundsMenu : Form
    {
        public OSoundsMenu()
        {
            InitializeComponent();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            Hide();
        }

        private void btnIE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void btnIEasIPie_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void btnIGH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }

        private void btnIasECalcium_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented");
        }
    }
}
