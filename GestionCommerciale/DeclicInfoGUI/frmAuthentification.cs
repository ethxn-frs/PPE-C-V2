using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeclicInfoBLL;
using DeclicInfoBO;


namespace DeclicInfoGUI
{
    public partial class frmAuthentification : Form
    {
        public frmAuthentification()
        {
            InitializeComponent();
            authentificationBLL.SetChaineConnexion(ConfigurationManager.ConnectionStrings["Client"]);
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
           
            Utilisateur unUtilisateur = new Utilisateur(txtNom.Text,txtMdp.Text);

            Utilisateur test = authentificationBLL.GetUtilisateur(unUtilisateur);
            if (test == null)
            {
                txtError.Visible = true;

            }
            else

            {
                this.Hide();
                
                frmMenu frmMenu = new frmMenu();
                frmMenu.ShowDialog();

                this.Close();
            }
        }

        private void txtError_Click(object sender, EventArgs e)
        {

        }
    }
}
