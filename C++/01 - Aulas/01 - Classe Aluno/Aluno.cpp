#include <iostream>
#include <string.h>

using namespace std;

class Pessoa{
      int numero, idade,qtdfilhos;
      char nome[30],endereco[30];
      float altura,salario;
      public:
             // CADA INT NUM É DIFERENTE DO OUTRO NÃO SÃO O MESMO
             void set_numero(int num);
             void set_nome(char *aux);
             void set_endereco(char *aux);
             void set_idade(int num);
             void set_altura(float num);
             void set_qtdfilhos(int num);
             void set_salario(float num);

			 int get_numero();
             int get_idade();
             char *get_nome();
             char *get_endereco();
             float get_altura();
             int get_qtdfilhos();
             float get_salario();

			 void mostra();
			 void aniversario();
			 void aumento(float num);
			 float salfamilia();

	};

            // PARTE DO SET
             void Pessoa::set_numero(int num)
             {
                  numero = num;
             };

             void Pessoa::set_nome(char *aux)
             {
                 // STRCPY pra quando é string

                  strcpy(nome, aux);
             };

             void Pessoa::set_endereco(char *aux)
             {
                  strcpy(endereco, aux);
             };

             void Pessoa::set_idade(int num)
             {

                  idade = num;
             };

             void Pessoa::set_altura(float num){
             	   altura = num;
			 }


			 void Pessoa::set_qtdfilhos(int num){

			       qtdfilhos=num;

			 }

			 void Pessoa::set_salario(float num){

                    salario=num;

			 }

			 //PARTE DO GET
             int Pessoa::get_numero()
             {
                 return numero;
             };
             char* Pessoa::get_nome()
             {
                  return nome;
             };

             char* Pessoa::get_endereco()
             {
                  return endereco;
             };

             int Pessoa::get_idade()
             {
                 return idade;
             };

             float Pessoa::get_altura(){
             	return altura;
			 }

			 int Pessoa::get_qtdfilhos(){

                return qtdfilhos;
			 }
             float Pessoa::get_salario(){

                return salario;

             }

             void Pessoa::aniversario(){

               int aux = get_idade()+1;
               // ABAIXO VAI ATUALIZAR A IDADE ERA POR EXEMPLO IDADE 21, VAI ATUALIZAR E IR PRA 22
               set_idade(aux);


             }
             void Pessoa::aumento(float num){

             set_salario((1 + num /100)* get_salario());


             }
             float Pessoa::salfamilia(){

             return get_qtdfilhos()*200;
             }

             void Pessoa::mostra()
             {
                   cout<<"xxxxxxxxxxxxxx DADOS xxxxxxxxxxxxxx\n\n";
                   cout<<"NUMERO do RA: "<<get_numero()<<"\n"<<endl;
                   cout<<"NOME: "<<get_nome()<<"\n"<<endl;
                   cout<<"Endereco: "<<get_endereco()<<"\n"<<endl;
                   cout<<"Idade: "<<get_idade()<<"\n"<<endl;
                   cout<<"Altura:"<<get_altura()<<"\n"<<endl;
                   cout<<"Quantidade de Filhos:"<<get_qtdfilhos()<<"\n"<<endl;
                   cout<<"Salario:"<<get_salario()<<"\n"<<endl;
                   cout<<"Salario Familia:"<<salfamilia()<<"\n"<<endl;


                   system("pause");
                   //system("cls");
                   cout<<"\n\n Você irá fazer aniversario.."<<endl;
                   aniversario();
                   cout<<"Sua nova idade é:"<<get_idade()<<"\n"<<endl;

                   float aux;

                   cout<<"Informe o percentual de aumento:";
                   cin>>aux;
                   aumento(aux);
                   cout<<"Seu novo salario é:"<<get_salario()<<"\n"<<endl;


                   system("pause");


             };

main()
{
         int num;
         char nomes[30];
         float valor;

         Pessoa aluno;

         Pessoa aluno2;

                          cout<<"UniSalesiano - 2018 \n\n";
                          cout<<"CADASTRO DO ALUNO 1 \n\n";
                          cout<<"DIGITE O NUMERO DO RA: ";
                          cin>>num;
                          aluno.set_numero(num);

                          cout<<"DIGITE O NOME: ";
                          fflush(stdin);
                          gets(nomes);
                          aluno.set_nome(nomes);

                          cout<<"DIGITE O ENDERECO: ";
                          fflush(stdin);
                          gets(nomes);
                          aluno.set_endereco(nomes);

                          cout<<"DIGITE A IDADE: ";
                          cin>>num;
                          aluno.set_idade(num);

                          cout<<"DIGITE A ALTURA:";
                          cin>>valor;
                          aluno.set_altura(valor);

                          cout<<"DIGITE A QUANTIDADE DE FILHOS:";
                          cin>>num;
                          aluno.set_qtdfilhos(num);

                          cout<<"DIGITE O SEU SALARIO:";
                          cin>>valor;
                          aluno.set_salario(valor);






                          system("pause");
                          system("cls");


                          cout<<"CADASTRO DO ALUNO 2 \n\n";
                          cout<<"DIGITE O NUMERO DO RA: ";
                          cin>>num;
                          aluno2.set_numero(num);

                          cout<<"DIGITE O NOME: ";
                          fflush(stdin);
                          gets(nomes);
                          aluno2.set_nome(nomes);

                          cout<<"DIGITE O ENDERECO: ";
                          fflush(stdin);
                          gets(nomes);
                          aluno2.set_endereco(nomes);

                          cout<<"DIGITE A IDADE: ";
                          cin>>num;
                          aluno2.set_idade(num);

                          cout<<"DIGITE A ALTURA:";
                          cin>>valor;
                          aluno2.set_altura(valor);

                          cout<<"DIGITE A QUANTIDADE DE FILHOS:";
                          cin>>num;
                          aluno2.set_qtdfilhos(num);

                          cout<<"DIGITE O SEU SALARIO:";
                          cin>>valor;
                          aluno2.set_salario(valor);

                          system("pause");
                          system("cls");



                          aluno.mostra();
                          aluno2.mostra();


}
