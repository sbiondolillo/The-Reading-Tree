﻿using System;
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
    public partial class BlendsPhonicsMenu : Form
    {
        public BlendsPhonicsMenu()
        {
            InitializeComponent();
        }

        private void btnILD_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Close();
        }

        private void btnINDMixed_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Close();
        }

        private void btnIND_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Close();
        }

        private void btnKN_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Close();
        }

        private void btnNGNK_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Close();
        }

        private void btnOLD_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Close();
        }

        private void btnOLL_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Close();
        }

        private void btnOLT_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Close();
        }

        private void btnOST_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Close();
        }

        private void btnConsonantLESyllable_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            LevelsMenu level = new LevelsMenu(clickedButton.Text.ToString());
            level.Show();
            Close();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            Close();
        }
    }
}
