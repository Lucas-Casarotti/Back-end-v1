#include <iostream>
#include <string.h>

using namespace std;

class Banco{
      int numero;
      char nome[30];
      float sacar,depo,saldo;

      public:
             void set_numero(int num);
             void set_nome(char *aux);
             void set_sacar(float num);
             void set_depo(float num);
             void set_saldo(float num);



			 int get_numero();
             char* get_nome();
             float get_sacar();
             float get_depo();
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

			 void Banco::set_depo(float num){
			 	depo = num;
			 };
			 void Banco::set_saldo(float num){

			 	saldo = num;
			 };




            // PARTE DO GET

             int Banco::get_numero()
             {
                return numero;
             };
             //NOME
             char* Banco::get_nome()
             {
                return nome;
             };

              //DEPOSITO
			 float Banco::get_depo(){

			  return depo;
			 };

             //SACAR
			 float Banco::get_sacar(){
			  return sacar;
			 };
			 //SALDO

			 float Banco::get_saldo(){
               saldo = depo - sacar;

			  return saldo;
			 };




             void Banco::mostra()
             {
             		cout<<"\n\n";
                   cout<<"Informações\n\n";
                   cout<<"Nome do Titular:"<<get_nome()<<"\n"<<endl;
                   cout<<"Numero da Conta:"<<get_numero()<<"\n"<<endl;
                   cout<<"Valor Depositado:"<<get_depo()<<"\n"<<endl;
                   if(sacar>depo){

                    cout<<"Você não tem esse valor pra ser sacado, tente um valor menor"<<"\n"<<endl;

                    system("pause");

                   }
                   else{
                   cout<<"Valor que foi sacado:"<<get_sacar()<<"\n"<<endl;
                   cout<<"Seu saldo atual:"<<get_saldo()<<"\n"<<endl;

                   }





                   system("pause");
                   //system("cls");
             };

main()
{
int num;
char nomes[30];
float valor;
int op;

setlocale(LC_ALL, "Portuguese");
Banco pessoa;

pessoa.set_sacar(0);
cout<<"Caixa do Banco\n\n";



cout<<"Digite seu Nome:";
fflush(stdin);
gets(nomes);
pessoa.set_nome(nomes);

cout<<"\n";
cout<<"Digite o numero da Conta:";
cin>>num;
pessoa.set_numero(num);
cout<<"\n";
cout<<"Digite o valor do seu Deposito:";
cin>>num;
pessoa.set_depo(num);

cout<<"\n";
cout<<"Valor depositado!";
cout<<"\n";

cout<<"\n";
cout<<"Deseja sacar? 1- Sim 2- Não \n";
cin>>op;

if(op ==1){

cout<<"\n";
cout<<"Digite o valor a sacar:";
cin>>num;
pessoa.set_sacar(num);


pessoa.mostra();
}
else {


pessoa.mostra();

}

};





