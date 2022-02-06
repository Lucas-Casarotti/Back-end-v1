using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAL.Persistence // ADO.NET -> SQL SERVER
{
    public class Conexao
    {
        // USANDO PROTECTED PARA SOMENTE ACESSO EM HERANÇA
        protected SqlConnection Con; //UTILIZADO PARA ESTABELECER CONEXAO
        protected SqlCommand Cmd;    //UTILIZADO PARA EXECUTAR COMANDOS SQL NO BANCO
        protected SqlDataAdapter Dr; //UTILIZADO PARA LER REGISTROS DE QUERYS

        //METODO - > ABRIR CONEXÃO
        protected void AbrirConexao()
        {
            try
            {
                //CONNECTION STRING
                Con = new SqlConnection("Data Source=DESKTOP-GNRB423\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True"); 
                Con.Open();
            }
            catch (Exception ex)
            {
                // PARA EXIBIR O ERRO CASO O BANCO NÃO ABRA
                throw new Exception(ex.Message);
            }
        }

        //METODO - > FECHAR CONEXÃO
        protected void FecharConexao()
        {
            try
            {
                Con.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
