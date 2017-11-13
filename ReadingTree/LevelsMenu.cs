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
        public LevelsMenu()
        {
            InitializeComponent();
        }
        public LevelsMenu(string group_name)
        {
            InitializeComponent();
            this.group_name = group_name;
        }
        public void SetGroupName(string group)
        {
            this.group_name = group;
        }
        private void LevelsMenu_Load(object sender, EventArgs e)
        {
            GroupNameLabel.Text = group_name;
            InitializeLevelsListBoxes();
            SelectDefaultRadioButton();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            History.ClearHistory();
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
    }
}
