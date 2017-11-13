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
            History.ClearHistory();
        }

        private void btnVowelSounds_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            VowelSoundsMenu vsmenu = new VowelSoundsMenu();
            vsmenu.Show();
            Hide();
        }

        private void btnPrefix_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            PrefixesMenu prefixmenu = new PrefixesMenu();
            prefixmenu.Show();
            Hide();
        }

        private void btnSuffix_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            SuffixesMenu suffixmenu = new SuffixesMenu();
            suffixmenu.Show();
            Hide();
        }

        private void btnRoots_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            RootMenu rootmenu = new RootMenu();
            rootmenu.Show();
            Hide();
        }

        private void btnOOSounds_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            OOMenu oomenu = new OOMenu();
            oomenu.Show();
            Hide();
        }

        private void btnMisc_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            MiscMenu miscmenu = new MiscMenu();
            miscmenu.Show();
            Hide();
        }

        private void btnRs_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            RsMenu rsMenu = new RsMenu();
            rsMenu.Show();
            Hide();
        }

        private void btnBlends_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            BlendsMenu blendsMenu = new BlendsMenu();
            blendsMenu.Show();
            Hide();
        }

        private void btnCVC_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            CVCMenu cvcMenu = new CVCMenu();
            cvcMenu.Show();
            Hide();
        }

        private void btnVCVariables_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            VCVariablesMenu vcvVariablesMenu = new VCVariablesMenu();
            vcvVariablesMenu.Show();
            Hide();
        }

        private void btnDigraph_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            DigraphMenu digraphMenu = new DigraphMenu();
            digraphMenu.Show();
            Hide();
        }

        private void btnConsonantManipulation_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            ConsonantManipulationMenu consonantManipulationMenu = new ConsonantManipulationMenu();
            consonantManipulationMenu.Show();
            Hide();
        }

        private void btnPossessiveNoun_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            PossessiveNounMenu possessiveNounMenu = new PossessiveNounMenu();
            possessiveNounMenu.Show();
            Hide();
        }

        private void btnContractions_Click(object sender, EventArgs e)
        {
            History.SetPrev(this);
            ContractionsMenu contractionsMenu = new ContractionsMenu();
            contractionsMenu.Show();
            Hide();
        }
     
    }
}
