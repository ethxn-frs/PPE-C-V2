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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            frmClients Frmclients = new frmClients();
            Frmclients.ShowDialog();
        }

        private void btnProduits_Click(object sender, EventArgs e)
        {
            frmProduits Frmproduits = new frmProduits();
            Frmproduits.ShowDialog();
        }

        private void btnDevis_Click(object sender, EventArgs e)
        {
            frmDevis Frmdevis = new frmDevis();
            Frmdevis.ShowDialog();
        }

        private void btnSynthèse_Click(object sender, EventArgs e)
        {
            frmSynthèseClients Frmsynthèseclients = new frmSynthèseClients();
            Frmsynthèseclients.ShowDialog();
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAuthentification Frmauthentification = new frmAuthentification();
            Frmauthentification.ShowDialog();
            this.Close();
        }
    }
}
