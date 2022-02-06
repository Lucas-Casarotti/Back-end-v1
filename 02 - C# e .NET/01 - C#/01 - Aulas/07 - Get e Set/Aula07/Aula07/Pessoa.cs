using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07
{
    class Pessoa
    {
        private string nome { get; set; }

        public string Nome
        {
            /*
              •	Set = envia uma informação para um atributo 
              •	Get = obtém a informação enviada 
            */
            get { return nome; }
            set { nome = value; }

        }

        public Pessoa(string nome)
        {
            Console.WriteLine(this.Nome);
        }
        

        
    }
}
