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
using GestaoFinanceira.Validacao;
using MetroFramework;
using GestaoFinanceira.Utilidade;

namespace GestaoFinanceira.Visual
{
    public partial class frmRelatorioFormaPag : MetroForm
    {
        public frmRelatorioFormaPag()
        {
            InitializeComponent();
        }
        Utilidade.Conexao.utilidade_Conexao conexao = new Utilidade.Conexao.utilidade_Conexao(DadosConexao.stringConexao);
        public int codigo;

        private void frmRelatorioFormaPag_Load(object sender, EventArgs e)
        {
            try
            {
                //GERAR ARQUIVO PDF, EXECEL, WORD
                cbGerar.Items.Insert(0, "Gerar PDF");
                cbGerar.Items.Insert(1, "Gerar EXCEL");
                cbGerar.Items.Insert(2, "Gerar WORD");

                //MUDA A COR DO DATAGRID VIEW
                GridPagamento.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
                GridPagamento.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
                GridPagamento.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                GridPagamento.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

                //FORMATAR DATAGRID VIEW
                btnPesquisar_Click(sender, e);
                GridPagamento.Columns["id"].HeaderText = "CODIGO";
                GridPagamento.Columns["id"].Width = 80;
                GridPagamento.Columns["descricao"].HeaderText = "DESCRICÃO";
                GridPagamento.Columns["descricao"].Width = 525;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                Validacao_FormaPagamento _FormaPagamento = new Validacao_FormaPagamento(conexao);
                GridPagamento.DataSource = _FormaPagamento.ListarFormaPag(txtPesquisa.Text);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void GridPagamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(GridPagamento.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
