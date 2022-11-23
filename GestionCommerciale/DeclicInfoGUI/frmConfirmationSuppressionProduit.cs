using DeclicInfoBLL;
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
    public partial class frmConfirmationSuppressionProduit : Form
    {
        string code { get; set; }

        public frmConfirmationSuppressionProduit( string Code)
        {
            InitializeComponent();
            code = Code;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOui_Click(object sender, EventArgs e)
        {
            ProduitBLL.DeleteProduit(code);
            Hide();
            frmProduits frmproduits = new frmProduits();
            frmproduits.ShowDialog();
        }
    }
}
