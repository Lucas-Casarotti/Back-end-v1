#include<iostream>
using namespace std;

main(){
	int vet[10],i,j,aux,menor,posi,eleito;
	for(i=0;i<=9;i++){
		cout<<"Informe o elemento "<<i<<" do vetor\n";
		cin>>vet[i];
	}
	system("cls");
	cout<<" Informado\n";
	for(i=0;i<=9;i++){
		cout<<vet[i]<<" ";
	}
	for(i=0;i<=8;i++){
		eleito = vet[i];
		posi=i+1;
		menor=vet[i+1];
		for(j=i+1;j<=9;j++){
			if(vet[j]<menor){
				menor=vet[j];
				posi=j;
			}
		}
		if(vet[i]>menor){//verifica se o eleito é maior que o menor
			aux=vet[i];
			vet[i]=menor;
			vet[posi]=aux;
		}
	}
	cout<<"\n Corrigido\n";
	for(i=0;i<=9;i++){
		cout<<vet[i]<<" ";
	}
}
