#include<iostream>
#include<string.h>
#include<stdlib.h>
#include<tchar.h>
#include<time.h>
#include<stdio.h>
#include<windows.h>
#include<locale.h>



using namespace std;

class LutaNaves{

public:
    // ATRIBUTOS DA CLASSE
    int Ataque, Defesa, Vida, Level,Pontos;

public:
    // METODOS
    LutaNaves();
    ~LutaNaves();

    // PARTE DO SET
    void setAtaque   (int valor);
    void setDefesa   (int valor);
    void setVida     (int valor);
    void setLevel    (int valor);
    void setPontos    (int valor);


    // PARTE DO GET

    int getAtaque();
    int getDefesa();
    int getVida();
    int getLevel();
    int getPontos();





    void Exibir();
    void incrementaVida();
    void incrementaLevel();
    void incrementaPontos();


};
// PARTE DO CONSTRUTOR
// QUANDO INICIAR JA VAI ALOCAR NA MEMORIA ESSES VALORES ABAIXO
LutaNaves::LutaNaves(){
Vida    = 1;
Level   = 1;
Ataque  = 0;
Defesa  = 0;
Pontos  = 1;

};


LutaNaves::~LutaNaves(){

};


void LutaNaves::setAtaque(int valor){
    Ataque = valor;
};
void LutaNaves::setLevel(int valor){
    Level = valor;
};
void LutaNaves::setVida(int valor){
    Vida = valor;
};
void LutaNaves::setDefesa(int valor){
    Defesa = valor;
};

void LutaNaves::setPontos(int valor){
    Pontos = valor;
};


int LutaNaves:: getAtaque(){
    return Ataque;
};
int LutaNaves:: getLevel(){
    return Level;
};
int LutaNaves:: getVida(){

    return Vida;
};
int LutaNaves:: getDefesa(){

    return Defesa;
};
int LutaNaves:: getPontos(){

    return Pontos;
};


void LutaNaves::incrementaVida(){
    // MESMA COISA QUE SETVIDA = SETVIDA +1
    setVida(getVida()+1);

};


void LutaNaves::incrementaLevel(){

setLevel(getLevel()+1);

};

void LutaNaves::incrementaPontos(){

setPontos(getPontos()+1);

};

    int gerarAtaque(){
    int forca;
    srand(time(NULL));
    forca = rand()%1000;
    return forca;
    Sleep(5000);
};
    int gerarDefesa(){
    int defesa;
    srand(time(NULL));
    defesa = rand()%1000;
    return defesa;
    Sleep(5000);

 };


void LutaNaves::Exibir(){
cout<<"Dados da Naves"<<endl;
cout<<"Ataque da  Nave   ->"<<getAtaque()<<endl;
cout<<"Level  da  Nave   ->"<<getLevel()<<endl;
cout<<"Life   da  Nave   ->"<<getVida()<<endl;
cout<<"Pontos da  Nave   ->"<<getPontos()<<endl;
cout<<"Defesa   da  Nave ->"<<getDefesa()<<endl;

system("pause");

};


