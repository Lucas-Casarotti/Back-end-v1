using DAL.Exceptions;
using DAL.Model;
using DAL.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Persistence
{
    public class LoginBo
    {
        private UsuarioDAL _usuarioDAL;
        public Usuario ObterUsuarioLogin(string Email_Usuario, string Senha_Usuario)
        {
            _usuarioDAL = new UsuarioDAL();
            var usuario = _usuarioDAL.LoginUsuario(Email_Usuario, Senha_Usuario);
            if (usuario == null)
            {
                throw new PessoaNaoCadastrada();
            }
            else
            {
                return usuario;
            }
        }
    }
}
