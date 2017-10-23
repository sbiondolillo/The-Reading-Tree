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
    public partial class VowelSoundsMenu : Form
    {
        public VowelSoundsMenu()
        {
            InitializeComponent();
        }

        private void btnASounds_Click(object sender, EventArgs e)
        {
            ASoundsMenu asounds = new ASoundsMenu();
            asounds.Show();
            this.Hide();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            this.Hide();
        }

        private void btnESounds_Click(object sender, EventArgs e)
        {
            ESoundsMenu esounds = new ESoundsMenu();
            esounds.Show();
            Hide();
        }
    }
}
