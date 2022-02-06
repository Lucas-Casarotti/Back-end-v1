#include<iostream>
using namespace std;

main(){
    int M = 3;
    int N = 3;
    int i, c, A[M][N], B[M][N], C[M][N];

    cout << "Preenchendo matriz A.\n";
    for(int i=0; i<3; i++)
        for(int c=0; c<3; c++){
                cout << "Matriz A=[" <<i<< "]" << "[" <<c<< "]:";
                cin>>A[i][c];
        }
    cout << "\nPreenchendo matriz B.\n";
    for(int i=0; i<3; i++)
        for(int c=0; c<3; c++){
                cout << "Matriz B=[" <<i<< "]" << "[" <<c<< "]:";
                cin>>B[i][c];
        }

    for(int i=0; i<3; i++)
        for(int c=0; c<3; c++){
                C[i][c] = A[i][c] + B[i][c];
        }

    cout << "\nResultado da soma das Matrizes A e B.";
    for(int i=0; i<3; i++)
        for(int c=0; c<3; c++){
                cout << "\nMatriz C=[" <<i<< "]" << "[" <<c<< "]:";
                cout <<  C[i][c];
        }
}
