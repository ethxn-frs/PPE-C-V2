using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            Utilisateur test = authentificationBLL.GetUtilisateur(txtNom.Text);
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
    }
}
