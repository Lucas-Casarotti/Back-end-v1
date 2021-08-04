#include <iostream>
#include <string.h>

using namespace std;
// CLASSE PAI

class Conta {

private:
    char nome[30];
    int numero;

    float saldo,sacar,depositar,consultasaldo;


public:
    Conta();

    public :
    void set_nome(char* texto);
    void set_numero(int num);
    void set_saldo(float num);
    void set_sacar(float num);
    void set_depositar(float num);


    char* get_nome();
    int get_numero();
    float get_saldo();
    float get_sacar();
    float get_depositar();


    void  exibir();
    void Deposito();
    float Saque();

};

Conta::Conta(){

strcpy(nome,"lucas");
numero      = 17896;
saldo       = 1000;



};
// PARTE DO SET
void Conta::set_nome(char *texto){
	strcpy(nome, texto);
};

void Conta::set_numero(int num){
    numero = num;
};

void Conta::set_saldo(float num){
    saldo = num;
};

 void Conta::set_sacar(float num){
    sacar = num;
};

void Conta::set_depositar(float num){
    depositar = num;
};


// PARTE DO GET
char* Conta::get_nome(){
	return nome;
};
int Conta::get_numero(){
    return numero;
};
float Conta::get_saldo(){
    return saldo;
};

float Conta::get_depositar(){
    return depositar;

};

float Conta::get_sacar(){
    return sacar;

};

//float Conta::Saque(){
    //set_saldo(get_saldo() - get_sacar());



void Conta::exibir(){
cout<<"Nome:     "<<get_nome()<<"\n"<<endl;
cout<<"Conta:    "<<get_numero()<<"\n"<<endl;
cout<<"Saldo:    "<<get_saldo()<<"\n"<<endl;
};
void Conta::Deposito(){
	system("cls");
	set_saldo(get_depositar() + get_saldo());

};











