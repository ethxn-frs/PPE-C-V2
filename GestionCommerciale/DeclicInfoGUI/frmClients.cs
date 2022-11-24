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
using DeclicInfoBLL;
using DeclicInfoBO;

namespace DeclicInfoGUI
{
    public partial class frmClients : Form
    {
        public frmClients()
        {
            InitializeComponent();
            ProduitBLL.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Client"]);
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmClients_Load(object sender, EventArgs e)
        {
            List<Client> listClients = new List<Client>();
            listClients = ClientBLL.getClients();
            dgvClients.DataSource = listClients;
            dgvClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvClients.Rows[e.RowIndex];
                // Code Produit 
                txtCode.Text = (string)dgvClients.CurrentRow.Cells[0].Value;
                // Libelle
                txtNom.Text = (string)dgvClients.CurrentRow.Cells[1].Value;
                // Email
                txtEmail.Text = (string)dgvClients.CurrentRow.Cells[12].Value;
                // Telephone
                txtTelephone.Text = dgvClients.CurrentRow.Cells[10].Value.ToString();
                // Fax
                txtFax.Text = dgvClients.CurrentRow.Cells[11].Value.ToString();
                // Adresse Fact Num
                txtFactNum.Text = dgvClients.CurrentRow.Cells[6].Value.ToString();
                // Adresse Fact Rue
                txtFactRue.Text = dgvClients.CurrentRow.Cells[7].Value.ToString();
                // Adresse Fact Ville 
                txtFactVille.Text = dgvClients.CurrentRow.Cells[8].Value.ToString();
                // Adresse facturation code postale 
                txtFactCodePostal.Text = dgvClients.CurrentRow.Cells[9].Value.ToString();
                // Adresse Fact Num
                txtLivrNum.Text = dgvClients.CurrentRow.Cells[2].Value.ToString();
                // Adresse Fact Rue
                txtLivrRue.Text = dgvClients.CurrentRow.Cells[3].Value.ToString();
                // Adresse Fact Ville 
                txtLivrVille.Text = dgvClients.CurrentRow.Cells[4].Value.ToString();
                // Adresse facturation code postale 
                txtLivrCodePostal.Text = dgvClients.CurrentRow.Cells[5].Value.ToString();



            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            frmConfirmationSuppressionClient frmSuppression = new frmConfirmationSuppressionClient(txtCode.Text);
            Close();
            frmSuppression.Hide();
            frmSuppression.ShowDialog();

        }
    }
}
