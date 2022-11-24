using DeclicInfoBLL;
using DeclicInfoBO;
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
    public partial class frmNouveauClient : Form
    {
        public frmNouveauClient()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {   

            int.TryParse(txtLivrCodePostal.Text, out int txtLivrCodePostalconverted);
            int.TryParse(txtFactCodePostal.Text, out int txtFactCodePostalconverted);
            int.TryParse(txtTelephone.Text, out int txtTelephoneconverted);
            int.TryParse(txtFax.Text, out int txtFaxconverted);
            int.TryParse(txtLivrNum.Text, out int txtLivrNumconverted);
            int.TryParse(txtFactNum.Text, out int txtFactNumconverted);

            Client newClient = new Client(txtNom.Text, txtLivrNumconverted, txtLivrRue.Text,txtLivrVille.Text, txtLivrCodePostalconverted, txtFactNumconverted, txtFactRue.Text, txtFactVille.Text, txtFactCodePostalconverted, txtTelephoneconverted, txtFaxconverted, txtEmail.Text);
            ClientBLL.AddClient(newClient);
        }
    }
}
