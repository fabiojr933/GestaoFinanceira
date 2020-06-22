using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoFinanceira.Modelo;
using GestaoFinanceira.Negocio;
using MySql.Data.MySqlClient;

namespace GestaoFinanceira.Validacao
{
    public class Validacao_FormaPagamento
    {
        private Utilidade.Conexao.utilidade_Conexao conexao;

        public Validacao_FormaPagamento (Utilidade.Conexao.utilidade_Conexao cx)
        {
            this.conexao = cx;
        }

        //METEDO GRAVAR NO BANCO
        public void SalvarFormaPag(Modelo_formaPagamento pagamento)
        {
            if(pagamento.descricao.Trim().Length == 0)
            {
                throw new Exception("O Nome da Descrição é bobrigatorio");
            }
            Negocio_FormaPagamento formaPagamento = new Negocio_FormaPagamento(conexao);
            formaPagamento.SalvarFormaPag(pagamento);
        }

        //METEDO EDITAR FORMA DE PAGAMENTO
        public void EditarFormaPag(Modelo_formaPagamento pagamento)
        {
            if(pagamento.id <= 0)
            {
                throw new Exception("selecione uma Condição");
            }
            if (pagamento.descricao.Trim().Length == 0)
            {
                throw new Exception("O Nome da Descrição é bobrigatorio");
            }
            Negocio_FormaPagamento formaPagamento = new Negocio_FormaPagamento(conexao);
            formaPagamento.EditarFormaPag(pagamento);
        }

        //METEDO EXCLUIR
        public void ExcluirFormaPag(int codigo)
        {
            if (codigo <= 0)
            {
                throw new Exception("selecione uma Condição");
            }
            Negocio_FormaPagamento formaPagamento = new Negocio_FormaPagamento(conexao);
            formaPagamento.ExcluirFormaPag(codigo);
        }

        //METEDO PESQUISAR
        public DataTable ListarFormaPag(string valor)
        {           
            Negocio_FormaPagamento formaPagamento = new Negocio_FormaPagamento(conexao);
            return formaPagamento.ListarFormaPag(valor);
        }

        //CARREGAR FORMA PAGAMENTO
        public Modelo_formaPagamento carregaFormaPag(int codigo)
        {
            Negocio_FormaPagamento formaPagamento = new Negocio_FormaPagamento(conexao);
            return formaPagamento.carregaFormaPag(codigo);
        }

        //METEDO QUE VERIFICA SE A CONDIÇÃO JA ESTA CADASTRADO
        public int VerificaFormaPag(string valor)
        {
            Negocio_FormaPagamento formaPagamento = new Negocio_FormaPagamento(conexao);
            return formaPagamento.VerificaFormaPag(valor);
        }
    }
}
