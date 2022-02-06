using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Exceptions
{
    public class PessoaNaoCadastrada:Exception
    {
        public PessoaNaoCadastrada()
        {

        }
        public PessoaNaoCadastrada(string message)
        : base(message)
        {
        }

        public PessoaNaoCadastrada(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
