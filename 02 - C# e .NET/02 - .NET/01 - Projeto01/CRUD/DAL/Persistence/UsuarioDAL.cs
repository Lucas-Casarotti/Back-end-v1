using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Persistence
{
    public class UsuarioDAL : Conexao
    {
        //METODO INSERT OK
        public void Gravar(Usuario u)
        {
            try
            {
                //ABRINDO A CONEXÃO
                AbrirConexao();
                Cmd = new SqlCommand("insert into Usuario (Nome_Usuario, Email_Usuario, Senha_Usuario) values(@v1, @v2, @v3)", Con);

                //INDICANDO QUEM E QUEM DE ACORDO COM A CLASSE PESSOA
                Cmd.Parameters.AddWithValue("@v1", u.Nome_Usuario);
                Cmd.Parameters.AddWithValue("@v2", u.Email_Usuario);
                Cmd.Parameters.AddWithValue("@v3", u.Senha_Usuario);

                //EXECUTANDO O METODO
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao gravar o Usuário" + ex.Message);
            }
            finally
            {
                //FECHANDO CONEXÃO APOS O INSERT
                FecharConexao();
            }
        }

        
        public Usuario LoginUsuario(string Email_Usuario, string Senha_Usuario)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from Usuario where Email_Usuario=@v1 AND Senha_Usuario=@v2", Con);
                Cmd.Parameters.AddWithValue("@v1", Email_Usuario);
                Cmd.Parameters.AddWithValue("@v2", Senha_Usuario);

                SqlDataReader Dr = null;
                Dr = Cmd.ExecuteReader();
                Usuario u = null;

                if (Dr.Read())
                {
                    u = new Usuario();

                    u.ID_Usuario   = Convert.ToInt32(Dr["ID_Usuario"]);
                    u.Nome_Usuario = Convert.ToString(Dr["Nome_Usuario"]);
                    u.Email_Usuario = Convert.ToString(Dr["Email_Usuario"]);
                    u.Senha_Usuario = Convert.ToString(Dr["Senha_Usuario"]);
                }
                return u;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao logar" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public List<Usuario> Listar()
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from Usuario", Con);
                SqlDataReader Dr = null;
                Dr = Cmd.ExecuteReader();
                List<Usuario> lista = new List<Usuario>();

                while (Dr.Read())
                {
                    Usuario u = new Usuario();
                                    
                    u.ID_Usuario    = Convert.ToInt32(Dr["ID_Usuario"]);
                    u.Nome_Usuario  = Convert.ToString(Dr["Nome_Usuario"]);
                   

                    lista.Add(u);
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
