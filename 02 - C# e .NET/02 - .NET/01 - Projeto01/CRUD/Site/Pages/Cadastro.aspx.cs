using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Model;
using DAL.Persistence;
using System.Data;

namespace Site.Pages
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                try
                {
                    UsuarioDAL u = new UsuarioDAL();

                    List<Usuario> lista = new List<Usuario>();
                    lista = u.Listar();

                    for (int cont = 0; lista.Count > cont; cont++)
                    {
                        ListItem item = new ListItem(lista[cont].Nome_Usuario, lista[cont].ID_Usuario.ToString());
                        cbxUsuarios.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {

                    lblMensagem.Text = ex.Message;
                }
            }            
        }

        protected void btnCadastrar(object sender, EventArgs e)
        {
               
            try
            {
                Servicos s = new Servicos();                

                s.ID_Usuario = int.Parse(cbxUsuarios.SelectedValue);
                s.Descricao = Descricao.Text;                
                
                switch (StatusTarefa.SelectedValue)
                {
                    case "AN":
                        s.Status = "Em Andamento";
                        break;
                    case "CO":
                        s.Status = "Concluída";
                        break;
                    case "CC":
                        s.Status = "Cancelada";
                        break;
                }

                ServicosDAL d = new ServicosDAL();               

                d.Gravar(s); 
                lblMensagem.Text = "Tarefa cadastrada com sucesso!";
            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
        }
    }
}