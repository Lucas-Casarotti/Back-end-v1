using System;
using System.Globalization;

namespace ExerciciosResolvidos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 01
            //int senha;
            //int senhaAtual = 2002;
            //Console.WriteLine("Digite a senha: ");
            //senha = int.Parse(Console.ReadLine());
            //while (senha != senhaAtual)
            //{
            //    Console.WriteLine("Senha inválida!");
            //    Console.WriteLine("Digite a senha novamente: ");
            //    senha = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Acesso permitido");

            //Exercicio 02
            //string[] valores = Console.ReadLine().Split(' ');
            //int x = int.Parse(valores[0]);
            //int y = int.Parse(valores[1]);
            //while (x != 0 && y != 0)
            //{
            //    if (x > 0 && y > 0)
            //    {
            //        Console.WriteLine("primeiro");
            //    }
            //    else if (x < 0 && y > 0)
            //    {
            //        Console.WriteLine("segundo");
            //    }
            //    else if (x < 0 && y < 0)
            //    {
            //        Console.WriteLine("terceiro");
            //    }
            //    else
            //    {
            //        Console.WriteLine("quarto");
            //    }
            //    valores = Console.ReadLine().Split(' ');
            //    x = int.Parse(valores[0]);
            //    y = int.Parse(valores[1]);
            //}

            //Exercicio 03
            //int alcool = 0;
            //int gasolina = 0;
            //int diesel = 0;
            //int tipo;

            //Console.WriteLine("Digite qual combústivel você prefere? ");
            //Console.WriteLine("1 - Álcool , 2 - Gasolina, 3 - Diesel, 4 - Sair");
            //tipo = int.Parse(Console.ReadLine());

            //while (tipo != 4)
            //{
            //    if (tipo == 1)
            //    {
            //        alcool += 1;
            //    }
            //    else if (tipo == 2)
            //    {
            //        gasolina += 1;
            //    }
            //    else if (tipo == 3)
            //    {
            //        diesel += 1;
            //    }
            //    Console.WriteLine("Digite qual combústivel você prefere? ");
            //    Console.WriteLine("1 - Álcool , 2 - Gasolina, 3 - Diesel, 4 - Sair");
            //    tipo = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Agradeços a sua preferencia");
            //Console.WriteLine("Alcool: "   + alcool);
            //Console.WriteLine("Gasolina: " + gasolina);
            //Console.WriteLine("Diesel: "   + diesel);

            //Exercicios para treinamento
            //int chocolate;
            //int branco = 0;
            //int preto  = 0;
            //int amargo = 0;
            //Console.WriteLine("Qual chocolate você mais gosta? 1- Branco 2- Preto 3- Amargo 4- Sair");
            //chocolate = int.Parse(Console.ReadLine());
            //while(chocolate != 4)
            //{
            //    if (chocolate == 1)
            //    {
            //        branco = branco + 1;
            //    }
            //    else if (chocolate == 2)
            //    {
            //        preto = preto + 1;
            //    }
            //    else if (chocolate == 3)
            //    {
            //        amargo = amargo + 1;
            //    }
            //    Console.WriteLine("Qual chocolate você mais gosta? 1- Branco 2- Preto 3- Amargo 4- Sair");
            //    chocolate = int.Parse(Console.ReadLine());

            //}
            //Console.WriteLine("Resultado da votação");
            //Console.WriteLine("Chocolate branco: " + branco);
            //Console.WriteLine("Chocolate preto: " + preto);
            //Console.WriteLine("Chocolate amargo: " + amargo);

            int aluno;
            int lucas = 0;
            int jp    = 0;
            int joao  = 0;
            Console.WriteLine("Votação para representante da turma");
            Console.WriteLine("1- Lucas 2- JP 3- João 4- Sair");
            aluno = int.Parse(Console.ReadLine());
            while (aluno != 4)
            {
                if (aluno == 1)
                    lucas = lucas + 1;
                else if( aluno == 2)
                    jp = jp + 1;
                else
                    joao = joao + 1;

                Console.WriteLine("1- Lucas 2- JP 3- João 4- Sair");
                aluno = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Resultado da votação");
            Console.WriteLine("Votos do Lucas: " + lucas);
            Console.WriteLine("Votos do JP: " + jp);
            Console.WriteLine("Votos do João: " + joao);

            if (lucas > jp && lucas > joao)
                Console.WriteLine("Lucas campeão com " + lucas + " votos");
            else if (jp > lucas && jp > joao)
                Console.WriteLine("JP campeão com " + jp + " votos");
            else if (joao > lucas && joao > jp)
                Console.WriteLine("João campeão com " + joao + " votos");
            else
                Console.WriteLine("Empate");
        }
    }
}
