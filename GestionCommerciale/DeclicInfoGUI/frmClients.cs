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
    public partial class frmClients : Form
    {
        public frmClients()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            ProduitBLL.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Client"]);
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmClients_Load_1(object sender, EventArgs e)
        {
            List<Client> listClients = new List<Client>();
            listClients = ClientBLL.getClients();
            dgvClients.DataSource = listClients;
            dgvClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
