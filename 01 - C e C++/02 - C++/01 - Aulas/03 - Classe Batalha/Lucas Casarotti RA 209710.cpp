#include <iostream>
#include <time.h>
#include <stdlib.h>
#include <stdio.h>
#include <windows.h>

using namespace std;

class Batalha{

   public:
   int Ataque, Serie, Vida;
   public:
      Batalha();
	  ~Batalha();

	  void setAtaque(int valor);
	  void setSerie(int valor);
	  void setVida(int valor);

	  int getAtaque();
	  int getSerie();
	  int getVida();

	  void Exibir();

};


 Batalha::Batalha(){
 	Vida = 5;
 	Serie = 0;
 	Ataque = 0;
 }

 Batalha::~Batalha(){
 }

 void Batalha::setAtaque(int valor){
 	Ataque = valor;
 };
 void Batalha::setSerie(int valor){
 	Serie = valor;
 };
 void Batalha::setVida(int valor){
 	Vida = valor;
 };

 int Batalha::getAtaque(){
 	return Ataque;
 };
 int Batalha::getSerie(){
 	return Serie;
 };
 int Batalha::getVida(){
 	return Vida;
 };

 void Batalha::Exibir(){
 	cout<<"Dados Equipe de cada Lutador\n\n"<<endl;
 	cout<<"Ataque -> "<<getAtaque()<<endl;
 	cout<<"Serie -> "<<getSerie()<<endl;
 	cout<<"Vida -> "<<getVida()<<endl;
 	cout<<"\n\n\n";
   system("pause");
 };



 int gerarAtaque(){
 	int forca; // variavel para calcular forca de ataque
 	srand(time(NULL)); // reseta o randomizer
 	forca = rand()%100; // randoriza um numero ente 0 e 100
 	return forca;
 };

 main(){
 	int opcao=0, forca;
 	Batalha Xandao, Serjao;
 	do{
 		system("cls");
 		cout<<" x x x Escolha sua opcao x x x\n\n"<<endl;
 		cout<<"1 -> Exibir Equipes"<<endl;
 		cout<<"2 -> Colocar os guerreiros pra batalhar"<<endl;
 		cout<<"3 -> Sair"<<endl;
 		cin>>opcao;
 		if (opcao==1){
 			cout<<" Equipe do Xandao"<<endl;

 			Xandao.Exibir();
 			cout<<"Equipe do Serjao"<<endl;

 			Serjao.Exibir();

		 }
		 //SE A OPC FOR IGUAL A DOIS VAI GERAR O ATAQUE XANDAO E DO SERJAO PELO SRAND QUE VAI CAIR UM VALOR ALEATORIO
		 if (opcao==2){
            cout<<"Calculando as forcas equipes";
		 	Xandao.setAtaque(gerarAtaque());
		 	// FOI USADO O SLEEP PRA O RAND NAO FICA DANDO ERRO.
		 	Sleep(5000);
		 	Serjao.setAtaque(gerarAtaque());
            system("pause");
		 }
             // SE O ATAQUE DO XANDAO FOR MAIOR QUE O DE SERJAO
		 	if (Xandao.getAtaque() > Serjao.getAtaque()){
		 		cout<<"Equipe do Xandao GANHOU!!\n\n";

                    // VAI TIRAR UM DE VIDA DO SERJAO
                    Serjao.setVida(Serjao.getVida()-1);
                    // SE O XANDAO ZERAR A VIDA DELE ELE VAI PERDER
                    if(Xandao.getVida() == 0){
                        cout<<"A Equipe do Serjao foi a vencedora, xora Xandao!!"<<endl;
                    }
                     system("pause");

                }
		 		else{
                    // SE O ATAQUE DO SERJAO FOR MAIOR QUE O DO XANDAO
                    if (Serjao.getAtaque() > Xandao.getAtaque()){
                        // VAI TIRAR UM DA VIDA DO XANDAO
		 				Xandao.setVida(Xandao.getVida()-1);
		 				cout<<"Equipe do Serjao GANHOU!\n\n";
                        // SE A VIDA DO SERJAO ZERAR A EQUIPE INIMIGA IRA GANHAR
                        if (Serjao.getVida() == 0){
                            cout<<"A Equipe do Xandao foi a vencedora!"<<endl;
                        }
                         system("pause");

                    }
				}

	}while (opcao != 3);
}
