using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01
{

    // CLASSE = USADA PARA DEFINIÇÃO DE UM OBJETO
    public class Pessoa
    {

        // ATRIBUTOS = PROPRIEDADES DA CLASSE
        public string NomePessoa { get; set; }
        public int IdadePessoa { get; set; }

        // METODOS = FUNCIONALIDADES DA CLASSE
        public void Mensagem()
        {
            Console.WriteLine("Olá " + NomePessoa + " você tem " + IdadePessoa + " anos");
           
        }
    }
}
