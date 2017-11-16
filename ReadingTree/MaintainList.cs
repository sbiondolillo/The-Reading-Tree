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
    public partial class MaintainList : Form
    {
        private string group_name;
        private string RadioLvl;
        public MaintainList(string group_name, string RadioLvl)
        {
            InitializeComponent();
            this.group_name = group_name;
            this.RadioLvl = RadioLvl;
            GroupLbl.Text = group_name;
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            string NewWord = Inputbox.Text;
            int Lvl = Convert.ToInt32(RadioLvl);
            DialogResult res = MessageBox.Show("Are you sure you want to delete " + NewWord, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                MessageBox.Show("You have deleted " + NewWord + ".", NewWord + " deleted");
                CsvWriter.DeleteWord(Lvl, group_name, NewWord);
                Reload();
            }
            if (res == DialogResult.Cancel)
            {
                //Do Nothing
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string NewWord = Inputbox.Text;
            int Lvl = Convert.ToInt32(RadioLvl);
            CsvWriter.AddWord(Lvl, group_name, NewWord);
            Reload();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            LevelsMenu Level = new LevelsMenu(group_name);
            Level.Show();
            Close();
        }

        private void Reload()
        {
            List<List<string>> words = Methods.GetAllWords(group_name);
            switch (RadioLvl)
            {
                case "1":
                    GroupBox.DataSource = words[0];
                    break;
                case "2":
                    GroupBox.DataSource = words[1];
                    break;
                case "3":
                    GroupBox.DataSource = words[2];
                    break;
                case "4":
                    GroupBox.DataSource = words[3];
                    break;
                case "5":
                    GroupBox.DataSource = words[4];
                    break;
                case "":
                    MessageBox.Show("Please indicate the Level from the Group you wish to work on!");
                    LevelsMenu Level = new LevelsMenu(group_name);
                    Level.Show();
                    Close();
                    break;
            }
        }

        private void MaintainList_Load(object sender, EventArgs e)
        {
            {
                Reload();
            }
        }
    }
}
