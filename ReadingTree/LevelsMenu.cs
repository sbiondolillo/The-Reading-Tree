using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private List<List<string>> words { get; set; }
        private int SelectedLevel { get; set; }
        public LevelsMenu(string group_name)
        {
            InitializeComponent();
            this.group_name = group_name;
        }
        private void LevelsMenu_Load(object sender, EventArgs e)
        {
            GroupNameLabel.Text = group_name;
            RefreshLevelsListBoxes();
            SelectDefaultRadioButton();
            RefreshChosenWordsBox();
        }
        private void RefreshLevelsListBoxes()
        {
            words = Methods.GetAllWords(group_name);
            level1Box.DataSource = null;
            words[0].Sort();
            level1Box.DataSource = words[0];
            level2Box.DataSource = null;
            words[1].Sort();
            level2Box.DataSource = words[1];
            level3Box.DataSource = null;
            words[2].Sort();
            level3Box.DataSource = words[2];
            level4Box.DataSource = null;
            words[3].Sort();
            level4Box.DataSource = words[3];
            level5Box.DataSource = null;
            words[4].Sort();
            level5Box.DataSource = words[4];
        }
        private void SelectDefaultRadioButton()
        {
            if (level1Box.Items.Count > 0)
            {
                radioButtonLevel1.Select();
                SelectedLevel = 1;
            }
            else if (level2Box.Items.Count > 0)
            {
                radioButtonLevel2.Select();
                SelectedLevel = 2;
            }
            else if (level3Box.Items.Count > 0)
            {
                radioButtonLevel3.Select();
                SelectedLevel = 3;
            }
            else if (level4Box.Items.Count > 0)
            {
                radioButtonLevel4.Select();
                SelectedLevel = 4;
            }
            else
            {
                radioButtonLevel5.Select();
                SelectedLevel = 5;
            }
        }
        private void RefreshChosenWordsBox()
        {
            ChosenWordsBox.DataSource = null;
            ChosenWordsBox.DataSource = History.ChosenWordsList;
        }
        private void RadioButtons_CheckChanged(object sender, EventArgs e)
        {
            if (radioButtonLevel1.Checked)
            {
                SelectedLevel = 1;
            }
            else if (radioButtonLevel2.Checked)
            {
                SelectedLevel = 2;
            }
            else if (radioButtonLevel3.Checked)
            {
                SelectedLevel = 3;
            }
            else if (radioButtonLevel4.Checked)
            {
                SelectedLevel = 4;
            }
            else
            {
                SelectedLevel = 5;
            }
        }
        private void btnMaintainSelectedLevel_Click(object sender, EventArgs e)
        {
            using (MaintainList Change = new MaintainList(group_name, SelectedLevel))
            {
                Change.ShowDialog(this);
            }
            RefreshLevelsListBoxes();
        }
        private void btnExportChosen_Click(object sender, EventArgs e)
        {
            //Uses StreamWriter to write a text file to a specific location
            SaveFileDialog savefile = new SaveFileDialog();
            // set a default file name
            savefile.FileName = "readingtree.txt";
            // set filters - this can be done in properties as well
            savefile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(savefile.FileName))
                    foreach (var item in ChosenWordsBox.Items)
                    {
                        sw.WriteLine(item);
                    }
            }
        }
        private void btnClearChosen_Click(object sender, EventArgs e)
        {
            if (ChosenWordsBox.Items.Count != 0)
            {
                DialogResult res = MessageBox.Show("Are you sure you want to clear all chosen words?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    try
                    {
                        History.ClearChosenWords();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        MessageBox.Show("Unable to clear the list: " + ex.Message);
                    }
                    RefreshChosenWordsBox();
                }
            }
        }
        private void btnChooseWordsFromSelected_Click(object sender, EventArgs e)
        {
            List<string> selectedWords = words[SelectedLevel - 1];
            using (ChooseFromLevelDialog chooser = new ChooseFromLevelDialog(selectedWords))
            {
                chooser.ShowDialog(this);
                if (chooser.DialogResult == DialogResult.OK)
                {
                    History.AddToChosenWords(chooser.returnedWords);
                    RefreshChosenWordsBox();
                }
            }
        }
        private void btnRemovedFromChosen_Click(object sender, EventArgs e)
        {
            if (ChosenWordsBox.SelectedItem != null)
            {
                string selectedWord = ChosenWordsBox.SelectedItem.ToString();
                DialogResult res = MessageBox.Show("Are you sure you want to remove '" + selectedWord + "' ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    try
                    {
                        History.RemoveFromChosenWords(selectedWord);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        MessageBox.Show("Unable to remove " + selectedWord + ": " + ex.Message);
                    }
                    RefreshChosenWordsBox();
                }
            }
        }
        private void Double_Click(object sender, EventArgs e)
        {
            List<string> picked_word = new List<string>();
            picked_word.Clear();
            ListBox x = (ListBox)sender;
            if (x.SelectedItem != null)
            {
                picked_word.Add(x.SelectedItem.ToString());
                History.AddToChosenWords(picked_word);
                RefreshChosenWordsBox();
            }

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form previous = History.GetPrev();
            previous.Show();
            Close();
        }
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            History.Show_MainMenu();
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
