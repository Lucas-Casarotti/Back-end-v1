#include <iostream>
#include <string.h>

using namespace std;

class Aluno{

      char nome[30],disciplina[10];
      float nota1,nota2,faltas;
      public:
             // CADA INT NUM É DIFERENTE DO OUTRO NÃO SÃO O MESMO

             void set_nome(char *aux);
             void set_disciplina(char *aux);
             void set_nota1(float num);
             void set_nota2(float num);
             void set_faltas(float num);




             char *get_nome();
             char *get_disciplina();
             float get_nota1();
             float get_nota2();
             float get_faltas();

            // PRA MOSTRAR A MEDIA
             float media();

			 void mostra();

};



             void Aluno::set_nota1(float num){
                  nota1 = num;
             };

               void Aluno::set_nota2(float num){
                  nota2 = num;
             };

             void Aluno::set_nome(char *aux)
             {
                 // STRCPY pra quando é string

                  strcpy(nome, aux);
             };
             void Aluno::set_disciplina(char *aux)
             {
                 // STRCPY pra quando é string

                  strcpy(disciplina, aux);
             };

             void Aluno::set_faltas(float num){

                faltas  = num;

             };


             // PARTE DO GET
             float Aluno:: get_faltas(){

                 return faltas;
             };

             float Aluno:: get_nota1(){

                 return nota1;
             };
             float Aluno:: get_nota2(){

                 return nota2;
             };
             char* Aluno::get_nome()
             {
                  return nome;
             };

            char* Aluno::get_disciplina()
             {
                  return disciplina;
             };

             // A MEDIA NÃO É DECLARADO LA NO SET E GET
             float Aluno:: media(){

                 return ((get_nota1() + get_nota2()) / 2);
             };


              void Aluno::mostra()
             {
             cout<<"\n\n";
             cout<<"Nome do Aluno:"<<get_nome()<<"\n"<<endl;
             cout<<"Disciplina:"<<get_disciplina()<<"\n"<<endl;
             cout<<"Primeira Nota:"<<get_nota1()<<"\n"<<endl;
             cout<<"Segunda Nota:"<<get_nota2()<<"\n"<<endl;
             cout<<"Faltas:"<<get_faltas()<<"\n"<<endl;
             cout<<"Media:"<<media()<<"\n"<<endl;


             if (get_faltas() > 20){

                cout<<"Reprovado por faltas!";
             }
             else {
             if (media()>= 7.0 ){

                cout<<"Aprovado!";
                system("pause");

             };

             if  (media()<7.0 ){

                cout<<"Exame!";
                system("pause");

             };

             if  (media()< 3.0 ){

                cout<<"Reprovado!";
                system("pause");

             };

             };


             system("pause");
             };

             main()
{
         int num;
         char nomes[30],disciplina[10];
         float valor;


         Aluno pessoa;




                          cout<<"Calculadora de Média\n\n";



                          cout<<"Digite seu Nome: ";
                          fflush(stdin);
                          gets(nomes);
                          pessoa.set_nome(nomes);


                          cout<<"Digite a Disciplina: ";
                          fflush(stdin);
                          gets(disciplina);
                          pessoa.set_disciplina(disciplina);



                          cout<<"Digite a primeira Nota:";
                          cin>>valor;
                          pessoa.set_nota1(valor);

                          cout<<"Digite a segunda Nota:";
                          cin>>valor;
                          pessoa.set_nota2(valor);

                          cout<<"Digite a quantidade de Faltas:";
                          cin>>valor;
                          pessoa.set_faltas(valor);








                       pessoa.mostra();

                       };









