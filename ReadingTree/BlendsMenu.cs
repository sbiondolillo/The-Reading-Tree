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
    public partial class BlendsMenu : Form
    {
        public BlendsMenu()
        {
            InitializeComponent();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            Close();
        }

        private void btnBlendsInitial_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            BlendsInitialMenu blendsInitialMenu = new BlendsInitialMenu();
            blendsInitialMenu.Show();
            Hide();
        }

        private void btnBlendsFinalDigraph_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            BlendsFinalDigraphMenu blendsFinalDigraphMenu = new BlendsFinalDigraphMenu();
            blendsFinalDigraphMenu.Show();
            Hide();
        }

        private void btnLetterBlends_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            BlendsLetterBlendsMenu blendsLetterBlendsMenu = new BlendsLetterBlendsMenu();
            blendsLetterBlendsMenu.Show();
            Hide();
        }

        private void btnSpellingRules_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            BlendsSpellingRulesMenu blendsSpellingRulesMenu = new BlendsSpellingRulesMenu();
            blendsSpellingRulesMenu.Show();
            Hide();
        }

        private void btnPhonics_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            BlendsPhonicsMenu blendsPhonicsMenu = new BlendsPhonicsMenu();
            blendsPhonicsMenu.Show();
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
