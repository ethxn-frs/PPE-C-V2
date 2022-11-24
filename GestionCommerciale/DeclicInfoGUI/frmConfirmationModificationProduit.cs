using DeclicInfoBLL;
using DeclicInfoBO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeclicInfoGUI
{
    public partial class frmConfirmationModificationProduit : Form
    {
        Produit unProduit;

        public frmConfirmationModificationProduit(Produit unproduit)
        {
            InitializeComponent();
            unProduit = unproduit;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOui_Click(object sender, EventArgs e)
        {
            ProduitBLL.EditProduit(unProduit);
            Hide();
            frmProduits frmProduits = new frmProduits();
            frmProduits.ShowDialog();
        }
    }
}
