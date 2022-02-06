#include <stdio.h>
#include <iostream>
using namespace std;

main(){
	int vet[8], i, j, aux, num, posi, inicio, fim, achou;

	for(i=0; i<=7; i++){
		cout<<"Informe o elemento " <<i<<" do vetor"<<endl;
		cin>>vet[i];
	}

	//algum codigo de ordenação

	achou = 1;
	while(achou==1){
		achou = 0;
		for(j=0;j<8;j++){
			if(vet[j]>vet[j+1]){
				achou = 1;
				aux = vet[j];
				vet[j] = vet[j+1];
				vet[j+1] = aux;
			}
		}
	}

	cout<<"Informe o elemento a ser buscado!"<<endl;
	cin>>num;

	inicio  = 0;
	fim 	= 7;
	posi    = (inicio + fim)/2;
	achou   = 0;


	while((inicio <= num) && (achou == 0)){
		if(num == vet[posi]){
			achou = 1;
		}
		else {
			if(num > vet[posi]){
				inicio = posi +1;
				posi = (inicio + fim) / 2;
			}
			else {
				fim = posi - 1;
				posi = (inicio + fim) / 2;
			}
		}

	}

	if(achou == 0){
		cout<<"Não encontrado!"<<endl;

	}
	else {
		cout<<"Numero encontrado na posição:"<<posi;
	}




}
