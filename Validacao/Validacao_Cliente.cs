using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoFinanceira.Modelo;
using GestaoFinanceira.Negocio;
using GestaoFinanceira.Utilidade;

namespace GestaoFinanceira.Validacao
{
    public class Validacao_Cliente
    {
        private Utilidade.Conexao.utilidade_Conexao conexao;

        public Validacao_Cliente(Utilidade.Conexao.utilidade_Conexao cx)
        {
            this.conexao = cx;
        }

        //VALIDAÇÃO INSERIR
        public void Inserir(Modelo_Cliente cliente)
        {
            if(cliente.nome.Trim().Length == 0)
            {
                throw new Exception("Atenção o nome do cliente é obrigatorio ");
            }
            if (cliente.cpf.Trim().Length == 0)
            {
                throw new Exception("Atenção o CPF é obrigatorio ");
            }
            if (cliente.fomecelular.Trim().Length == 0)
            {
                throw new Exception("Atenção o telefone é obrigatorio ");
            }
            Negocio_Cliente _Cliente = new Negocio_Cliente(conexao);
            _Cliente.Inserir(cliente);
        }

        //VALIDAÇÃO ALTERAR
        public void Alterar(Modelo_Cliente cliente)
        {
            if(cliente.id <= 0)
            {
                throw new Exception("atenção selecione um cliente");
            }
            if (cliente.nome.Trim().Length == 0)
            {
                throw new Exception("Atenção o nome do cliente é obrigatorio ");
            }
            if (cliente.cpf.Trim().Length == 0)
            {
                throw new Exception("Atenção o CPF é obrigatorio ");
            }
            if (cliente.fomecelular.Trim().Length == 0)
            {
                throw new Exception("Atenção o telefone é obrigatorio ");
            }
            Negocio_Cliente _Cliente = new Negocio_Cliente(conexao);
            _Cliente.Alterar(cliente);
        }

        //VALIDAÇÃO DELETAR
        public void Excluir(int codigo)
        {
            if (codigo <= 0)
            {
                throw new Exception("atenção selecione um cliente");
            }
            Negocio_Cliente _Cliente = new Negocio_Cliente(conexao);
            _Cliente.Excluir(codigo);
        }

        //VALIDAÇÃO PESQUISAR
        public DataTable ListarPesquisar(string valor)
        {
            Negocio_Cliente cliente = new Negocio_Cliente(conexao);
            return cliente.ListarPesquisar(valor);
        }

        //VALIDAÇÃO CARREGAR GRID
        public Modelo_Cliente CarregarCliente(int codigo)
        {
            Negocio_Cliente cliente = new Negocio_Cliente(conexao);
            return cliente.CarregarCliente(codigo);
        }

        //VALIDAÇÃO VERIFICA CLIENTE CADASTRADO
        public int VerificaCliente(String valor)
        {
            Negocio_Cliente cliente = new Negocio_Cliente(conexao);
            return cliente.VerificaCliente(valor);
        }
    }
}
