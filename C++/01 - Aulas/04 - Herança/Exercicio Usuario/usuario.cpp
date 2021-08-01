#include <studio>
#include <iostream>
#include <stdlib.h>
#includee <string.h>

using namespace std;

//Classe Pai
	class Usuario{
	
		private:
		char Nome[30];
		char Apelido[15];
	
		public:
		void setNome(char *texto);
		void setApelido(char *texto);
		
		char* getNome();
		char* getApelido();
		
		
		void ExibirDados();
	};

void Usuario::setNome(char *texto){
	strcpy(Nome, texto);
};

void Usuario::setApelido(char *texto){
	strcpy(Nome,texto);
};

char* Usuario::getNome(){
	return Nome;
};

char* Usuario::getApelido(){
	return Apelido;
};

void Usuario::ExibirDados(){
	cout<<"\n\n";
	cout<<"Nome: "<<getNome()<<endl;
	cout<<"Apelido: "<<getApelido()<<endl;
}
