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
using GestaoFinanceira.Utilidade;
using GestaoFinanceira.Modelo;
using MySql.Data.MySqlClient;
using MetroFramework;
using System.Configuration;

namespace GestaoFinanceira.Visual
{
    public partial class frmLogin : MetroForm
    {
        private Utilidade.Conexao.utilidade_Conexao conexao = new Conexao.utilidade_Conexao(DadosConexao.stringConexao);
        Modelo_Usuario Modelo_Usuario = new Modelo_Usuario();
        public static string UsuarioLogado;

        //METEDO LOGAR
        public void LogarSitema()
        {
            try
            {
                MySqlConnection cx = new MySqlConnection("Server=localhost; Uid=root; Database=gestaofinanceira; Pwd=1234");
                cx.Open();
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection conectamos = new MySqlConnection();
                cmd.Connection = cx;
                cmd.CommandText = "SELECT * FROM USUARIO WHERE USUARIO = @USUARIO AND SENHA = @SENHA";
                cmd.Parameters.Add("@USUARIO", MySqlDbType.Text).Value = txtUsuario.Text;
                cmd.Parameters.Add("@SENHA", MySqlDbType.Text).Value = txtSenha.Text;
                MySqlDataReader leer = cmd.ExecuteReader();
                if (leer.Read())
                {
                    UsuarioLogado = txtUsuario.Text;
                    frmPrincipal principal = new frmPrincipal();
                    principal.ShowDialog();                   
                    this.Hide();
                }
                else
                {
                    MetroMessageBox.Show(this, "\n\n\n Usuario ou Senha Invalido", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimparCampos();
                    txtUsuario.Focus();
                }
               cx.Close();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message + "\n\n\n Ops Ocorreu algum erro", "Erro", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        public void LimparCampos()
        {
            txtSenha.Clear();
            txtUsuario.Clear();
        }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtHora.Text = DateTime.Now.ToString();
            LabelVersao.Text = Application.ProductVersion;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "" || txtSenha.Text == "")
            {
                MetroMessageBox.Show(this,"Insira Usuario ou a senha","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            LogarSitema(); 
        }
    }
}
