using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestaoFinanceira.Validacao;
using MetroFramework.Forms;
using GestaoFinanceira.Modelo;
using GestaoFinanceira.Utilidade;
using MetroFramework;

namespace GestaoFinanceira.Visual
{
    public partial class frmPesquisaCliente : MetroForm
    {
        public frmPesquisaCliente()
        {
            InitializeComponent();
        }
        private Utilidade.Conexao.utilidade_Conexao conexao = new Utilidade.Conexao.utilidade_Conexao(Utilidade.DadosConexao.stringConexao);
        public int codigo;

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPesquisaCliente_Load(object sender, EventArgs e)
        {
            try
            {
                //GERAR ARQUIVO PDF, EXECEL, WORD
                cbGerar.Items.Insert(0, "Gerar PDF");
                cbGerar.Items.Insert(1, "Gerar EXCEL");
                cbGerar.Items.Insert(2, "Gerar WORD");

                //MUDA A COR DO DATAGRID VIEW
                GridClientes.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
                GridClientes.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
                GridClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                GridClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

               CarregarCliente(codigo);
                //FORMATAR DATAGRID VIEW
                btnPesquisar_Click(sender, e);
                GridClientes.Columns["id"].HeaderText = "CODIGO";
                GridClientes.Columns["id"].Width = 80;
                GridClientes.Columns["cpf"].HeaderText = "CPF";
                GridClientes.Columns["cpf"].Width = 100;
                GridClientes.Columns["nome"].HeaderText = "USUARIO";
                GridClientes.Columns["nome"].Width = 425;
                GridClientes.Columns["datacadastro"].HeaderText = "datacadastro";
                GridClientes.Columns["datacadastro"].Width = 425;
                GridClientes.Columns["endereco"].Visible = false; 
                GridClientes.Columns["numero"].Visible = false;
                GridClientes.Columns["complemento"].Visible = false;
                GridClientes.Columns["bairro"].Visible = false;
                GridClientes.Columns["cidade"].Visible = false;
                GridClientes.Columns["estado"].Visible = false;
                GridClientes.Columns["email"].Visible = false;
                GridClientes.Columns["fomecelular"].Visible = false;
                GridClientes.Columns["observacao"].Visible = false;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public void CarregarCliente(int codigo)
        {
            Validacao_Cliente cliente = new Validacao_Cliente(conexao);
            GridClientes.DataSource = cliente.CarregarCliente(codigo);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                Validacao_Cliente cliente = new Validacao_Cliente(conexao);
                GridClientes.DataSource = cliente.ListarPesquisar(txtPesquisa.Text);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao pesquisar" + ex.Message);
            }
        }

        private void GridClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(GridClientes.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(cbGerar.SelectedItem) == "")
            {
                MetroMessageBox.Show(this, "\n\n Por Favor selecione uma opção de documento",
                    "Gerar Documento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToString(cbGerar.SelectedItem) == "Gerar PDF")
            {
                MetroMessageBox.Show(this, "\n\n Documento Gerado com SUCESSO ",
                    "Gerar Documento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Convert.ToString(cbGerar.SelectedItem) == "Gerar EXCEL")
            {
                MetroMessageBox.Show(this, "\n\n Documento Gerado com SUCESSO ",
                    "Gerar Documento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Convert.ToString(cbGerar.SelectedItem) == "Gerar WORD")
            {
                MetroMessageBox.Show(this, "\n\n Documento Gerado com SUCESSO ",
                    "Gerar Documento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
