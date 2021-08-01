#include <iostream>
#include <string.h>
#include "ContaEspecial.h";
main(){
	char txt[50];
	float num;
	float s=0;
	float d=0;
	int opc;

	ContaEspecial Conta;

	do{

		cout<<"Caixa do Banco\n\n";
		cout<<" 1- Depositar\n";
		cout<<" 2- Sacar\n";
		cout<<" 3- Extrato\n";
		cout<<" 4- Exibir Conta\n";
		cout<<" 5- Sair\n";
		cout<<"Escolha uma operacao ->";
		cout<<"\n";
		cout<<"\n";

		cin>>opc;

		if(opc == 1){
			cout<<"Informe o valor: ";
			cin>>num;
			Conta.set_depositar(num);
			Conta.Deposito();
			d += Conta.get_depositar();
			system("pause");
		}

		if(opc == 2){
			cout<<"Informe o valor: ";
			cin>>num;
			Conta.set_sacar(num);
			Conta.limiteCredito();
			s += Conta.get_sacar();
			system("pause");


		}

		if(opc == 3){
			Conta.Deposito();

			cout<<" Total Sacado    :"<<s<<endl;
			cout<<" Total Depositado:"<<d<<"\n\n";
			system("pause");

		}

		if(opc == 4){
			Conta.exibir();

		}

	}while(opc!=5);
};
