using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestaoFinanceira.Modelo;
using GestaoFinanceira.Utilidade;
using MetroFramework;
using MySql.Data.MySqlClient;


namespace GestaoFinanceira.Negocio
{
    public class Negocio_Usuario
    {
        private Conexao.utilidade_Conexao conexao;
    //  MySqlCommand comando = null;

        public Negocio_Usuario(Conexao.utilidade_Conexao cx)
        {
            this.conexao = cx;
        }

        //GRAVAR USUARIO NO BANCO
        public void SalvarUsuario(Modelo_Usuario usuario)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "INSERT INTO USUARIO (USUARIO,SENHA) VALUES(@USUARIO,@SENHA)";
                cmd.Parameters.AddWithValue("@USUARIO", usuario.usuario);
                cmd.Parameters.AddWithValue("@SENHA", usuario.senha);
                cmd.ExecuteNonQuery();                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        //EDITAR USUARIO NO BANCO
        public void EditarUsuario(Modelo_Usuario usuario)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "UPDATE USUARIO SET USUARIO = @USUARIO, SENHA = @SENHA WHERE ID = @ID";
                cmd.Parameters.AddWithValue("@USUARIO", usuario.usuario);
                cmd.Parameters.AddWithValue("@SENHA", usuario.senha);
                cmd.Parameters.AddWithValue("@ID", usuario.id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        //EXCLUIR USUARIO NO BANCO
        public void ExcluirUsuario(int codigo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "DELETE FROM USUARIO WHERE ID = @ID";
                cmd.Parameters.AddWithValue("@ID",codigo);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        //LISTAR USUARIO NO BANCO DE DADOS
        public DataTable ListarUsuario(String valor)
        {
            try
            {
                DataTable tabela = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM USUARIO WHERE USUARIO like '%" + valor + "%'",conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //CARREGAR DATA GRID USUARIO NO BANCO DE DADOS
        public Modelo_Usuario CarregarUsuario(int codigo)
        {
            try
            {
                conexao.AbrirConexao();
                Modelo_Usuario usuario = new Modelo_Usuario();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "SELECT * FROM USUARIO WHERE ID = @ID";
                cmd.Parameters.AddWithValue("@ID",codigo);
                MySqlDataReader dt = cmd.ExecuteReader();
                if (dt.HasRows)
                {
                    dt.Read();
                    usuario.id = Convert.ToInt32(dt["id"]);
                    usuario.usuario = Convert.ToString(dt["usuario"]);
                    usuario.senha = Convert.ToString(dt["senha"]);
                }
                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        //VERIFICA USUARIO NO BANCO
        public int VerificaUsuario(String valor)
        {
            try
            {
                int r = 0;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "SELECT* FROM USUARIO WHERE USUARIO = @USUARIO";
                cmd.Parameters.AddWithValue("@USUARIO",valor);
                conexao.AbrirConexao();
                MySqlDataReader da = cmd.ExecuteReader();
                if (da.HasRows)
                {
                    da.Read();
                    r = Convert.ToInt32(da["id"]);
                }
                return r;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message); ;
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        
        
    }
}
