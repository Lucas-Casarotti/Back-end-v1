#include <stdio.h>
#include <iostream>
using namespace std;

main(){
	int i,j,achou,aux;
	int vet[10];
	
	
	cout<<"Ordenando os vetores"<<endl;
	for(i=0;i<=9;i++){
		cout<<"Informe o valor "<<i<<""<<endl;
		cin>>vet[i];
	}
	system("cls");
	
	achou = 1;
	while(achou==1){
		achou = 0;                     // se o j for maior que 8 não vai entrar no if e o achou = 0, e vai terminar a repetição
		for(j=0;j<8;j++){        
			if(vet[j]>vet[j+1]){      // se o o lado esquerdo for maior que o direito
				achou = 1;           // achou = 1 para continuar no laço
				aux = vet[j];       // aux recebe o valor da esquerda pra não se perder
				vet[j] = vet[j+1]; // o lado esquerdo vai receber o valor do direito que é menor
				vet[j+1] = aux;   // o lado direito vai receber aux que era o valor maior que fico armazenado
			}
		}
	}
	
	cout<<"Vetor ordenado\n";
	for(i=0;i<9;i++){
		cout<<" ["<<vet[i]<<"]";  // imprimindo os vetores ordenados
	}
}
