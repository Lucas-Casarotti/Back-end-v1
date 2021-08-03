#include<iostream>
#include<time.h>
#include<locale>
#include<stdlib.h>
using namespace std;

main(){

    setlocale(LC_ALL, "Portuguese");

    int  minado[5][5], linha, coluna, le, ce;
    // o campo minado vai ser uma matriz de 5 x 5
    char ex[5][5];
    int x = 0;
    int bomba = 0;


    srand(time(NULL));


    for(linha=0; linha<5;linha++){
        for(coluna=0;coluna<10;coluna++){
            minado[linha][coluna] = rand()%2;
            minado[0][coluna] = 5;
            minado[linha][0] = 5;
            ex[linha][coluna] = '*';
        }
    }

// definindo os numeros de cada possição
    ex[0][0] = '0';
    ex[0][1] = '1';
    ex[0][2] = '2';
    ex[0][3] = '3';
    ex[0][4] = '4';
    ex[0][5] = '5';


    ex[1][0] = '1';
    ex[2][0] = '2';
    ex[3][0] = '3';
    ex[4][0] = '4';
    ex[5][0] = '5';


    // enquanto o x for igual a 0 ele irá continuar jogando
    while(x == 0){
        //imprime a matriz
        for(linha=0;linha<5;linha++){
            cout<<"\n\n";
            for(coluna=0;coluna<5;coluna++){
                cout<<"   ";
                cout<<ex[linha][coluna];
            }
        }

        // jogador escolhendo onde quer jogar
        cout<<"\n\n";
        cout<<" Escolha uma linha para jogar: ";
        cin>>le;
        // VAI LER A LINHA ESCOLHIDA
        cout<<"\n";
        cout<<" Escolha uma linha para jogar: ";
        cin>>ce;


        if(le > 5 && le < 1){
        //casso o numero seja maior que 5 e menor que um irá mostrar a mensagem
             system("cls");
            cout<<"Escolha outra linha";
            system("cls");
        }
        else
            {

            if(ce > 5 && ce < 1){
            system("cls");
            cout<<"Escolha outra coluna!";

            system("cls");
            }
            // caso o usuario nao digite a linha ou a coluna maior que 5 e menor que 1 ira pro else logo abaixo e testa se a linha ja foi jogada
            else{


            if(minado[le][ce] == 3){
            cout<<"\n\n";
            cout<<"Escolha outra essa possição ja foi jogada!";
            system("cls");
            }else{

            if(minado[le][ce] == 1){
            system("cls");
            cout<<"\n\n\n";
            // se o jogador acerta uma bomba o jogo ira finalizar
            cout<<"Que pena você perdeu, mas não desanime!!";
            cout<<"\n\n";
            cout<<" 'x' são Bomba\n";
            cout<<"\n\n";
            cout<<" 'o' são os campos sem bomba\n";

            for(linha=0;linha<5;linha++){
            cout<<"\n\n";
            for(coluna=0;coluna<5;coluna++){
                cout<<"   ";
                // vai mostrar os campos com bomba e sem bomba após o usuario perder
                if (minado[linha][coluna] == 0 or minado[linha][coluna] == 3) ex[linha][coluna] = 'o';
                cout<<ex[linha][coluna];
            }
        }
            x = 1;
            }else{

            //Muda de 0 para 3 para saber q ja foi jogado
             minado[le][ce] = 3;
             ex[le][ce] = 'o';

             for(linha=0; linha<5; linha++){
             for(coluna=0; coluna<5; coluna++){
             if(minado[linha][coluna] == 0){ bomba++; }
            }
            // se os lugares com bomba chegar ao 0, ou seja o usuario nao acerto nenhuma bomba, ele venceu o jogo e mostrará a msensagem
            }
             if(bomba == 0){
             cout<<"Você ganhou, parabéns!";
             x = 1;
             }
             bomba = 0;

                }
            }
        }
    }
}  }


