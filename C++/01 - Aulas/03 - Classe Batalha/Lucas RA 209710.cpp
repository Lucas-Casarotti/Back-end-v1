#include <iostream.h>
#include <time.h>
#include <stdlib.h>
#include <stdio.h>
#include <windows.h>


using namespace std;

class LutaNaves{

public:
    // ATRIBUTOS DA CLASSE
    int Ataque, Defesa, Vida, Level;

public:
    // METODOS
    LutaNaves();
    ~LutaNaves();

    // PARTE DO SET
    void setAtaque   (int valor);
    void setDefesa   (int valor);
    void setVida     (int valor);
    void setLevel    (int valor);


    // PARTE DO GET

    int getAtaque();
    int getDefesa();
    int getVida();
    int getLevel();





    void Exibir();
    void incrementaVida();
    void incrementaLevel();


};
// PARTE DO CONSTRUTOR
// QUANDO INICIAR JA VAI ALOCAR NA MEMORIA ESSES VALORES ABAIXO
LutaNaves::LutaNaves(){
Vida    = 1;
Level   = 0;
Ataque  = 0;
Defesa  = 0;

};


LutaNaves::~LutaNaves(){

};


void LutaNaves::setAtaque(int valor){
    Ataque = valor;
};
void LutaNaves::setLevel(int valor){
    Level = valor;
};
void LutaNaves::setVida(int valor){
    Vida = valor;
};
void LutaNaves::setDefesa(int valor){
    Defesa = valor;
};


int LutaNaves:: getAtaque(){
    return Ataque;
};
int LutaNaves:: getLevel(){
    return Level;
};
int LutaNaves:: getVida(){

    return Vida;
};
int LutaNaves:: getDefesa(){

    return Defesa;
};


void LutaNaves::incrementaVida(){
    // MESMA COISA QUE SETVIDA = SETVIDA +1
    setVida(getVida()+1);

};


void LutaNaves::incrementaLevel(){

setLevel(getLevel()+1);

};

    int gerarAtaque(){
    int forca;
    srand(time(NULL));
    forca = rand()%100;
    return forca;
};
    int gerarDefesa(){
    int defesa;
    srand(time(NULL));
    defesa = rand()%100;
    return defesa;

    }

void LutaNaves::Exibir(){
cout<<"Dados da Naves"<<endl;
cout<<"Ataque da  Nave  	->"<<getAtaque()<<endl;
cout<<"Level  da  Nave   	->"<<getLevel()<<endl;
cout<<"Life   da  Nave    	->"<<getVida()<<endl;
cout<<"Defesa   da  Nave    ->"<<getDefesa()<<endl;
system("pause");

};


main (){

    int opcao =0, forca, defesa, num;
    // ACIMA NAVES INIMIGAS
    LutaNaves Delta;
    LutaNaves Prisma;
    // ABAIXO NAVES DA TERRA
    LutaNaves Mundo;
    LutaNaves Universo;

    do{
       system("cls");
       // SACA ESSA REFERENCIA
       cout<<"x x x Bem vindo a jogo Batalha NAVeis x x x\n\n";
       cout<<"1 - Exibir dados das Nave"<<endl;
       cout<<"2 - Batalhar Naves"<<endl;

       cin>>opcao;
       if(opcao ==1){

        cout<<"\n\nNave Delta\n\n";
        Delta.Exibir() and Prisma.Exibir();
        cout<<"\n\nNave Primas\n\n";

        cout<<"\n\nNave Mundo\n\n";
        Mundo.Exibir();
        cout<<"\n\nNave Universo\n\n";
        Universo.Exibir();

        }

       if(opcao ==2){
       cout<<"Digite um numero Inteiro:\n";
       cin>>num;

        if(num %2 ==0){
            cout<<"x x x Luta entre Delta e Mundo x x x\n";
            cout<<"Calculando as forcas das Naves";
            cout<<"\n\n";
            Delta.setAtaque(gerarAtaque());
            Sleep(5000);
            Mundo.setDefesa(gerarDefesa());

        if(Delta.getAtaque()> Mundo.getDefesa()){
            Delta.incrementaVida();
            Delta.incrementaLevel();
           cout<<"\n\n";
           cout<<"-- Nave Delta ganhou a terra foi invadida, corra imediatamente!! --\n\n";


        }else {
            if(Mundo.getDefesa()> Delta.getAtaque()){
            Mundo.incrementaVida();
            Mundo.incrementaLevel();
            cout<<"--- Nave Mundo ganhou, Estamos a salvo! ---\n\n";


            }
        }

      } else {

            cout<<"Empate!!";
        }

       }
       system("pause");
    }
    while (opcao != 3);
};



