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

        private void btnYSounds_Click(object sender, EventArgs e)
        {

        }

        private void btnUSounds_Click(object sender, EventArgs e)
        {

        }

        private void btnOSounds_Click(object sender, EventArgs e)
        {

        }

        private void btnISounds_Click(object sender, EventArgs e)
        {
            ISoundsMenu isounds = new ISoundsMenu();
            isounds.Show();
            Hide();
        }

        private void VowelSoundsPromptLabel_Click(object sender, EventArgs e)
        {

        }

        private void VoweSoundslabel_Click(object sender, EventArgs e)
        {

        }
    }
}
