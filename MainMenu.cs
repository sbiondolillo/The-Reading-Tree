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

        private void btnBlends_Click(object sender, EventArgs e)
        {

        }

        private void btnRs_Click(object sender, EventArgs e)
        {

        }

        private void btnCVC_Click(object sender, EventArgs e)
        {

        }

        private void btnPrefix_Click(object sender, EventArgs e)
        {

        }

        private void btnSuffix_Click(object sender, EventArgs e)
        {

        }

        private void btnRoots_Click(object sender, EventArgs e)
        {

        }

        private void btnVCVariables_Click(object sender, EventArgs e)
        {
            VCVariablesMenu vsmenu = new VCVariablesMenu();
            vsmenu.Show();
            this.Hide();
        }

        private void btnDigraph_Click(object sender, EventArgs e)
        {
            Digraph vsmenu = new Digraph();
            vsmenu.Show();
            this.Hide();
        }

        private void btnConsonantManipulation_Click(object sender, EventArgs e)
        {
            ConsonantManipulationMenu vsmenu = new ConsonantManipulationMenu();
            vsmenu.Show();
            this.Hide();
        }

        private void btnPossessiveNoun_Click(object sender, EventArgs e)
        {
            PossessiveNounMenu vsmenu = new PossessiveNounMenu();
            vsmenu.Show();
            this.Hide();
        }

        private void btnContractions_Click(object sender, EventArgs e)
        {
            ContractionsMenu vsmenu = new ContractionsMenu();
            vsmenu.Show();
            this.Hide();
        }
    }
}
