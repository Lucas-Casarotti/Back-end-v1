#include "animal.h"
class Cachorro: public Animal{

	private:
    char nome[30];
	char raca[30];
	public:
    Cachorro();
    public:
    void set_nome(char* texto);
	void set_raca(char* texto);

    char* get_nome();
	char* get_raca();

	void exibirNomeRaca();


};

Cachorro::Cachorro(){
strcpy(nome,"Max");
strcpy(raca,"Pastor Alemao");
};
void Cachorro::set_nome(char *texto){
	strcpy(nome, texto);
};
void Cachorro::set_raca(char *texto){
	strcpy(raca, texto);
};

// PARTE DO GET
char* Cachorro::get_nome(){
	return nome;
};
char* Cachorro::get_raca(){
	return raca;
};
void Cachorro::exibirNomeRaca(){

cout<<"Nome:"<<get_nome()<<endl;
cout<<"Raca:"<<get_raca()<<endl;
};





