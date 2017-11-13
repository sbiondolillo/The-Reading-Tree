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
            History.SetPrev(this);
            VowelSoundsMenu vsmenu = new VowelSoundsMenu();
            vsmenu.Show();
            Close();
        }

        private void btnPrefix_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            PrefixesMenu prefixmenu = new PrefixesMenu();
            prefixmenu.Show();
            Close();
        }

        private void btnSuffix_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            SuffixesMenu suffixmenu = new SuffixesMenu();
            suffixmenu.Show();
            Close();
        }

        private void btnRoots_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            RootMenu rootmenu = new RootMenu();
            rootmenu.Show();
            Close();
        }

        private void btnOOSounds_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            OOMenu oomenu = new OOMenu();
            oomenu.Show();
            Close();
        }

        private void btnMisc_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            MiscMenu miscmenu = new MiscMenu();
            miscmenu.Show();
            Close();
        }

        private void btnRs_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            RsMenu rsMenu = new RsMenu();
            rsMenu.Show();
            Close();
        }

        private void btnBlends_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            BlendsMenu blendsMenu = new BlendsMenu();
            blendsMenu.Show();
            Close();
        }

        private void btnCVC_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            CVCMenu cvcMenu = new CVCMenu();
            cvcMenu.Show();
            Close();
        }

        private void btnVCVariables_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            VCVariablesMenu vcvVariablesMenu = new VCVariablesMenu();
            vcvVariablesMenu.Show();
            Close();
        }

        private void btnDigraph_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            DigraphMenu digraphMenu = new DigraphMenu();
            digraphMenu.Show();
            Close();
        }

        private void btnConsonantManipulation_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            ConsonantManipulationMenu consonantManipulationMenu = new ConsonantManipulationMenu();
            consonantManipulationMenu.Show();
            Close();
        }

        private void btnPossessiveNoun_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            PossessiveNounMenu possessiveNounMenu = new PossessiveNounMenu();
            possessiveNounMenu.Show();
            Close();
        }

        private void btnContractions_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            ContractionsMenu contractionsMenu = new ContractionsMenu();
            contractionsMenu.Show();
            Close();
        }
    }
}
