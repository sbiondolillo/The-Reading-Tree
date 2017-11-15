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
    public partial class ChooseFromLevelDialog : Form
    {
        private Stack<string> availableWords { get; set; }
        public List<string> returnedWords { get; set; }
        public ChooseFromLevelDialog(List<string> levelList)
        {
            InitializeComponent();
            availableWords = new Stack<string>(levelList);
        }
        private void btnChooseWordsCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ChooseFromLevel_Load(object sender, EventArgs e)
        {
            numericUpDownChosenQuantity.Minimum = 1;
            numericUpDownChosenQuantity.Maximum = availableWords.Count();
        }
        private void ShuffleAvailableWords()
        {
            /// adapted from https://stackoverflow.com/questions/33643104/shuffling-a-stackt
            Random rand = new Random();
            var values = availableWords.ToArray();
            availableWords.Clear();
            foreach (var value in values.OrderBy(x => rand.Next()))
            {
                availableWords.Push(value);
            }
        }
        private void btnChooseWordsConfirm_Click(object sender, EventArgs e)
        {
            decimal chosenQuantity = numericUpDownChosenQuantity.Value;
            ShuffleAvailableWords();
            returnedWords = new List<string>();
            for (int i = 0; i < chosenQuantity; i++)
            {
                returnedWords.Add(availableWords.Pop());
            }
            this.DialogResult = DialogResult.OK;
            Hide();
        }
    }
}
