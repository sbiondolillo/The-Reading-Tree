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
    public partial class LevelsMenu : Form
    {
        private string group_name = "";
        private bool userClosed { get; set; } = false;
        public LevelsMenu(string group_name)
        {
            InitializeComponent();
            this.group_name = group_name;
        }
        private void LevelsMenu_Load(object sender, EventArgs e)
        {
            GroupNameLabel.Text = group_name;
            InitializeLevelsListBoxes();
            SelectDefaultRadioButton();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            Close();
        }

        private void InitializeLevelsListBoxes()
        {
            List<List<string>> words = Methods.GetAllWords(group_name);
            level1Box.DataSource = words[0];
            level2Box.DataSource = words[1];
            level3Box.DataSource = words[2];
            level4Box.DataSource = words[3];
            level5Box.DataSource = words[4];
        }

        private void SelectDefaultRadioButton()
        {
            if (level1Box.Items.Count > 0) {
                radioButtonLevel1.Select();
            }
            else if (level2Box.Items.Count > 0)
            {
                radioButtonLevel2.Select();
            }
            else if (level3Box.Items.Count > 0)
            {
                radioButtonLevel3.Select();
            }
            else if (level4Box.Items.Count > 0)
            {
                radioButtonLevel4.Select();
            }
            else
            {
                radioButtonLevel5.Select();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
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
