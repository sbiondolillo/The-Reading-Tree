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
    public partial class VCVariablesMenu : Form
    {
        private bool userClosed { get; set; } = false;
        public VCVariablesMenu()
        {
            InitializeComponent();
        }
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Close();
        }
        private void btnVCCVE_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Hide();
        }
        private void btnVCV_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Hide();
        }
        private void btnVCCV_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Hide();
        }
        private void btnVC_CCCV_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Hide();
        }
        private void btnVC_CCV_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Hide();
        }
        private void btnVCC_CCV_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Hide();
        }
        private void btnVCC_CV_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Hide();
        }
        private void btnVCCC_CV_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Hide();
        }
        private void btnVCCCCVmixed_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Hide();
        }
        private void btnVCCCVmixed_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
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
