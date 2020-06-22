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
    public partial class frmRelatorio : MetroForm
    {
        public frmRelatorio()
        {
            InitializeComponent();
        }

        private void btnRelatorioUsuario_Click(object sender, EventArgs e)
        {
            frmPesquisaUsuario pesquisaUsuario = new frmPesquisaUsuario();
            pesquisaUsuario.ShowDialog();
            pesquisaUsuario.Dispose();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            frmRelatorioFormaPag formaPag = new frmRelatorioFormaPag();
            formaPag.ShowDialog();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            frmPesquisaCliente cliente = new frmPesquisaCliente();
            cliente.ShowDialog();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
