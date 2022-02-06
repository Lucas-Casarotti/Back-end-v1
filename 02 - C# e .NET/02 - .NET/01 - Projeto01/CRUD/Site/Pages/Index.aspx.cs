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
    public partial class Consulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                try
                {
                    ListarGrid();
                }
                catch (Exception ex)
                {

                    lblMensagem.Text = ex.Message;
                }
            }
               
        
        }

        public void ListarGrid()
        {
            ServicosDAL s = new ServicosDAL();
            //POPULAR O GRID
            gridServicos.DataSource = s.Listar();
            //EXIBIR O CONTEUDO DA GRID 
            gridServicos.DataBind();
        }
        protected void btnExcluirServico(object sender, EventArgs e)
        {
            try
            {
                int ID_Item = Convert.ToInt32((sender as LinkButton).CommandArgument);
                Servicos s = new Servicos();
                ServicosDAL sd = new ServicosDAL();
                

                sd.Excluir(ID_Item);
                lblMensagem.Text = "Tarefa excluída com sucesso!";
                ListarGrid();
            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
        }

        protected void btnEditarServico(object sender, EventArgs e)
        {
            // PEGANDO O ID SELECIONADO
            int ID_Item = Convert.ToInt32((sender as LinkButton).CommandArgument);
            // COLOCANDO O ID SELECIONADO EM UMA SESSION
            Session.Add("idItem", ID_Item);
            Response.Redirect("Detalhes.aspx");
        }
    }
}