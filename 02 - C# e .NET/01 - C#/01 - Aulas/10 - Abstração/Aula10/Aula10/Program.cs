﻿using System;

namespace Aula10
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica();
            PessoaJuridica pj = new PessoaJuridica();

            pf.taxaEmprestimo(1000);
            pj.taxaEmprestimo(1000);
        }
    }
}
