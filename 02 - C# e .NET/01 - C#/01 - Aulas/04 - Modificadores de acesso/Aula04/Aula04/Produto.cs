using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04
{
    public class Produto
    {
        /*
            TIPOS DE MODIFICADORES DE ACESSO
            public      -> Atributos e métodos visíveis para todas as classes
            private     -> Atributos e métodos visíveis apenas onde foi criados
            protected   -> Atributos e métodos visíveis em classes onde são criados ou herdados
        */

        public string nome;
        private double valor;
    }
}
