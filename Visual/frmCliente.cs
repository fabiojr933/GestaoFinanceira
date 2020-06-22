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
using GestaoFinanceira.Utilidade;
using GestaoFinanceira.Validacao;
using MetroFramework;

namespace GestaoFinanceira.Visual
{
    public partial class frmCliente : MetroForm
    {
        public frmCliente()
        {
            InitializeComponent();
        }
        private Utilidade.Conexao.utilidade_Conexao conexao = new Conexao.utilidade_Conexao(Utilidade.DadosConexao.stringConexao);
        private string usuario, operacao;
        Utilidade_Formatar Formatar = new Utilidade_Formatar();
        Utilidade_ValidaCep validaCep = new Utilidade_ValidaCep();

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
            txtUsuario.Enabled = true;
            txtBairro.Enabled = true;
            txtCep.Enabled = true;
            txtCidade.Enabled = true;
            txtComple.Enabled = true;
            txtCPF.Enabled = true;
            txtEmail.Enabled = true;
            txtEnd.Enabled = true;
            txtEstado.Enabled = true;
            txtObs.Enabled = true;
            txtTel.Enabled = true;
            txtNumero.Enabled = true;
        }
        public void DesabilitaCampos()
        {
            txtUsuario.Enabled = false;
            txtBairro.Enabled = false;
            txtCep.Enabled = false;
            txtCidade.Enabled = false;
            txtComple.Enabled = false;
            txtCPF.Enabled = false;
            txtEmail.Enabled = false;
            txtEnd.Enabled = false;
            txtEstado.Enabled = false;
            txtId.Enabled = false;
            txtObs.Enabled = false;
            txtTel.Enabled = false;
            txtNumero.Enabled = false;
        }
        public void LimpaCampo()
        {
            txtUsuario.Text = "";
            txtBairro.Text = "";
            txtCep.Text = "";
            txtCidade.Text = "";
            txtComple.Text = "";
            txtCPF.Text = "";
            txtEmail.Text = "";
            txtEnd.Text = "";
            txtEstado.Text = "";
            txtId.Text = "";
            txtObs.Text = "";
            txtTel.Text = "";
            txtNumero.Text = "";
        }
        public void VerificarCPF(string usuario)
        {
            int r = 0;
            Validacao_Cliente validacao_Cliente = new Validacao_Cliente(conexao);
            r = validacao_Cliente.VerificaCliente(txtCPF.Text);
            if(r > 0)
            {
                MetroMessageBox.Show(this,"\n\n Atenção ja existe um Cliente com esse CPF","ATENÇÃO",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.LimpaCampo();
                txtCPF.Focus();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
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
            this.AlterarBotao(2);
            this.HabilitaCampos();
            txtUsuario.Focus();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            this.DesabilitaCampos();
            this.AlterarBotao(1);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MetroMessageBox.Show(this, "\n\n Tem, certeza que deseja excluir", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resultado.ToString() == "Yes")
                {
                    conexao.AbrirConexao();
                    Validacao_Cliente cliente = new Validacao_Cliente(conexao);
                    cliente.Excluir(Convert.ToInt32(txtId.Text));
                    MetroMessageBox.Show(this, "\n\n\n Cliente Excluido com sucesso", "Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.LimpaCampo();
                    this.AlterarBotao(1);
                    this.DesabilitaCampos();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this,"\n\n\n" + ex.Message + " Ops aconteceu algum erro","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtUsuario.Focus();
                this.AlterarBotao(3);
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
                if(operacao == "Cadastrar")
                {
                    conexao.AbrirConexao();
                    Validacao_Cliente validacao_Cliente = new Validacao_Cliente(conexao);
                    Modelo_Cliente cliente = new Modelo_Cliente();
                    cliente.cpf = txtCPF.Text;
                    cliente.nome = txtUsuario.Text;
                    cliente.datacadastro = Convert.ToDateTime(DateCadastro.Text);
                    cliente.cep = txtCep.Text;
                    cliente.endereco = txtEnd.Text;
                    cliente.numero = txtNumero.Text;
                    cliente.complemento = txtComple.Text;
                    cliente.bairro = txtBairro.Text;
                    cliente.cidade = txtCidade.Text;
                    cliente.estado = txtEstado.Text;
                    cliente.email = txtEmail.Text;
                    cliente.fomecelular = txtTel.Text;
                    cliente.observacao = txtObs.Text;
                    validacao_Cliente.Inserir(cliente);
                    MetroMessageBox.Show(this,"\n\n\n Cliente cadastrado com sucesso","cadastrado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.AlterarBotao(1);
                    this.LimpaCampo();
                    this.DesabilitaCampos();
                }
                else
                {
                    conexao.AbrirConexao();
                    Validacao_Cliente validacao_Cliente = new Validacao_Cliente(conexao);
                    Modelo_Cliente cliente = new Modelo_Cliente();
                    cliente.cpf = txtCPF.Text;
                    cliente.nome = txtUsuario.Text;
                    cliente.datacadastro = Convert.ToDateTime(DateCadastro.Text);
                    cliente.cep = txtCep.Text;
                    cliente.endereco = txtEnd.Text;
                    cliente.numero = txtNumero.Text;
                    cliente.complemento = txtComple.Text;
                    cliente.bairro = txtBairro.Text;
                    cliente.cidade = txtCidade.Text;
                    cliente.estado = txtEstado.Text;
                    cliente.email = txtEmail.Text;
                    cliente.fomecelular = txtTel.Text;
                    cliente.observacao = txtObs.Text;
                    cliente.id = Convert.ToInt32(txtId.Text);
                    validacao_Cliente.Alterar(cliente);
                    MetroMessageBox.Show(this, "\n\n\n Cliente alterado com sucesso", "Alterado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.AlterarBotao(1);
                    this.LimpaCampo();
                    this.DesabilitaCampos();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "\n\n\n" + ex.Message + " Ops aconteceu algum erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
                this.AlterarBotao(3);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                frmPesquisaCliente pesquisaCliente = new frmPesquisaCliente();
                pesquisaCliente.ShowDialog();
                if (pesquisaCliente.codigo >= 0)
                {
                    Validacao_Cliente validacao = new Validacao_Cliente(conexao);
                    Modelo_Cliente cliente = validacao.CarregarCliente(pesquisaCliente.codigo);
                    txtId.Text = Convert.ToString(cliente.id);
                    txtCPF.Text = cliente.cpf;
                    txtUsuario.Text = cliente.nome;
                    DateCadastro.Text = Convert.ToString(cliente.datacadastro);
                    txtCep.Text = cliente.cep;
                    txtEnd.Text = cliente.endereco;
                    txtNumero.Text = cliente.numero;
                    txtComple.Text = cliente.complemento;
                    txtBairro.Text = cliente.bairro;
                    txtCidade.Text = cliente.cidade;
                    txtBairro.Text = cliente.bairro;
                    txtEmail.Text = cliente.email;
                    txtTel.Text = cliente.fomecelular;
                    txtObs.Text = cliente.observacao;
                    this.AlterarBotao(3);
                }
                else
                {
                    this.LimpaCampo();
                    txtUsuario.Focus();
                    this.AlterarBotao(1);
                }
                pesquisaCliente.Dispose();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message +" \\n\n Atenção Aconteceu algum erro ao buscar infomaçoes","Erro",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8)
            {
                Utilidade_Formatar.Campos edit = Utilidade_Formatar.Campos.CEP;
                Formatar.FormatarCampos(edit,txtCep);
            }
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar != (char)8)
            {
                Utilidade_Formatar.Campos edit = Utilidade_Formatar.Campos.CPF;
                Formatar.FormatarCampos(edit,txtCPF);
            }
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8)
            {
                Utilidade_Formatar.Campos edit = Utilidade_Formatar.Campos.CELULAR;
                Formatar.FormatarCampos(edit, txtTel);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if(validaCep.verificaCEP(txtCep.Text) == true)
            txtBairro.Text = Utilidade_ValidaCep.bairro;
            txtEstado.Text = Utilidade_ValidaCep.estado;
            txtCidade.Text = Utilidade_ValidaCep.cidade;
            txtEnd.Text = Utilidade_ValidaCep.endereco;
            txtComple.Text = Utilidade_ValidaCep.complemento;
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            VerificarCPF(usuario);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.AlterarBotao(1);
            this.LimpaCampo();
            this.DesabilitaCampos();
        }
    }
}
