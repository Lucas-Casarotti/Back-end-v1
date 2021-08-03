#include <iostream>
#include <stdlib.h>
#include <time.h>

using namespace std;

	int const maxtam=10;
	int pilha[maxtam];
	int topo;

	void Inicializar(){
		topo = -1;
	}
	bool Pilha_vazia(){
		if(topo==-1){
			return true;
		}else{
			return false;
		}
	}
	bool Pilha_cheia(){
		if(topo==maxtam-1){
			return true;
		}else{
			return false;
		}
	}
	bool Pilha_Push(int valor){
		if(Pilha_cheia()){
			return false;
		}else{
			topo++;
			pilha[topo]=valor;
			return true;
		}
	}
	bool Pilha_Pop(int &valor){
		if(Pilha_vazia()){
			return false;
		}else{
			valor=pilha[topo];
			topo --;
			return true;
		}
	}
	bool Pilha_get(int &valor){
		if(Pilha_vazia()){
			return false;
		}else{
			valor=pilha[topo];
			return true;
		}
	}
	int Pilha_tamanho(){
		return topo + 1;
	}

main(){
	int valor, valorTopo, opc;
		Inicializar();
		do{
		cout<<"--- Escolha a sua opcao ---"<<endl;
		cout<<"1- Empilhar"<<endl;
		cout<<"2- Desempilhar"<<endl;
		cout<<"3- Valor do topo"<<endl;
		cout<<"4- Tamanho da pilha"<<endl;
		cout<<"5- Sair"<<endl;
		cout<<"R:";
		cin>> opc;
		
		
		if(opc == 1 ){
			if(Pilha_cheia()){
				cout<<"A pilha está cheia, desempilhe um valor!"<<endl;
			}
			else {
				cout<<"Escolha o valor para empilhar:";
				cin>>valor;
				valorTopo = valor;
				Pilha_Push(valor);
				
			}
		
		}
		else{
			if(opc == 2){
				if(Pilha_vazia()){
					cout<<"A pilha está vazia, empilhe um valor!"<<endl;
				}
				else{
					cout<<"Valor desempilhado: ";
					cout<<valor<<endl;
					Pilha_Pop(pilha[topo]);
					valorTopo = pilha[topo];
					
				}
			}
			else{
				if(opc == 3){
					cout<<"Valor do topo: "pilha[topo]<<endl;
				}
				else{
					if(opc == 4){
						cout<<"Tamanho da pilha: "Pilha_tamanho()<<endl;
					}
				}
			
			}
			
		}
	}while(opc!=5);	
}

