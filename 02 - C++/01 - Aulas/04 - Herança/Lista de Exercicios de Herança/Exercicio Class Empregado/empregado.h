#include <iostream>
#include <string.h>

using namespace std;
// CLASSE PAI

class Empregado {

private:
    int numero;
	char nome[30];

public:
    Empregado();


    public:
    void set_numero(int num);
	void set_nome(char* texto);

    int get_numero();
	char* get_nome();

	void numeroFuncional();


};

Empregado::Empregado(){


strcpy(nome,"Lucas");
numero = 1234;

};
// PARTE DO SET
void Empregado::set_nome(char *texto){
	strcpy(nome, texto);
};
void Empregado::set_numero(int num){
	numero = num;
};

// PARTE DO GET
char* Empregado::get_nome(){
	return nome;
};
int Empregado::get_numero(){
	return numero;
};

void Empregado::numeroFuncional(){

cout<<"Nome do Empregado  :"<<get_nome()<<endl;
cout<<"Numero do Empregado:"<<get_numero()<<endl;
};




