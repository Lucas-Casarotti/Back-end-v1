using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Exceptions;
using DAL.Model;
using DAL.Persistence;
using System.Web.Security;

namespace Site.Pages
{
    public partial class Login : System.Web.UI.Page
    {
        private LoginBo _loginBo;
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLoginUsuario(object sender, EventArgs e)
        {
            _loginBo = new LoginBo();

            var Email_Usuario = txtEmail.Text;
            var Senha_Usuario = txtSenha.Text;

            try
            {
                var usuario= _loginBo.ObterUsuarioLogin(Email_Usuario, Senha_Usuario);
                FormsAuthentication.RedirectFromLoginPage(Email_Usuario, false);
            }
            catch (Exception)
            {

                lblStatus.Text = "E-mail não cadastrado ou senha incorreta!";
            }

        }
    }
}