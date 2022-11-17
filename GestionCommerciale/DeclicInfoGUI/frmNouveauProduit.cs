using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using DeclicInfoBO; // Référence la couche BO
using DeclicInfoBLL; // Référence la couche BLL

namespace DeclicInfoGUI
{
    public partial class frmNouveauProduit : Form
    {

        public frmNouveauProduit()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e) => this.Close();

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            ProduitBLL.AddProduit(txtCode.Text, txtLibellé.Text, cmbCategorie.Text, txtPdv.Text);
        }
    }
}