using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoFinanceira.Modelo;
using GestaoFinanceira.Utilidade;
using MySql.Data.MySqlClient;

namespace GestaoFinanceira.Negocio
{
    public class Negocio_FormaPagamento
    {
        private Utilidade.Conexao.utilidade_Conexao conexao;
        public Negocio_FormaPagamento(Utilidade.Conexao.utilidade_Conexao cx)
        {
            this.conexao = cx;
        }

        //METEDO GRAVAR NO BANCO
        public void SalvarFormaPag(Modelo_formaPagamento pagamento)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "INSERT INTO FORMAPAGAMENTO (DESCRICAO) VALUES(@DESCRICAO)";
                cmd.Parameters.AddWithValue("@DESCRICAO", pagamento.descricao);
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

        //METEDO EDITAR FORMA DE PAGAMENTO
        public void EditarFormaPag(Modelo_formaPagamento pagamento)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "UPDATE FORMAPAGAMENTO SET DESCRICAO = @DESCRICAO WHERE ID = @ID";
                cmd.Parameters.AddWithValue("@DESCRICAO", pagamento.descricao);
                cmd.Parameters.AddWithValue("@ID",pagamento.id);
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

        //METEDO EXCLUIR
        public void ExcluirFormaPag(int codigo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "DELETE FROM FORMAPAGAMENTO WHERE ID = @ID";
                cmd.Parameters.AddWithValue("@ID", codigo);
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

        //METEDO PESQUISAR
        public DataTable ListarFormaPag(string valor)
        {
            try
            {
                DataTable tabela = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM FORMAPAGAMENTO WHERE DESCRICAO LIKE '%"+valor+"%'",conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //CARREGAR FORMA PAGAMENTO
        public Modelo_formaPagamento carregaFormaPag(int codigo)
        {
            try
            {
                conexao.AbrirConexao();
                Modelo_formaPagamento formaPagamento = new Modelo_formaPagamento();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "SELECT * FROM FORMAPAGAMENTO WHERE ID = @ID";
                cmd.Parameters.AddWithValue("@ID", codigo);
                MySqlDataReader dt = cmd.ExecuteReader();
                if (dt.HasRows)
                {
                    dt.Read();
                    formaPagamento.id = Convert.ToInt32(dt["id"]);
                    formaPagamento.descricao = Convert.ToString(dt["descricao"]);
                }
                return formaPagamento;
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

        //METEDO QUE VERIFICA SE A CONDIÇÃO JA ESTA CADASTRADO
        public int VerificaFormaPag(string valor)
        {
            try
            {
                int r = 0;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "SELECT * FROM FORMAPAGAMENTO WHERE DESCRICAO = @DESCRICAO";
                cmd.Parameters.AddWithValue("@DESCRICAO",valor);
                conexao.AbrirConexao();
                MySqlDataReader dt = cmd.ExecuteReader();
                if (dt.HasRows)
                {
                    dt.Read();
                    r = Convert.ToInt32(dt["id"]);
                }
                return r;
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
    }
}
