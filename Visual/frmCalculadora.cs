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
    public partial class frmCalculadora : MetroForm
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.txtDiasAtraso.Clear();
            this.txtTaxaJuro.Clear();
            this.txtValorPagar.Clear();
            this.txtValorParcela.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Double M;
            Double P = Convert.ToDouble(txtValorParcela.Text);
            Double I = Convert.ToDouble(txtTaxaJuro.Text) / 100;
            Double N = Convert.ToDouble(txtDiasAtraso.Text);

            M = P * (1 + (I * (N / 30)));
            txtValorPagar.Text = M.ToString("C");
        }

        private void txtValorParcela_Leave(object sender, EventArgs e)
        {
            if (txtValorParcela.Text.Contains(".") == false)
            {
                txtValorParcela.Text += " ,00";
            }
            else
            {
                if (txtValorParcela.Text.IndexOf(",") == txtValorParcela.Text.Length - 1)
                {
                    txtValorParcela.Text += "00";
                }
            }
        }

        private void txtValorParcela_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtValorParcela.Text.Contains("."))
                {
                    e.KeyChar = ',';
                }
                else
                {
                    e.Handled = true;
                }
            }
        }


        private void txtValorPagar_Leave(object sender, EventArgs e)
        {
            if (txtValorParcela.Text.Contains(",") == false)
            {
                txtValorParcela.Text += " ,00";
            }
            else
            {
                if (txtValorParcela.Text.IndexOf(",") == txtValorParcela.Text.Length - 1)
                {
                    txtValorParcela.Text += "00";
                }
            }
        }

        private void txtValorPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtValorParcela.Text.Contains("."))
                {
                    e.KeyChar = ',';
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txtValorParcela_Leave_1(object sender, EventArgs e)
        {
            if(txtValorParcela.Text.Contains(",") ==  false)
            {
                txtValorParcela.Text += ",00";
            }
            else
            {
                if(txtValorParcela.Text.IndexOf(",")== txtValorParcela.Text.Length - 1)
                {
                    txtValorParcela.Text += "00";
                }
            }
        }
    }
}
