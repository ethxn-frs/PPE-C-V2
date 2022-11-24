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
    public partial class frmConfirmationSuppressionClient : Form
    {
        string code { get; set; }   

        public frmConfirmationSuppressionClient(string code)
        {
            InitializeComponent();
            this.code = code;
        }

        private void btnOui_Click(object sender, EventArgs e)
        {
            ClientBLL.deleteClient(code);
            Hide();
            frmClients frmClients = new frmClients();
            frmClients.ShowDialog();

        }
    }
}
