#include <iostream>
#include <string.h>

using namespace std;

class Pessoa{
      int idade;
      char nome[30],sexo[10];
      float altura,peso;
      public:
             // CADA INT NUM É DIFERENTE DO OUTRO NÃO SÃO O MESMO

             void set_nome(char *aux);
             void set_sexo(char *aux);
             void set_idade(int num);
             void set_altura(float num);
             void set_peso(float num);



             int get_idade();
             char *get_nome();
             char *get_sexo();
             float get_altura();
             float get_peso();


			 void mostra();
			 // É NESCESSARIO FAZER UM FLOAT IMC, PK NAO PODE DECLARAR ELE LA EM CIMA
             float imc();
};

            void Pessoa::set_idade(int num){
                  idade = num;
             };


             void Pessoa::set_altura(float num){

                 altura = num;

             };
             void Pessoa::set_peso(float num){

                peso  = num;

             };
             void Pessoa::set_nome(char *aux)
             {
                 // STRCPY pra quando é string

                  strcpy(nome, aux);
             };
             void Pessoa::set_sexo(char *aux)
             {
                 // STRCPY pra quando é string

                  strcpy(sexo, aux);
             };
            



             // PARTE DO GET

             int Pessoa:: get_idade(){

                 return idade;
             };
              float Pessoa:: get_altura(){

                 return altura;
             };
             float Pessoa:: get_peso(){

                 return peso;
             };
             char* Pessoa::get_nome()
             {
                  return nome;
             };

            char* Pessoa::get_sexo()
             {
                  return sexo;
             };


             float Pessoa:: imc(){

                 float imc;
                 imc = get_peso() / (get_altura()*get_altura());

                 return imc;
             };

              void Pessoa::mostra()
             {
             cout<<"\n\n";
             cout<<"Nome:"<<get_nome()<<"\n"<<endl;
             cout<<"Idade:"<<get_idade()<<"\n"<<endl;
             cout<<"Sexo:"<<get_sexo()<<"\n"<<endl;
             cout<<"Altura:"<<get_altura()<<"\n"<<endl;
             cout<<"Peso:"<<get_peso()<<"\n"<<endl;
             cout<<"Seu IMC:"<<imc()<<"\n"<<endl;

             if (imc()> 30 ) {

                cout<<"Obesidade.";
                system("pause");

             };

             if  (imc()<= 30 ) {

                cout<<"Acima do peso Normal.";
                system("pause");
             };



             if  (imc()<= 25 ) {

                cout<<"Peso Normal.";
                system("pause");

             };



             if  (imc()<=18,5) {
                cout<<"Abaixo do Peso.";
                system("pause");

             };


             system("pause");
             };

main()
{
         int num;
         char nomes[30],sexo[10];
         float valor;
         int op;

         setlocale(LC_ALL, "Portuguese");
         Pessoa gente;
         gente.set_peso(0);
         gente.set_altura(0);

         //gente.set_imc(0);




                          cout<<"Calculadora de IMC\n\n";



                          cout<<"Digite seu Nome: ";
                          fflush(stdin);
                          gets(nomes);
                          gente.set_nome(nomes);

                          cout<<"Digite sua Idade:";
                          cin>>valor;
                          gente.set_idade(valor);



                          cout<<"Digite seu Sexo: ";
                          fflush(stdin);
                          gets(sexo);
                          gente.set_sexo(sexo);









                            cout<<"\n";
                            cout<<"Deseja Calcular seu IMC? 1- Sim 2- Não \n";
                            cin>>op;

                            if(op ==1){

                            cout<<"\n";
                            cout<<"Digite sua Altura:";
                            cin>>valor;
                            gente.set_altura(valor);

                            cout<<"Digite seu Peso:";
                            cin>>valor;
                            gente.set_peso(valor);



                            gente.mostra();
                            }
                            else {


                            gente.mostra();

}

};








