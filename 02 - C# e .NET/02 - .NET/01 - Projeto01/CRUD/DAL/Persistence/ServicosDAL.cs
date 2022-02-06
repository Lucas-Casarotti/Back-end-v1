using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Persistence
{
    public class ServicosDAL : Conexao
    {


        public void Gravar(Servicos s)
        {
            try
            {
                //ABRINDO A CONEXÃO
                AbrirConexao();
                Cmd = new SqlCommand("insert into Servicos (ID_Usuario, Descricao, Status) values(@v1, @v2, @v3)", Con);

                Cmd.Parameters.AddWithValue("@v1", s.ID_Usuario);
                Cmd.Parameters.AddWithValue("@v2", s.Descricao);
                Cmd.Parameters.AddWithValue("@v3", s.Status);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao gravar o Lista de afazeres" + ex.Message);
            }
            finally
            {
                //FECHANDO CONEXÃO APOS O INSERT
                FecharConexao();
            }
        }

        //METODO UPDATE
        public void Atualizar(Servicos s)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("update Servicos set ID_Usuario=@v1, Descricao=@v2, Status=@v3 where ID_Item=@v4", Con);

                Cmd.Parameters.AddWithValue("@v1", s.ID_Usuario);
                Cmd.Parameters.AddWithValue("@v2", s.Descricao);
                Cmd.Parameters.AddWithValue("@v3", s.Status);
                Cmd.Parameters.AddWithValue("@v4", s.ID_Item);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao atualizar dados" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        //METODO DELETE  OK
        public void Excluir(int ID_Item)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("delete from Servicos where ID_Item=@v1", Con);
                Cmd.Parameters.AddWithValue("@v1", ID_Item);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao excluir Cliente" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }


        //METODO SELECT CLIENTE FOR ID   OK
        public Servicos PesquisarPorCodigo(int ID_Item)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from Servicos where ID_Item=@v1", Con);
                Cmd.Parameters.AddWithValue("@v1", ID_Item);
                SqlDataReader Dr = null;
                Dr = Cmd.ExecuteReader();
                Servicos s = null; //CRIANDO UM ESPAÇO NA MEMORIA: PONTEIRO

                if (Dr.Read())
                {
                   s = new Servicos();

                    s.ID_Item       = Convert.ToInt32(Dr["ID_Item"]);
                    s.ID_Usuario    = Convert.ToInt32(Dr["ID_Usuario"]);
                    s.Descricao     = Convert.ToString(Dr["Descricao"]);
                    s.Status        = Convert.ToString(Dr["Status"]);
                }
                return s;
            }
            catch (Exception ex)
            {

                throw new Exception("Código incorreto ou Serviço não existe" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }


        //METODO SELECT FROM  OK
        public List<Servicos> Listar()
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from Servicos", Con);
                SqlDataReader Dr = null;
                Dr = Cmd.ExecuteReader();
                List<Servicos> lista = new List<Servicos>();

                while (Dr.Read())
                {
                    
                    Servicos s = new Servicos();
                    s.ID_Item = Convert.ToInt32(Dr["ID_Item"]);
                    s.ID_Usuario = Convert.ToInt32(Dr["ID_Usuario"]);
                    s.Descricao = Convert.ToString(Dr["Descricao"]);
                    s.Status = Convert.ToString(Dr["Status"]);

                    lista.Add(s);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao listar Serviços" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        // SELECT FROM COM WHERE
        public List<Servicos> ListarEditar(int ID_Item)
        {
            try
            {                

                AbrirConexao();
                Cmd = new SqlCommand("select * from Servicos where ID_Item=@v1", Con);
                Cmd.Parameters.AddWithValue("@v1", ID_Item);
                SqlDataReader Dr = null;
                Dr = Cmd.ExecuteReader();
                List<Servicos> lista = new List<Servicos>();

                while (Dr.Read())
                {

                    Servicos s = new Servicos();
                    s.ID_Usuario = Convert.ToInt32(Dr["ID_Usuario"]);
                    s.Descricao = Convert.ToString(Dr["Descricao"]);
                    s.Status = Convert.ToString(Dr["Status"]);

                    lista.Add(s);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao listar Serviços" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

    }
}
