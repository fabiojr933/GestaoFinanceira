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
    public class Validacao_Usuario
    {
        private  Utilidade.Conexao.utilidade_Conexao Conexao;

        public Validacao_Usuario(Utilidade.Conexao.utilidade_Conexao cx)
        {
            this.Conexao = cx;
        }

        //VALIDAÇÃO AO GRAVAR
        public void SalvarUsuario(Modelo_Usuario usuario)
        {
            if(usuario.usuario.Trim().Length == 0)
            {
                throw new Exception(" Atenção Nome do Usuario é Obrigadotorio! ");
            }
            if(usuario.senha.Trim().Length == 0)
            {
                throw new Exception(" Atenção a Senha é Obrigatorio ");
            }
            Negocio_Usuario GravarUsuario = new Negocio_Usuario(Conexao);
            GravarUsuario.SalvarUsuario(usuario);
        }

        //VALIDAÇÃO AO EDITAR
        public void EditarUsuario(Modelo_Usuario usuario)
        {
            if(usuario.id <= 0)
            {
                throw new Exception(" Por Favor Selecione um USUARIO ");
            }
            if (usuario.usuario.Trim().Length == 0)
            {
                throw new Exception(" Atenção Nome do Usuario é Obrigadotorio! ");
            }
            if (usuario.senha.Trim().Length == 0)
            {
                throw new Exception(" Atenção a Senha é Obrigatorio ");
            }
            Negocio_Usuario Usuario = new Negocio_Usuario(Conexao);
            Usuario.EditarUsuario(usuario);
        }

        //VALIDACAO AO EXCLUIR
        public void ExcluirUsuario(int codigo)
        {
            if(codigo <= 0)
            {
                throw new Exception(" Por Favor Selecione um Cliente");
            }
            Negocio_Usuario Usuario = new Negocio_Usuario(Conexao);
            Usuario.ExcluirUsuario(codigo);
        }

        //VALIDAÇÃO AO LISTAR
        public DataTable ListarUsuario(String valor)
        {
            Negocio_Usuario Usuario = new Negocio_Usuario(Conexao);
            return Usuario.ListarUsuario(valor);
        }

        //VALIDAÇÃO AO CARREGAR USUARIOS NA DATA GRID
        public Modelo_Usuario CarregarUsuario(int codigo)
        {
            Negocio_Usuario Usuario = new Negocio_Usuario(Conexao);
            return Usuario.CarregarUsuario(codigo);
        }

        //VALIDAÇÃO SE JA EXISTE USUARIO
        public int VerificaUsuario(String valor)
        {
            Negocio_Usuario usuario = new Negocio_Usuario(Conexao);
            return usuario.VerificaUsuario(valor);
        }
    }
}
