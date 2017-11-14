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
        private bool userClosed { get; set; } = false;
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
            History.SetPrev(this);
            ASoundsMenu asounds = new ASoundsMenu();
            asounds.Show();
            Hide();
        }

        private void btnESounds_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            ESoundsMenu esounds = new ESoundsMenu();
            esounds.Show();
            Hide();
        }

        private void btnISounds_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            ISoundsMenu isounds = new ISoundsMenu();
            isounds.Show();
            Hide();
        }

        private void btnOSounds_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            OSoundsMenu osounds = new OSoundsMenu();
            osounds.Show();
            Hide();
        }

        private void btnUSounds_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            USoundsMenu usounds = new USoundsMenu();
            usounds.Show();
            Hide();
        }

        private void btnYSounds_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            YSoundsMenu ysounds = new YSoundsMenu();
            ysounds.Show();
            Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form previous = History.GetPrev();
            previous.Show();
            Close();
        }
        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            /// tests if the form was closed by the Close() method or by the user clicking the 'X' button
            /// if the user clicks the 'X' button, we want to exit the application, otherwise, proceed as normal
            /// adapted from https://stackoverflow.com/questions/13361260/how-to-distinguish-window-close-button-clicked-x-vs-window-close-in-closi
            bool closedWithXButton = new System.Diagnostics.StackTrace().GetFrames().FirstOrDefault(x => x.GetMethod() == typeof(Form).GetMethod("Close")) == null;
            if (closedWithXButton)
            {
                userClosed = true;
            }
        }
        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            if (userClosed)
                Application.Exit();
        }
    }
}
