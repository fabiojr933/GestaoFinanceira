using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace GestaoFinanceira.Visual
{
    public partial class frmCadastro : MetroForm
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastroUsuario_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario cadastroUsuario = new frmCadastroUsuario();
            cadastroUsuario.ShowDialog();
            cadastroUsuario.Dispose();
        }

        private void btnFormaPag_Click(object sender, EventArgs e)
        {
            frmFormaPag formaPag = new frmFormaPag();
            formaPag.ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();
            cliente.ShowDialog();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
