using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Model;
using DAL.Persistence;
namespace Site.Pages
{
    public partial class Detalhes : System.Web.UI.Page
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
                    int ID_Item = Convert.ToInt32(Session["idItem"]);

                    ListarTarefas(ID_Item);
                    
                }
                catch (Exception ex)
                {

                    lblMensagem.Text = ex.Message;
                }

            }


        }

        public void ListarTarefas(int ID_Item)
        {
            ServicosDAL sDal = new ServicosDAL();
            Servicos ser = sDal.PesquisarPorCodigo(ID_Item);
           
            if (ser != null)
            {
                Descricao.Text = ser.Descricao;
                cbxUsuarios.SelectedIndex = (ser.ID_Usuario - 1);
                StatusTarefa.SelectedValue = ser.Status;
               
            }
            else
            {
                lblMensagem.Text = "Tarefa não encontrada";

            }
        }

        protected void btnAtualizarTarefa(object sender, EventArgs e)
        {
            try
            {
                Servicos s = new Servicos();
                s.ID_Item = Convert.ToInt32(Session["idItem"]);
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
                d.Atualizar(s);
                lblMensagem.Text = "Tarefa alterada com sucesso!";
            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }

            
        }
    }
}