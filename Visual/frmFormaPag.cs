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
using GestaoFinanceira.Modelo;
using GestaoFinanceira.Validacao;
using GestaoFinanceira.Utilidade;
using MetroFramework;

namespace GestaoFinanceira.Visual
{
    public partial class frmFormaPag : MetroForm
    {
        public frmFormaPag()
        {
            InitializeComponent();
        }

        private Conexao.utilidade_Conexao conexao = new Conexao.utilidade_Conexao(Utilidade.DadosConexao.stringConexao);
        private string usuario, operacao;

        public void AlterarBotao(int op)
        {
            btnVoltar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnGravar.Enabled = false;
            btnCancelar.Enabled = false;
            btnPesquisar.Enabled = false;
            btnNovo.Enabled = false;
            if (op == 1)
            {
                btnNovo.Enabled = true;
                btnPesquisar.Enabled = true;
                btnVoltar.Enabled = true;
            }
            if (op == 2)
            {
                btnGravar.Enabled = true;
                btnCancelar.Enabled = true;
            }
            if (op == 3)
            {
                btnEditar.Enabled = true;
                btnCancelar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }
        public void HabilitaCampos()
        {
            txtFormaPag.Enabled = true;
        }
        public void DesabilitaCampos()
        {
            txtFormaPag.Enabled = false;
        }

        private void frmFormaPag_Load(object sender, EventArgs e)
        {
            this.DesabilitaCampos();
            this.AlterarBotao(1);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.operacao = "Cadastrar";
            this.HabilitaCampos();
            this.AlterarBotao(2);
            txtFormaPag.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaCampo();
            this.DesabilitaCampos();
            this.AlterarBotao(1);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.operacao = "Alterar";
            this.AlterarBotao(2);
            this.HabilitaCampos();
            txtFormaPag.Focus();
        }

        //METEDO EXCLUIR
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.AbrirConexao();
                DialogResult resultado = MetroMessageBox.Show(this, "\n\n Deseja realmente excluir? ", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado.ToString() == "Yes")
                {
                    Validacao_FormaPagamento formaPagamento = new Validacao_FormaPagamento(conexao);
                    formaPagamento.ExcluirFormaPag(Convert.ToInt32(txtId.Text));
                    MetroMessageBox.Show(this,"\n\n Excluido com Sucesso ", "Excluido",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.AlterarBotao(1);
                    this.DesabilitaCampos();
                    this.LimpaCampo();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message + "\n\n Ops Aconteceu Algum Erro \n\n Chame o Administrador do Sistema? ", "ATENÇÃO ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.AlterarBotao(3);
                txtFormaPag.Focus();
            }         

        }
        //METEDO GRAVAR
        private void btnGravar_Click(object sender, EventArgs e)
        {
            
            try
            {
                conexao.AbrirConexao();
                Validacao_FormaPagamento formaPagamento = new Validacao_FormaPagamento(conexao);
                Modelo_formaPagamento modelo = new Modelo_formaPagamento();
                if (operacao == "Cadastrar")
                {
                    modelo.descricao = txtFormaPag.Text;
                    formaPagamento.SalvarFormaPag(modelo);
                    MetroMessageBox.Show(this, "\n\n Salvo com Sucesso ", "Cadastrado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.AlterarBotao(1);
                    this.LimpaCampo();
                    this.DesabilitaCampos();
                }
                else
                {                    
                    modelo.descricao = txtFormaPag.Text;
                    modelo.id = Convert.ToInt32(txtId.Text);
                    formaPagamento.EditarFormaPag(modelo);
                    MetroMessageBox.Show(this, "\n\n Alterado com Sucesso ", "Editado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.AlterarBotao(1);
                    this.LimpaCampo();
                    this.DesabilitaCampos();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message + "\n\n Ops Aconteceu Algum Erro \n\n Chame o Administrador do Sistema? ", "ATENÇÃO ERRO",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.AlterarBotao(3);
                txtFormaPag.Focus();
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmRelatorioFormaPag formaPag = new frmRelatorioFormaPag();
            formaPag.ShowDialog();
            if(formaPag.codigo != 0)
            {
                Validacao_FormaPagamento validacao = new Validacao_FormaPagamento(conexao);
                Modelo_formaPagamento modelo = validacao.carregaFormaPag(formaPag.codigo);
                txtId.Text = Convert.ToString(modelo.id);
                txtFormaPag.Text = modelo.descricao;
                AlterarBotao(3);
            }
            else
            {
                this.LimpaCampo();
                this.txtFormaPag.Focus();
                AlterarBotao(1);
            }
            formaPag.Dispose();
        }

        public void LimpaCampo()
        {
            txtId.Text = "";
            txtFormaPag.Text = "";
        }

    }
}
