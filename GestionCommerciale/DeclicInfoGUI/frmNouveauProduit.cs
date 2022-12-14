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
            var categorie = (Categorie)cmbCategorie.SelectedItem;
            int Prix = int.Parse(txtPdv.Text);
            ProduitBLL.AddProduit( txtLibellé.Text, categorie.Id, Prix);
        }

        private void frmNouveauProduit_Load(object sender, EventArgs e)
        {
            List<Categorie> categorieList = new List<Categorie>();
            cmbCategorie.DisplayMember = "Libelle";
            categorieList = CategorieBLL.getCategories();
            cmbCategorie.DataSource = categorieList;
        }
    }
}