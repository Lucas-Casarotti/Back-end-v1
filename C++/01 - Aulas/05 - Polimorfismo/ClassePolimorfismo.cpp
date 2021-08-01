#include <iostream>
#include <string.h>
using namespace std;

// SUPERCLASSE ESPORTISTA
class Esportista {
    //PROTECTED AS CLASSES FILHAS TBM PODEM ACESSAR
    protected:
        char nome[20];
        int idade;
        float velocidademaxima;
    public:

        // METODOS
        void set_nome(char *texto);
        void set_idade(int valor);
        void set_velocidademaxima(float valor);

        char* get_nome();
        int get_idade();
        float get_velocidademaxima();

        void exibir();
        void cadastrarEsportista();

};
// SET
void Esportista::set_nome(char *texto){
    strcpy(nome,texto);
};
void Esportista::set_idade(int valor){
    idade = valor;
};
void Esportista::set_velocidademaxima(float valor){
    velocidademaxima = valor;
};

// GET
char* Esportista::get_nome(){
    return nome;
};
int Esportista::get_idade(){
    return idade;
};
float Esportista::get_velocidademaxima(){
    return velocidademaxima;
};


void Esportista::exibir(){

    cout<<"Nome :"<<get_nome()<<endl;
    cout<<"Idade:"<<get_idade()<<endl;
    cout<<"Velocidade Maxima:"<<get_velocidademaxima()<<endl;

};
// CADASTRANDO O ESPORTISTA
void Esportista::cadastrarEsportista(){

    char aux[50];
    int nro;
    float valor;
    cout<<"Digite seu  Nome:"<<endl;
    cin>>aux;
    cout<<"Digite sua idade:"<<endl;
    cin>>nro;
    cout<<"Velocidade Maxima:"<<endl;
    cin>>valor;
    set_nome(aux);
    set_idade(nro);
    set_velocidademaxima(valor);


};


// SUBCLASSE NADADOR
class Nadador:public Esportista{
    private:
        float folego;
    public:
        // METODOS
        void set_folego(float valor);
        float get_folego();


        void exibirNadador();
        void cadastrarNadador();

};

void Nadador::set_folego(float valor){
    folego = valor;
};
float Nadador::get_folego(){
    return folego;
};


void Nadador::exibirNadador(){
// O EXIBIR JA TEM O NOME IDADE E VELOCIDADE MAXIMA
exibir();
cout<<"Folego do nadador:"<<get_folego()<<endl;


};
void Nadador::cadastrarNadador(){
    cout<<"\n\n";
    float valor;
    cadastrarEsportista();

    cout<<"Digite seu Folego:"<<endl;
    cin>>valor;
    set_folego(valor);

};




// SUBCLASSE GAMER
class Gamer:public Esportista{

    private:
        float qtdhoras;
    public:
        void set_qtdhoras(float valor);
        float get_qtdhoras();

        void exibirGamer();
        void cadastrarGamer();

};

void Gamer::set_qtdhoras(float valor){
    qtdhoras = valor;
};
float Gamer::get_qtdhoras(){
    return qtdhoras;
};

void Gamer::exibirGamer(){
exibir();
cout<<"Quantidade de horas:"<<get_qtdhoras()<<endl;

};

void Gamer::cadastrarGamer(){

    float valor;
    cadastrarEsportista();

    cout<<"Digite quantidade horas jogadas:"<<endl;
    cin>>valor;
    set_qtdhoras(valor);

};

main (){
    Nadador xandao;
    Gamer JC;

    xandao.cadastrarNadador();
    xandao.exibirNadador();
    JC.cadastrarGamer();
    JC.exibirGamer();

};
