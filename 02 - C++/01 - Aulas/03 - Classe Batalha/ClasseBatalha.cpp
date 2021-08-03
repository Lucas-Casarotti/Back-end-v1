#include <iostream.h>
#include <time.h>
#include <stdlib.h>
#include <stdio.h>
#include <windows.h>


using namespace std;

class Batalha{

public:
    // ATRIBUTOS DA CLASSE
    int Ataque, Serie, Vida;

public:
    // METODOS
    Batalha();
    ~Batalha();

    // PARTE DO SET
    void setAtaque  (int valor);
    void setSerie   (int valor);
    void setVida    (int valor);

    // PARTE DO GET

    int getAtaque();
    int getSerie();
    int getVida();


    void Exibir();
    void incrementaVida();
    void incrementaSerie();


};
// PARTE DO CONSTRUTOR
// QUANDO INICIAR JA VAI ALOCAR NA MEMORIA ESSES VALORES ABAIXO
Batalha::Batalha(){
Vida    = 1;
Serie   = 0;
Ataque  = 0;

};

// PARTE DO DESTRUTOR
Batalha::~Batalha(){
    //delete  Vida;
    //delete  Serie;
    //delete  Ataque;
};
// PARTE DO SET
void Batalha::setAtaque(int valor){
    Ataque = valor;
};
void Batalha::setSerie(int valor){
    Serie = valor;
};
void Batalha::setVida(int valor){
    Vida = valor;
};

// PARTE DO GET
int Batalha:: getAtaque(){
    return Ataque;
};
int Batalha:: getSerie(){
    return Serie;
};
int Batalha:: getVida(){

    return Vida;
};

void Batalha::incrementaVida(){
    // MESMA COISA QUE SETVIDA = SETVIDA +1

    setVida(getVida()+1);

};


void Batalha::incrementaSerie(){

setSerie(getSerie()+1);

};


    int gerarAtaque(){
    int forca;
    srand(time(NULL));
    forca = rand()%100; // sortea um numero aleatorio entra 0 e 100
    return forca;
};

void Batalha::Exibir(){
cout<<"Dados da Equipe"<<endl;
cout<<"Ataque   ->"<<getAtaque()<<endl;
cout<<"Serie    ->"<<getSerie()<<endl;
cout<<"Vida     ->"<<getVida()<<endl;
system("pause");

};


main (){

    int opcao =0, forca;
    Batalha LV;
    Batalha Mendes;

    do{
       system("cls");
       cout<<"x x x Escolha sua opcao x x x\n\n";
       cout<<" 1 - Exibir Equipes"<<endl;
       cout<<" 2 - Batalhar"<<endl;
       cout<<" 3 - Sair"<<endl;
       cout<<"Escolha ->";
       cin>>opcao;
       if(opcao ==1){

        cout<<"\n\nEquipe LV\n\n";
        LV.Exibir();
        cout<<"\n\nEquipe Mendes\n\n";
        Mendes.Exibir();

       }

       if(opcao ==2){
        cout<<"Calculando as forcas equipes";
        LV.setAtaque(gerarAtaque());
        Sleep(5000);
        Mendes.setAtaque(gerarAtaque());

        if(LV.getAtaque()> Mendes.getAtaque()){
           LV.incrementaVida();
           LV.incrementaSerie();
           cout<<"--- Equipe LV Justice League Ganhou ---\n\n";
           cout<<"--- Total de Vitorias: \n\n"<<LV.getSerie()<<endl;

        }else {
        if(LV.getAtaque()< Mendes.getAtaque()){
        Mendes.incrementaVida();
        Mendes.incrementaSerie();
        cout<<"--- Equipe Mendes Ganhou ---\n\n";
        cout<<"--- Total de Vitorias: \n\n"<<Mendes.getSerie()<<endl;

        } else {

            cout<<"Empate!!";
        }

       }
       system("pause");
    }
    }while (opcao != 3);
};


