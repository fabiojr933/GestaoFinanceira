using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestaoFinanceira.Relatorio;
using MetroFramework.Forms;

namespace GestaoFinanceira.Visual
{
    public partial class frmImpressao : MetroForm
    {
        public frmImpressao()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            frmImpressaoUsuario usuario = new frmImpressaoUsuario();
            usuario.ShowDialog();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            frmImpressaoCliente22 cliente = new frmImpressaoCliente22();
            cliente.ShowDialog();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
