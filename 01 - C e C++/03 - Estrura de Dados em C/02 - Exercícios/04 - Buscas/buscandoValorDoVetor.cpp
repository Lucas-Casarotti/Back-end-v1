#include<iostream>
#include <string.h>

using namespace std;

main(){
	
	int vet[10];
	int busca, v, i;
	
	cout<<"Buscando numero do vetor!"<<endl;
	for(i=0; i<10; i++){
		cout<<"Digite a posicao "<<i<<endl;
		cin>>vet[i];
		
	}
	cout<<"Digite um valor do vetor para ser buscado:"<<endl;
	cin>>busca;
	
    v = -1;                            
	for(i=0; i<10; i++){
		if(busca == vet[i]){       // se o valor digitado pelo usuario for igual o valor do vetor               
		  v = i;                  // o v recebe a posição de onde esse numero do vetor esta
	    }   	
	}
	
	if (v > -1){                               
		cout<<"Posicao do numero digitado = "<<v<<endl;
	}else{
		cout<<"Posicao nao encontrada do vetor!"<<endl;
	}
	
}
