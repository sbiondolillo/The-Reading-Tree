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
    public partial class DigraphMenu : Form
    {
        public DigraphMenu()
        {
            InitializeComponent();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            History.ClearHistory();
            MainMenu main = new MainMenu();
            main.Show();
            Close();
        }

        private void btnDigraph_ch_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Hide();
        }

        private void btnDigraph_ck_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Hide();
        }

        private void btnDigraph_sh_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Hide();
        }

        private void btnDigraph_th_unvoiced_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Hide();
        }

        private void btnDigraph_th_voiced_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Hide();
        }

        private void btnDigraph_wh_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Hide();
        }

        private void btnTch_Click(object sender, EventArgs e)
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
    }
}
