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

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            Close();
        }

        private void btnASounds_Click(object sender, EventArgs e)
        {
            ASoundsMenu asounds = new ASoundsMenu();
            asounds.Show();
            Close();
        }

        private void btnESounds_Click(object sender, EventArgs e)
        {
            ESoundsMenu esounds = new ESoundsMenu();
            esounds.Show();
            Close();
        }

        private void btnISounds_Click(object sender, EventArgs e)
        {
            ISoundsMenu isounds = new ISoundsMenu();
            isounds.Show();
            Close();
        }

        private void btnOSounds_Click(object sender, EventArgs e)
        {
            OSoundsMenu osounds = new OSoundsMenu();
            osounds.Show();
            Close();
        }

        private void btnUSounds_Click(object sender, EventArgs e)
        {
            USoundsMenu usounds = new USoundsMenu();
            usounds.Show();
            Close();
        }

        private void btnYSounds_Click(object sender, EventArgs e)
        {
            YSoundsMenu ysounds = new YSoundsMenu();
            ysounds.Show();
            Close();
        }
    }
}
