using DeclicInfoBO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using DeclicInfoBLL;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace DeclicInfoGUI
{
    public partial class frmProduits : Form
    {
        public frmProduits()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            ProduitBLL.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Client"]);
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

        private void frmProduits_Load(object sender, EventArgs e)
        {
            List<Produit> produitList = new List<Produit>();
            produitList = ProduitBLL.GetProduits();
            //dgvProduits.DataSource = produitList;
            foreach (Produit produit in produitList)
            {
                dgvProduits.Rows.Add(produit.Code, produit.Libellé, produit.categorie.Libelle, produit.Prixht);
            }
            dgvProduits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            List<Categorie> categorieList = new List<Categorie>();
            cmbCategorie.DisplayMember = "Libelle";
            categorieList = CategorieBLL.getCategories();
            cmbCategorie.DataSource = categorieList;



            //List = BLL.GetProduit
            //    dgv/datesour = List
        }

        public void dgvProduits_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvProduits.Rows[e.RowIndex];
                // Code Produit 
                txtCode.Text = (string)dgvProduits.CurrentRow.Cells[0].Value;
                //Libelle
                txtLibellé.Text = (string)dgvProduits.CurrentRow.Cells[1].Value;
                //Catégorie
                cmbCategorie.Text = (string)dgvProduits.CurrentRow.Cells[2].Value;
                //Pdv   
                txtPdv.Text = dgvProduits.CurrentRow.Cells[3].Value.ToString();

            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            frmConfirmationSuppressionProduit frmsuppression = new frmConfirmationSuppressionProduit(txtCode.Text);
            Close();
            frmsuppression.Hide();
            frmsuppression.ShowDialog();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            //var categorie = (Categorie)cmbCategorie.SelectedItem;
            Categorie categorie = (Categorie)cmbCategorie.SelectedItem;
            //Categorie uneCategorie = new Categorie(categorie.Id, categorie.Libelle);
            int Prix = int.Parse(txtPdv.Text);
            Produit unProduit = new Produit(txtCode.Text, txtLibellé.Text, categorie, Prix);
            frmConfirmationModificationProduit frmmodifproduit = new frmConfirmationModificationProduit(unProduit);
            Close();
            frmmodifproduit.Hide();
            frmmodifproduit.ShowDialog();
        }
    }
}
