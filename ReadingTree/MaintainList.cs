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
        private string group_name { get; set; }
        private int Level { get; set; }
        public MaintainList(string group_name, int Level)
        {
            InitializeComponent();
            this.group_name = group_name;
            this.Level = Level;
            GroupLbl.Text = group_name;
        }
        private void MaintainList_Load(object sender, EventArgs e)
        {
            RefreshDataSource();
        }
        private void RefreshDataSource()
        {
            List<List<string>> words = Methods.GetAllWords(group_name);
            GroupBox.DataSource = null;
            words[Level - 1].Sort();
            GroupBox.DataSource = words[Level - 1];
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            string NewWord = Inputbox.Text;
            CsvWriter.AddWord(Level, group_name, NewWord);
            RefreshDataSource();
        }
        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (GroupBox.SelectedItem == null)
            {
                // Do Nothing
            }
            else
            {
                string NewWord = GroupBox.SelectedItem.ToString();
                DialogResult res = MessageBox.Show("Are you sure you want to delete " + NewWord, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    MessageBox.Show(NewWord + " deleted");
                    CsvWriter.DeleteWord(Level, group_name, NewWord);
                    RefreshDataSource();
                }
                if (res == DialogResult.Cancel)
                {
                    //Do Nothing
                }
            }
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        
    }
}
