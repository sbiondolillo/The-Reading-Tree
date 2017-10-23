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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnVowelSounds_Click(object sender, EventArgs e)
        {
            VowelSoundsMenu vsmenu = new VowelSoundsMenu();
            vsmenu.Show();
            this.Hide();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnPrefix_Click(object sender, EventArgs e)
        {
            PrefixesMenu prefixmenu = new PrefixesMenu();
            prefixmenu.Show();
            this.Hide();
        }

        private void btnSuffix_Click(object sender, EventArgs e)
        {
            SuffixesMenu suffixmenu = new SuffixesMenu();
            suffixmenu.Show();
            this.Hide();
        }

        private void btnRoots_Click(object sender, EventArgs e)
        {
            RootMenu rootmenu = new RootMenu();
            rootmenu.Show();
            this.Hide();
        }

        private void btnOOSounds_Click(object sender, EventArgs e)
        {
            OOMenu oomenu = new OOMenu();
            oomenu.Show();
            this.Hide();
        }

        private void btnMisc_Click(object sender, EventArgs e)
        {
            MiscMenu miscmenu = new MiscMenu();
            miscmenu.Show();
            this.Hide();
        }
    }
}
