using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestaoFinanceira.Visual;
using MetroFramework;
using MetroFramework.Forms;

namespace GestaoFinanceira
{
    public partial class frmPrincipal : MetroForm
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

       

        public void CarregarUsuario()
        {
            txtUsuario.Text = frmLogin.UsuarioLogado;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            frmCadastro cadastro = new frmCadastro();
            cadastro.ShowDialog();            
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            frmRelatorio relatorio = new frmRelatorio();
            relatorio.ShowDialog();
            relatorio.Dispose();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            frmRelatorio relatorio = new frmRelatorio();
            relatorio.ShowDialog();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            frmCalculadora calculadora = new frmCalculadora();
            calculadora.ShowDialog();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MetroMessageBox.Show(this, "\n\n\n Tem certeza que deseja sair do sitema ", "SAIR", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(resultado.ToString() == "Yes")
            {
                Application.Exit();
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            Process.Start("Excel");
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            Process.Start("winword");
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            Process.Start("Calc");
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CarregarUsuario();            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtHora.Text = DateTime.Now.ToString();
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            frmImpressao relatorio = new frmImpressao();
            relatorio.ShowDialog();
        }
    }
}
