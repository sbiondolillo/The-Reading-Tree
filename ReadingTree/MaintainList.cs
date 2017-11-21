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
            if (!Inputbox.Text.Equals(""))
            {
                string NewWord = Inputbox.Text;
                DialogResult res = MessageBox.Show("Are you sure you want to add '" + NewWord + "' ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    try
                    {
                        CsvWriter.AddWord(Level, group_name, NewWord);
                        MessageBox.Show(NewWord + " added");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        MessageBox.Show("Unable to add " + NewWord + ": " + ex.Message);
                    }
                    RefreshDataSource();
                }
            }
        }
        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (GroupBox.SelectedItem != null)
            {
                string NewWord = GroupBox.SelectedItem.ToString();
                DialogResult res = MessageBox.Show("Are you sure you want to delete '" + NewWord + "' ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    try
                    {
                        CsvWriter.DeleteWord(Level, group_name, NewWord);
                        MessageBox.Show(NewWord + " deleted");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        MessageBox.Show("Unable to delete " + NewWord + ": " + ex.Message);
                    }
                    RefreshDataSource();
                }
            }
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        
    }
}
