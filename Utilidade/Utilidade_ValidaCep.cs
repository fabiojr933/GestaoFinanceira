using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.Utilidade
{
    public class Utilidade_ValidaCep
    {
        static public string cep = "";
        static public string cidade = "";
        static public string estado = "";
        static public string endereco = "";
        static public string bairro = "";
        static public string complemento = "";

        public Boolean verificaCEP(string CEP)
        {
            bool flag = false;
            try
            {
                DataSet ds = new DataSet();
                string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", cep);
                ds.ReadXml(xml);
                endereco = ds.Tables[0].Rows[0]["logradouro"].ToString();
                bairro = ds.Tables[0].Rows[0]["bairro"].ToString();
                cidade = ds.Tables[0].Rows[0]["cidade"].ToString();
                estado = ds.Tables[0].Rows[0]["uf"].ToString();
                complemento = ds.Tables[0].Rows[0]["tipo_logradouro"].ToString();
                cep = CEP;
                flag = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao buscar" + ex.Message);
                cep = "";
                cidade = "";
                estado = "";
                endereco = "";
                bairro = "";
                complemento = "";
            }
            return flag;
        }
    }
}
