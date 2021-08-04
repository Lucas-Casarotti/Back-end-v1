#include <iostream>
using namespace std;

main()
{

    int mat[3][2];
    int soma;
    float media,qt;

    soma = 0;
    qt = 0;
    cout << "Preenchendo matriz.\n";
    for(int i=0; i<3; i++)
        for(int c=0; c<2; c++){
                cout << "Matriz[" <<i<< "]" << "[" <<c<< "]:";
                cin>>mat[i][c];
                soma=soma+mat[i][c];
        }

// variavel soma vai acumular os valores da matriz
    for(int i=0; i<3; i++)
        for(int c=0; c<2; c++){
            cout << "\nMatriz[" <<i<< "]" << "[" <<c<< "]:";
            cout<<mat[i][c];
        }

    media=soma/6;
    cout<<"\nMedia ="<<media; // outro jeito de fazer soma/(3*2);

    for(int i=0; i<3; i++)
        for(int c=0; c<2; c++)
            if(mat[i][c] == media)
                qt++;

    if(qt>0)
        cout<<"\nElementos iguais a media= "<< qt <<"\n";
    else
        cout<<"\nNao ha elementos iguais a media.";
}
