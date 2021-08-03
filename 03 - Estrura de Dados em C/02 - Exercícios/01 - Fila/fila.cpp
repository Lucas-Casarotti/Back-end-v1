#include<iostream>

using namespace std;


int const maxtam = 5;
int fila [maxtam];
int frente, tras;

void inicializar(){
	
	frente = 0;
	tras   = -1;
}

bool fila_vazia(){
	if(frente > tras){
		return true;
	}else {
		return false;
	}
}

bool fila_cheia(){
	if(tras == maxtam - 1){
		return true;
	}else {
		return false;
	}
}


bool enfileirar(int valor){
	if(fila_cheia()){
		return false;
	}else {
		tras ++;
		fila[tras] = valor;
		return true;
	}
}

bool desenfileirar(int &valor){
	if(fila_vazia()){
		return false;
	}else {
		valor = fila[frente];
		frente ++;
		return true;
	}
	
}                                          
void fila_get(int valor){
	if(fila_vazia()){
		cout<<"Fila vazia!"<<endl;
	}else {
		valor = fila[frente];
		cout<<"valor da frente: "<<fila[frente]<<endl;
	}
}

void fila_tam(){
	if(fila_vazia()){
		cout<<"Fila vazia!"<<endl;
	}else {
		cout<<(tras - frente) + 1<<endl;
	}
}


main(){
	int valor;
	int opc, valorFrente;	
	inicializar();
	system("color 2");
	system("cls");
	do{
	
	cout<<"Menu fila"<<endl;
	cout<<"Escolha uma opcao"<<endl;
	cout<<"1- Enfileirar"<<endl;
	cout<<"2- Desenfileirar"<<endl;
	cout<<"3- Frente fila"<<endl;
	cout<<"4- Tamanho fila"<<endl;
	cout<<"5- Sair"<<endl;
	cin>>opc;
	
	if(opc == 1){
		if(fila_cheia()){
			cout<<"Fila cheia"<<endl;
		}else {
			cout<<"Digite um valor para enfileirar: "<<endl;
			cin>>valor;
			enfileirar(valor);
		}
	}
	
	else{
		if(opc == 2){
			if(fila_vazia()){
				cout<<"Fila vazia"<<endl;
			}else {
			cout<<"Valor desenfileirado:  "<<fila[frente]<<endl;
				desenfileirar(fila[frente]);
			}
		}else{
			if(opc == 3){
			
				fila_get(valor);
			}else {
				if(opc == 4){
			
					fila_tam();
				}
			}	
		}
	
	}
	
		
	}while(opc!=5);
	



	
	
	
}
