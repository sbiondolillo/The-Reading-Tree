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
    public partial class SuffixesMenu : Form
    {
        private bool userClosed { get; set; } = false;
        public SuffixesMenu()
        {
            InitializeComponent();
        }

        private void BTN_MainMenu_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            Close();
        }

        private void BTN_Suffix_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            SuffixSubMenu SufSubmenu = new SuffixSubMenu();
            SufSubmenu.Show();
            Hide();
        }

        private void BTN_LS_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            LatinSuffixMenu LSmenu = new LatinSuffixMenu();
            LSmenu.Show();
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
