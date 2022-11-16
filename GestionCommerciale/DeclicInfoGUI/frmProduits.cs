using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeclicInfoGUI
{
    public partial class frmProduits : Form
    {
        public frmProduits()
        {
            InitializeComponent();
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            frmNouveauProduit Frmnouveauproduit = new frmNouveauProduit();
            Frmnouveauproduit.ShowDialog();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            
        }
    }
}
