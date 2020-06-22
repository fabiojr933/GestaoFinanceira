using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using GestaoFinanceira.Modelo;
using GestaoFinanceira.Utilidade;
using System.Data;
using System.Net.Configuration;

namespace GestaoFinanceira.Negocio
{
    public class Negocio_Cliente
    {
        private Utilidade.Conexao.utilidade_Conexao conexao;

        public Negocio_Cliente(Utilidade.Conexao.utilidade_Conexao cx)
        {
            this.conexao = cx;
        }

        //METEDO SALVAR NO BANCO DE DADO
        public void Inserir(Modelo_Cliente cliente)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "INSERT INTO CLIENTE (cpf, nome, datacadastro, cep, endereco, numero, complemento, bairro," +
                    " cidade, estado, email, fomecelular, observacao) VALUES(@cpf, @nome, @datacadastro, @cep, @endereco, @numero, @complemento, @bairro," +
                    " @cidade, @estado, @email, @fomecelular, @observacao)";
                cmd.Parameters.AddWithValue("@cpf",cliente.cpf);
                cmd.Parameters.AddWithValue("@nome",cliente.nome);
                cmd.Parameters.AddWithValue("@datacadastro",cliente.datacadastro);
                cmd.Parameters.AddWithValue("@cep",cliente.cep);
                cmd.Parameters.AddWithValue("@endereco",cliente.endereco);
                cmd.Parameters.AddWithValue("@numero",cliente.numero);
                cmd.Parameters.AddWithValue("@complemento",cliente.complemento);
                cmd.Parameters.AddWithValue("@bairro",cliente.bairro);
                cmd.Parameters.AddWithValue("@cidade",cliente.cidade);
                cmd.Parameters.AddWithValue("@estado",cliente.estado);
                cmd.Parameters.AddWithValue("@email",cliente.email);
                cmd.Parameters.AddWithValue("@fomecelular",cliente.fomecelular);
                cmd.Parameters.AddWithValue("@observacao",cliente.observacao);
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

        //METEDO ALTERAR NO BANCO DE DADOS
        public void Alterar(Modelo_Cliente cliente)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "UPDATE CLIENTE SET cpf = @cpf, nome = @nome, datacadastro = @datacadastro, cep = @cep, endereco = @endereco," +
                    " numero = @numero, complemento = @complemento, bairro = @bairro, cidade = @cidade, estado = @estado, email = email," +
                    " fomecelular = @fomecelular, observacao = @observacao where id = @id";
                cmd.Parameters.AddWithValue("@cpf", cliente.cpf);
                cmd.Parameters.AddWithValue("@nome", cliente.nome);
                cmd.Parameters.AddWithValue("@datacadastro", cliente.datacadastro);
                cmd.Parameters.AddWithValue("@cep", cliente.cep);
                cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
                cmd.Parameters.AddWithValue("@numero", cliente.numero);
                cmd.Parameters.AddWithValue("@complemento", cliente.complemento);
                cmd.Parameters.AddWithValue("@bairro", cliente.bairro);
                cmd.Parameters.AddWithValue("@cidade", cliente.cidade);
                cmd.Parameters.AddWithValue("@estado", cliente.estado);
                cmd.Parameters.AddWithValue("@email", cliente.email);
                cmd.Parameters.AddWithValue("@fomecelular", cliente.fomecelular);
                cmd.Parameters.AddWithValue("@observacao", cliente.observacao);
                cmd.Parameters.AddWithValue("@id", cliente.id);
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

        //METEDO EXCLUIR NO BANCO DE DADOS
        public void Excluir(int codigo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "DELETE FROM CLIENTE WHERE ID = @ID";
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

        //METEDO PESQUISAR
        public DataTable ListarPesquisar(string valor)
        {
            try
            {
                DataTable da = new DataTable();
                MySqlDataAdapter tabela = new MySqlDataAdapter("SELECT * FROM CLIENTE WHERE NOME LIKE '%" + valor + "%'", conexao.StringConexao);
                tabela.Fill(da);
                return da;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //METEDO CARREGAR DATAGRID
        public Modelo_Cliente CarregarCliente(int codigo)
        {
            try
            {
                conexao.AbrirConexao();
                MySqlCommand cmd = new MySqlCommand();
                Modelo_Cliente cliente = new Modelo_Cliente();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "SELECT * FROM CLIENTE WHERE ID = @ID";
                cmd.Parameters.AddWithValue("@ID",codigo);
                MySqlDataReader dt = cmd.ExecuteReader();
                if (dt.HasRows)
                {
                    dt.Read();
                    cliente.id = Convert.ToInt32(dt["id"]);
                    cliente.nome = Convert.ToString(dt["nome"]);
                    cliente.cpf = Convert.ToString(dt["cpf"]);
                    cliente.datacadastro = Convert.ToDateTime(dt["datacadastro"]);
                    cliente.cep = Convert.ToString(dt["cep"]);
                    cliente.endereco = Convert.ToString(dt["endereco"]);
                    cliente.numero = Convert.ToString(dt["numero"]);
                    cliente.complemento = Convert.ToString(dt["complemento"]);
                    cliente.bairro = Convert.ToString(dt["bairro"]);
                    cliente.cidade = Convert.ToString(dt["cidade"]);
                    cliente.estado = Convert.ToString(dt["estado"]);
                    cliente.email = Convert.ToString(dt["email"]);
                    cliente.fomecelular = Convert.ToString(dt["fomecelular"]);
                    cliente.observacao = Convert.ToString(dt["observacao"]);
                }
                return cliente;
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

        //VERIFICA CLIENTE CADASTRADO
        public int VerificaCliente(String valor)
        {
            try
            {
                int r = 0;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "SELECT * FROM CLIENTE WHERE CPF = @CPF";
                cmd.Parameters.AddWithValue("@CPF",valor);
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
