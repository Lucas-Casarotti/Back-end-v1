using DAL.Model;
using DAL.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site.Pages
{
    public partial class CadUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnCadUsuario(object sender, EventArgs e)
        {
            try
            {

                Usuario u = new Usuario();
                u.Nome_Usuario = txtNome.Text;
                u.Email_Usuario = txtEmail.Text;
                u.Senha_Usuario = txtSenha.Text;
                UsuarioDAL d = new UsuarioDAL();

                d.Gravar(u);
                lblMensagem.Text = "Usuário " + u.Nome_Usuario + " cadastrado com sucesso!";
            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
        }
    }
}