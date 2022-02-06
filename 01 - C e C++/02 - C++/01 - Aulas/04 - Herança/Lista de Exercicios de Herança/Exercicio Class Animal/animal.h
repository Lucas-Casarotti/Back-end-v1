#include <iostream>
#include <string.h>

using namespace std;
// CLASSE PAI

class Animal {

private:
    char tipo[30];
	char cor[30];

public:
    Animal();


    public:
    void set_tipo(char* texto);
	void set_cor(char* texto);

    char* get_tipo();
	char* get_cor();

	void exibirTipoCor();


};

Animal::Animal(){

strcpy(tipo,"cachorro");
strcpy(cor,"branco");

};
// PARTE DO SET
void Animal::set_tipo(char *texto){
	strcpy(tipo, texto);
};
void Animal::set_cor(char *texto){
	strcpy(cor, texto);
};

// PARTE DO GET
char* Animal::get_tipo(){
	return tipo;
};
char* Animal::get_cor(){
	return cor;
};

void Animal::exibirTipoCor(){

cout<<"Animal:"<<get_tipo()<<endl;
cout<<"Cor:"<<get_cor()<<endl;
};




