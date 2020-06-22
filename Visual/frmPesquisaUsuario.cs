using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestaoFinanceira.Utilidade;
using MetroFramework.Forms;
using GestaoFinanceira.Negocio;
using GestaoFinanceira.Validacao;
using MetroFramework;

namespace GestaoFinanceira.Visual
{
    public partial class frmPesquisaUsuario : MetroForm
    {
        public frmPesquisaUsuario()
        {
            InitializeComponent();
        }

        public int codigo = 0;
        Conexao.utilidade_Conexao conexao = new Conexao.utilidade_Conexao(DadosConexao.stringConexao);

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //METEDO PESQUISAR
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                Validacao_Usuario validacao = new Validacao_Usuario(conexao);
                GridUsuario.DataSource = validacao.ListarUsuario(txtPesquisa.Text);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //CARREGAR GRID
        private void frmPesquisaUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                //GERAR ARQUIVO PDF, EXECEL, WORD
                cbGerar.Items.Insert(0, "Gerar PDF");
                cbGerar.Items.Insert(1, "Gerar EXCEL");
                cbGerar.Items.Insert(2, "Gerar WORD");

                //MUDA A COR DO DATAGRID VIEW
                GridUsuario.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
                GridUsuario.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
                GridUsuario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                GridUsuario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

                //FORMATAR DATAGRID VIEW
                btnPesquisar_Click(sender, e);
                GridUsuario.Columns["id"].HeaderText = "CODIGO";
                GridUsuario.Columns["id"].Width = 80;
                GridUsuario.Columns["usuario"].HeaderText = "USUARIO";
                GridUsuario.Columns["usuario"].Width = 525;
                GridUsuario.Columns["senha"].Visible = false;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        //METEDO DUPLO CLIQUE GRID USUARIO
        private void GridUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0)
            {
                this.codigo = Convert.ToInt32(GridUsuario.Rows[e.RowIndex].Cells[0].Value);
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
