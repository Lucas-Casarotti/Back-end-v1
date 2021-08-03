#include<iostream>

using namespace std;

main(){
	int vet[10],i,j,achou,posi,eleito;
	//Solicitar ao usuario informar os elementos do vetor
	for(i=0;i<=9;i++){
		cout<<"Informe o elemento "<<i<<" do vetor\n";
		cin>>vet[i];
	}
	system("cls");
	cout<<" Informado\n";
	for(i=0;i<=9;i++){
		cout<<vet[i]<<" ";
	}
	for(i=1;i<=9;i++){//i=eleito
		eleito=vet[i];
		j=0;
		achou=0;
		while((j<i)&&(achou==0)){//busca sequencial p/ achar o encaixe do eleito
			if(vet[j]>eleito){
				achou=1;//Sair do laço
				posi=j;//Aramazenar posição de encaixe do eleito
			}else
				j++;
		}
		if(achou==1){
			for(j=1;j>posi;j--){//deslocamento para inserção
				vet[j]=vet[j-1];//deslocamento
			}
			vet[posi]=eleito;//inserçãoo
		}
	}
	cout<<"\n Corrigido\n";
	for(i=0;i<=9;i++){
		cout<<vet[i]<<" ";
	}
}
