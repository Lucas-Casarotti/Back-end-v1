#include <iostream>
#include <string.h>
#include "cachorro.h";

main(){
	char texto[50];
	int opc;

	Cachorro Cachorro;

	do{

		cout<<" 1- Tipo e a cor do Animal\n";
		cout<<" 2- Nome e a raca do Animal\n";
		cout<<" 3- Sair\n";
		cout<<"Escolha uma opcao->";
		cout<<"\n";
		cout<<"\n";
		cin>>opc;

		if(opc == 1){
			Cachorro.exibirTipoCor();
			system("pause");
		}

		if(opc == 2){
			Cachorro.exibirNomeRaca();
			system("pause");
		}



	}while(opc!=3);
};


