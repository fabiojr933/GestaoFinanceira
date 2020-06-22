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
using GestaoFinanceira.Modelo;
using GestaoFinanceira.Negocio;
using GestaoFinanceira.Validacao;
using MetroFramework;

namespace GestaoFinanceira.Visual
{
    public partial class frmCadastroUsuario : MetroForm
    {
        public frmCadastroUsuario()
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
            if(op == 1)
            {
                btnNovo.Enabled = true;
                btnPesquisar.Enabled = true;
                btnVoltar.Enabled = true;
            }
            if(op == 2)
            {
                btnGravar.Enabled = true;
                btnCancelar.Enabled = true;
            }
            if(op == 3)
            {
                btnEditar.Enabled = true;
                btnCancelar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }
        public void HabilitaCampos()
        {
            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;
        }
        public void DesabilitaCampos()
        {
            txtUsuario.Enabled = false;
            txtSenha.Enabled = false;
        }
        public void LimpaCampo()
        {
            txtId.Text = "";
            txtSenha.Text = "";
            txtUsuario.Text = "";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastroUsuario_Load(object sender, EventArgs e)
        {
            this.AlterarBotao(1);
            this.DesabilitaCampos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.operacao = "Cadastrar";
            this.AlterarBotao(2);
            this.HabilitaCampos();
            txtUsuario.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.operacao = "Alterar";
            this.HabilitaCampos();
            this.AlterarBotao(2);
            txtUsuario.Focus();
        }
        //METEDO VERIFICA USUARIO EXISTENTE
        public void VerificaUsuario(string usuario)
        {            
            int r = 0;
            Validacao_Usuario validacaoUser = new Validacao_Usuario(conexao);
            r = validacaoUser.VerificaUsuario(txtUsuario.Text);
            if(r > 0)
            {
                MetroMessageBox.Show(this,"\n\n\n NOME do Usuario ja Existe no banco de dados ","ATENÇÃO",
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);
                LimpaCampo();
                txtUsuario.Focus();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //METEDO PARA EXCLUIR USUARIO
            try
            {
                DialogResult resultado = MetroMessageBox.Show(this, "\n\n Tem Certeza que deseja EXCLUIR esse Usuario ? ","Confirmar a EXCLUSÃO",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resultado.ToString() == "Yes")
                {
                    conexao.AbrirConexao();
                    Modelo_Usuario Usuario = new Modelo_Usuario();
                    Validacao_Usuario validacao = new Validacao_Usuario(conexao);
                    validacao.ExcluirUsuario(Convert.ToInt32(txtId.Text));

                    MetroMessageBox.Show(this, "\n\n Usuario Excluido com Suscesso", "Operação Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.LimpaCampo();
                    this.DesabilitaCampos();
                    this.AlterarBotao(1);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message + " \n\n Ops Ocorreu Algum erro \n Não foi possivel concluir o processo \n " +
                   "Ligue para o Administrador do Sistema (66) 999539490 \n",
                   "Oparação NÃO Realizada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.AlterarBotao(3);
                this.txtUsuario.Focus();
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.AbrirConexao();
                Modelo_Usuario usuario = new Modelo_Usuario();
                usuario.usuario = txtUsuario.Text;
                usuario.senha = txtSenha.Text;
                Validacao_Usuario validacao_Usuario = new Validacao_Usuario(conexao);

                //METEDO GRAVAR NO BANCO DE DADOS
                if(operacao == "Cadastrar")
                {
                    validacao_Usuario.SalvarUsuario(usuario);
                    MetroMessageBox.Show(this,"\n\n Usuario Cadastrado com Suscesso","Operação Realizada", MessageBoxButtons.OK,MessageBoxIcon.Information);

                    this.LimpaCampo();
                    this.DesabilitaCampos();
                }

                //METEDO EDITAR USUARIO
                if (operacao == "Alterar")
                {
                    usuario.id = Convert.ToInt32(txtId.Text);
                    validacao_Usuario.EditarUsuario(usuario);
                    MetroMessageBox.Show(this, "\n\n Usuario Alterado com Suscesso", "Operação Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.LimpaCampo();
                    this.DesabilitaCampos();
                }
                this.LimpaCampo();
                this.AlterarBotao(1);
                this.DesabilitaCampos();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message + " \n\n Ops Ocorreu Algum erro \n Não foi possivel concluir o processo \n " +
                    "Ligue para o Administrador do Sistema (66) 999539490 \n",
                    "Operação NÃO Realizada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisaUsuario pesquisaUsuario = new frmPesquisaUsuario();
            pesquisaUsuario.ShowDialog();
            if(pesquisaUsuario.codigo != 0)            {
                
                Validacao_Usuario validacao = new Validacao_Usuario(conexao);
                Modelo_Usuario usuario = validacao.CarregarUsuario(pesquisaUsuario.codigo);
                txtId.Text = Convert.ToString(usuario.id);
                txtUsuario.Text = usuario.usuario;
                txtSenha.Text = usuario.senha;
                this.AlterarBotao(3);
                
            }
            else
            {
                LimpaCampo();
                txtUsuario.Focus();
                AlterarBotao(1);
            }
            pesquisaUsuario.Dispose();
        }
        //METEDO PARA PULAR OUTRO TEXTBOX
        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if(operacao == "Cadastrar") 
            { 
            this.VerificaUsuario(usuario);
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGravar_Click(sender, e);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.AlterarBotao(1);
            this.LimpaCampo();
            this.DesabilitaCampos();
            txtUsuario.Focus();
        }


    }
}
