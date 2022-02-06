#include <iostream>
#include <stdlib.h>
#include <time.h>

using namespace std;

main(){
	int vet[10],i,posi,achou,num;
	
	srand (time(NULL));
	
	for(i=0;i<10;i++){
		vet[i] = rand() % 100;
	}
	for(i=0;i<10;i++){
		cout<<" "<<vet[i]<<" ";
	}
	
	cout<<"\n\n Informe o elemento a ser buscado: ";
	cin>>num;
	
	i = 0;
	achou = 0;
	
	while((i<9)&&(achou==0)){
		if(vet[i]==num){
			achou=1;
			posi=i;
		}else
			i++;
	}
	if(achou==0){
		cout<<"\n Elemento nao encontrado";
	}else{
		cout<<"\n Posicao do elemento "<<posi;
	}
}
