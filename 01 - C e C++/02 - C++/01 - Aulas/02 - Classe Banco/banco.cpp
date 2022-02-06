#include <iostream>
#include <string.h>

using namespace std;

class Banco{
      int numero;
      char nome[30];
      float sacar,saldo;
      public:
             void set_numero(int num);
             void set_nome(char *aux);
             void set_sacar(float num);
             void set_saldo(float num);



			 int get_numero();
             char* get_nome();
             float get_sacar();
             float get_saldo();


			 void mostra();

	};
	          // PARTE DO SET
             void Banco::set_numero(int num)
             {
                  numero = num;
             };

             void Banco::set_nome(char *aux)
             {

                  strcpy(nome, aux);
             };


			 void Banco::set_sacar(float num){
			 	sacar = num;
			 };

			 void Banco::set_saldo(float num){
			 	saldo = num;
			 };




            // PARTE DO GET

             int Banco::get_numero()
             {
                return numero;
             };
             char* Banco::get_nome()
             {
                return nome;
             };


			 float Banco::get_sacar(){
			  return sacar;
			 };

			 float Banco::get_saldo(){


			  saldo = saldo - sacar;

			  return saldo;
			 };




             void Banco::mostra()
             {
             		cout<<"\n\n";
                   cout<<"Informações\n\n";
                   cout<<"Nome do Titular:"<<get_nome()<<"\n"<<endl;
                   cout<<"Numero da Conta:"<<get_numero()<<"\n"<<endl;
                   if(sacar>saldo){

                    cout<<"Você não tem esse valor pra ser sacado, tente um valor menor"<<"\n"<<endl;

                    system("pause");

                   }
                   else{
                   cout<<"Valor que foi sacado:"<<get_sacar()<<"\n"<<endl;
                   cout<<"Seu saldo agora é:"<<get_saldo()<<"\n"<<endl;

                   };






                   system("pause");
                   //system("cls");
             };

main()
{
int num;
char nomes[30];
float valor;


setlocale(LC_ALL, "Portuguese");
Banco pessoa;

cout<<"Caixa do Banco\n\n";



cout<<"Digite seu Nome:";
fflush(stdin);
gets(nomes);
pessoa.set_nome(nomes);


cout<<"Digite o numero da Conta:";
cin>>num;
pessoa.set_numero(num);


cout<<"Digite o seu saldo:";
cin>>num;
pessoa.set_saldo(num);

cout<<"Digite o valor a sacar:";
cin>>num;
pessoa.set_sacar(num);


pessoa.mostra();


}