int main (){

    int opcao =0, forca, defesa, rd;
    int nsorteado;
    // NAVES INIMIGAS
    LutaNaves Delta;
    LutaNaves Prisma;
    // NAVES DA ALIADAS
    LutaNaves Mundo;
    LutaNaves Universo;

    do{
       system("cls");
       system("color 3");
       system("color 0");

       // SACA ESSA REFERENCIA
       cout<<"x x x Bem vindo a jogo Batalha Navel x x x\n\n";
       cout<<"\n";
       cout<<"1- Perfil das Naves      2- Batalhar Naves"<<endl;



       cin>>opcao;
       if(opcao ==1){

            cout<<"-------------------------------------------------------";
            cout<<"\nNave Delta e Nave Mundo\n\n";
            Delta.Exibir();
            cout<<"-------------------------------------------------------";
            cout<<"\nNave Primas\n\n";
            Prisma.Exibir();
            cout<<"-------------------------------------------------------";
            cout<<"\nNave Mundo\n\n";
            Mundo.Exibir();
            cout<<"-------------------------------------------------------";
            cout<<"\nNave Universo\n\n";
            Universo.Exibir();

        }

       if(opcao ==2){
			// gerando um numero
			nsorteado = rand() % 100;

			cout<<"Numero que foi sorteado: "<<nsorteado<<endl;
			cout<<"\n";

            // SE O NUMERO FOR PAR
            if(nsorteado %2 ==0){
                cout<<"x x x Luta entre Delta e Mundo x x x\n";
                cout<<"Calculando as forcas das Naves";
                cout<<"\n\n";
                Delta.setAtaque(gerarAtaque());
                Sleep(5000);
                Mundo.setDefesa(gerarDefesa());

                // NESSE IF SO TEM AS NAVES INIMIGAS GANHANDO
                if(Delta.getAtaque()> Mundo.getDefesa()){
                    Delta.incrementaVida();
                    Delta.incrementaLevel();
                    Delta.incrementaPontos();
                    cout<<"\n\n";
                    cout<<"Ataque da Nave Delta: "<<Delta.getAtaque()<<endl;
                    cout<<"Defesa da Nave Mundo: "<<Mundo.getDefesa()<<endl;
                    Mundo.setVida(Mundo.getVida()-1);

                    // SE NAVE ZERAR A VIDA DELE ELE VAI PERDER
                    if(Mundo.getVida() == 0){
                        cout<<"- BUUUUM !! Nave Mundo destruida!! -"<<endl;

                        cout<<"\n";
                        cout<<"Level da nave  Vencedora: "<<Delta.getLevel()<<endl;
                        cout<<"Vida da nave   Vencedora: "<<Delta.getVida()<<endl;
                        cout<<"Pontos da nave Vencedora: "<<Delta.getPontos()<<endl;
                        cout<<"-------------------------------------------------------";


                        cout<<"\nProxima luta\n";
                        cout<<"x x x Prisma x Universo x x x\n";
                        cout<<"Calculando as forcas das Naves";
                        Prisma.setAtaque(gerarAtaque());
                        Sleep(5000);
                        Universo.setDefesa(gerarDefesa());

                        // SE O ATAQUE DE PRISMA FOI MAIOR QUE A DEFESA DO UNIVERSO
                        if(Prisma.getAtaque()> Universo.getDefesa()){
                            Prisma.incrementaVida();
                            Prisma.incrementaLevel();
                            Prisma.incrementaPontos();
                            cout<<"\n\n";
                            cout<<"Ataque da Nave   Prisma: "<<Prisma.getAtaque()<<endl;
                            cout<<"Defesa da Nave Universo: "<<Universo.getDefesa()<<endl;
                            Universo.setVida(Universo.getVida()-1);

                            // SE NAVE ZERAR A VIDA DA UNIVERSO
                            if(Universo.getVida() == 0){
                                cout<<"- BUUUUM !! Nave Universo destruida!! -"<<endl;
                                cout<<"\n";
                                cout<<"Level da nave  Vencedora: "<<Prisma.getLevel()<<endl;
                                cout<<"Vida da nave   Vencedora: "<<Prisma.getVida()<<endl;
                                cout<<"Pontos da nave Vencedora: "<<Delta.getPontos()<<endl;




							}
						}

					}

				}


	// NESSE ELSE AS NAVES ALIADAS VENCEM
    else {

        if(Mundo.getDefesa()> Delta.getAtaque()){
			Mundo.incrementaVida();
			Mundo.incrementaLevel();
			Mundo.incrementaPontos();
			rd = Mundo.getDefesa() - Delta.getAtaque();
			cout<<"Defesa da Nave Mundo: "<<Mundo.getDefesa()<<endl;
			cout<<"Ataque da Nave Delta: "<<Delta.getAtaque()<<endl;
			Delta.setVida(Delta.getVida()-1);


            // SE NAVE ZERAR A VIDA DO DELTA
            if(Delta.getVida() == 0){
                cout<<"- BUUUUM !! Nave Delta destruida!! -"<<endl;
                cout<<"Level da nave  Mundo: "<<Mundo.getLevel()<<endl;
                cout<<"Vida da nave   Mundo: "<<Mundo.getVida()<<endl;
                cout<<"Pontos da nave Mundo: "<<Mundo.getPontos()<<endl;
                cout<<"Defesa      restande: "<<rd<<endl;
                cout<<"-------------------------------------------------------";


                cout<<"\nProxima luta\n";
                cout<<"x x x Prisma x Universo x x x\n";
                cout<<"Calculando as forcas das Naves";
                Prisma.setAtaque(gerarAtaque());
                Sleep(5000);
                Universo.setDefesa(gerarDefesa());


               if(Universo.getDefesa()> Prisma.getAtaque()){
                    Universo.incrementaVida();
                    Universo.incrementaLevel();
                    Universo.incrementaPontos();

                    rd = Universo.getDefesa() - Prisma.getAtaque();
                    cout<<"\n\n";
                    cout<<"Defesa da Nave Universo: "<<Universo.getDefesa()<<endl;
                    cout<<"Ataque da Nave   Prisma: "<<Prisma.getAtaque()<<endl;
                    Prisma.setVida(Prisma.getVida()-1);

                    if(Prisma.getVida() == 0){
						cout<<"- BUUUUM !! Nave Prisma destruida!! -"<<endl;
                        cout<<"\n";
                        cout<<"Level da nave   Mundo: "<<Mundo.getLevel()<<endl;
                        cout<<"Vida da  nave   Mundo: "<<Mundo.getVida()<<endl;
                        cout<<"Pontos da nave  Mundo: "<<Mundo.getPontos()<<endl;
                        cout<<"Defesa      restande: "<<rd<<endl;



					}

				}

			}

		}
	}

}

   // SE O NUMERO NÃO FOR PAR
   else{
		cout<<"x x x Luta entre Prisma e Universo x x x\n";
		cout<<"Calculando as forcas das Naves";
		cout<<"\n\n";
		Prisma.setAtaque(gerarAtaque());
		Sleep(5000);
		Universo.setDefesa(gerarDefesa());

        // SE A PRISMA ATAQUE FOR MAIOR QUE A DEFESA DA UNIVERSO
        if(Prisma.getAtaque()> Universo.getDefesa()){
            Prisma.incrementaVida();
            Prisma.incrementaLevel();
            Prisma.incrementaPontos();
            cout<<"\n\n";
            cout<<"Ataque da Nave   Prisma: "<<Prisma.getAtaque()<<endl;
            cout<<"Defesa da Nave Universo: "<<Universo.getDefesa()<<endl;
            Universo.setVida(Universo.getVida()-1);

            // SE NAVE ZERAR A VIDA DA NAVE UNIVERSO
            if(Universo.getVida() == 0){
                cout<<"- BUUUUM !! Nave Universo destruida!! -"<<endl;
                cout<<"\n";
                cout<<"Level da nave  Prisma: "<<Prisma.getLevel()<<endl;
                cout<<"Vida da nave   Prisma: "<<Prisma.getVida()<<endl;
                cout<<"Pontos da nave Prisma: "<<Prisma.getPontos()<<endl;
                cout<<"-------------------------------------------------------";


                cout<<"\nProxima luta\n";
                cout<<"x x x Delta x Mundo x x x\n";
                cout<<"Calculando as forcas das Naves";
                Delta.setAtaque(gerarAtaque());
                Sleep(5000);
                Mundo.setDefesa(gerarDefesa());

                // SE O ATAQUE DA DELTA FOI MAIOR QUE A DEFESA DO MUNDO
                if(Delta.getAtaque()> Mundo.getDefesa()){
                    Delta.incrementaVida();
                    Delta.incrementaLevel();
                    Delta.incrementaPontos();
                    cout<<"\n\n";
                    cout<<"Ataque da Nave   Delta: "<<Delta.getAtaque()<<endl;
                    cout<<"Defesa da Nave   Mundo: "<<Mundo.getDefesa()<<endl;
                    Mundo.setVida(Mundo.getVida()-1);

                    // SE NAVE ZERAR A VIDA DA NAVE MUNDO
                    if(Mundo.getVida() == 0){
                        cout<<"- BUUUUM !! Nave Universo destruida!! -"<<endl;
                        cout<<"\n";
                        cout<<"Level da nave   Prisma: "<<Prisma.getLevel()<<endl;
                        cout<<"Vida da nave    Prisma: "<<Prisma.getVida()<<endl;
                        cout<<"Pontos da nave  Prisma: "<<Prisma.getPontos()<<endl;
                    }



                }

            }

		}

		else {
		// SE DEFESA UNIVERSO FOR MAIOR QUE ATAQUE PRISMA
			if(Universo.getDefesa()> Prisma.getAtaque()){
				Universo.incrementaVida();
				Universo.incrementaLevel();
				Universo.incrementaPontos();
				rd = Universo.getDefesa() - Prisma.getAtaque();
				cout<<"Defesa da Nave Universo: "<<Universo.getDefesa()<<endl;
				cout<<"Ataque da Nave   Prisma: "<<Prisma.getAtaque()<<endl;
				Prisma.setVida(Delta.getVida()-1);


				// SE NAVE ZERAR A VIDA DA NAVE PRISMA
				if(Prisma.getVida() == 0){
					cout<<"- BUUUUM !! Nave Prisma destruida!! -"<<endl;
					cout<<"\n";
					cout<<"Level da nave    Universo: "<<Universo.getLevel()<<endl;
					cout<<"Vida da nave     Universo: "<<Universo.getVida()<<endl;
					cout<<"Pontos da nave   Universo: "<<Universo.getPontos()<<endl;
					cout<<"Defesa      	  	restande: "<<rd<<endl;
					cout<<"-------------------------------------------------------";

					cout<<"\nProxima luta\n";

					// COMECANDO A PROXIMA LUTA PK A VIDA FOI ZERADA
					cout<<"x x x Delta x Mundo x x x\n";
					cout<<"Calculando as forcas das Naves";
					Delta.setAtaque(gerarAtaque());
					Sleep(5000);
					Mundo.setDefesa(gerarDefesa());

					// SE A DEFESA DA NAVE MUNDO FOI MAIOR QUE O ATAQUE DA DELTA
					if(Mundo.getDefesa()> Delta.getAtaque()){
						Mundo.incrementaVida();
						Mundo.incrementaLevel();
						rd = Mundo.getDefesa() - Delta.getAtaque();
						cout<<"\n\n";
						cout<<"Defesa da Nave Mundo: "<<Mundo.getDefesa()<<endl;
						cout<<"Ataque da Nave Delta: "<<Delta.getAtaque()<<endl;
						Delta.setVida(Delta.getVida()-1);


						// SE NAVE ZERAR A VIDA DELE ELE VAI PERDER
						if(Delta.getVida() == 0){
							cout<<"- BUUUUM !! Nave Delta destruida!! -"<<endl;
							cout<<"\n";
							cout<<"Level da nave    Mundo: "<<Mundo.getLevel()<<endl;
							cout<<"Vida da  nave    Mundo: "<<Mundo.getVida()<<endl;
							cout<<"Pontos da  nave  Mundo: "<<Mundo.getVida()<<endl;
							cout<<"Defesa        restande: "<<rd<<endl;
						}


					}

				}

			}
		}

	}
	if ((Universo.getVida() == 0) and (Delta.getVida() ==0)){
		cout<<"Batalha Final:  Mundo x Prisma";
		if (Mundo.getDefesa()> Prisma.getAtaque()){
			cout<<"Nave Mundo venceu, terra foi salva!";
		}
		else{
			cout<<"Nave Prisma venceu, terra foi Destruida!";

		}

	}
	if ((Mundo.getVida() == 0) and (Prisma.getVida() ==0)){
		cout<<"Batalha Final:  Universo x Delta";
		if (Universo.getDefesa()> Delta.getAtaque()){
			cout<<"Nave Universo venceu, terra foi salva!";
		}
		else{
			cout<<"Nave Delta venceu, terra foi Destruida!";

		}

	}


	if ((Universo.getVida() == 0) and (Mundo.getVida() ==0)){
     cout<<"\n";
     cout<<"As duas equipes Inimigas venceram!!";
     cout<<"\n\n";
     cout<<"Naves aliadas eliminadas!!";
     return 0;

    }
    else {
       	cout<<"\n";
        cout<<"As duas equipes aliadas venceram!!";
        cout<<"\n\n";
        cout<<"Naves inimigas eliminadas!!";
        cout<<"\n";
        return 0;

    }

system("pause");
}
    }while (opcao != 3);
};




