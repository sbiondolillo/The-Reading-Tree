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
            History.SetPrev(this);
            MainMenu main = new MainMenu();
            main.Show();
            Close();
        }

        private void btnASounds_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            ASoundsMenu asounds = new ASoundsMenu();
            asounds.Show();
            Close();
        }

        private void btnESounds_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            ESoundsMenu esounds = new ESoundsMenu();
            esounds.Show();
            Close();
        }

        private void btnISounds_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            ISoundsMenu isounds = new ISoundsMenu();
            isounds.Show();
            Close();
        }

        private void btnOSounds_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            OSoundsMenu osounds = new OSoundsMenu();
            osounds.Show();
            Close();
        }

        private void btnUSounds_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            USoundsMenu usounds = new USoundsMenu();
            usounds.Show();
            Close();
        }

        private void btnYSounds_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            YSoundsMenu ysounds = new YSoundsMenu();
            ysounds.Show();
            Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form previous = History.GetPrev();
            previous.Show();
            Close();
        }
    }
}
