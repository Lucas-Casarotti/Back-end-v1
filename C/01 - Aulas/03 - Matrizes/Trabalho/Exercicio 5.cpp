#include<iostream>
#include<locale>
using namespace std;

main(){
    int M[10][10], N[1][10], C[10][10];
    for(int l=0; l<10; l++){
        for(int c=0; c<10; c++){
            M[l][c] = rand()%9;
        }
    }
    cout<<"\n\n\n\n\n\n\n\n\n\n\n\n";
    for(int c=0; c<10; c++){
        N[0][c] = M[1][c];
        M[1][c] = M[7][c];
        M[7][c] = N[0][c];
    }
    for(int l=0; l<10; l++){
        N[0][l] = M[l][3];
        M[l][3] = M[0][l];
        M[l][9] = N[0][l];
    }
    for(int l=0; l<10; l++){
        for(int c=0; c<10; c++){
            C[l][c] = M[l][c];
        }
    }

    //substitui as diagonais
    M[0][9] = C[0][0];
    M[1][8] = C[1][1];
    M[2][7] = C[2][2];
    M[3][6] = C[3][3];
    M[4][5] = C[4][4];
    M[5][4] = C[5][5];
    M[6][3] = C[6][6];
    M[7][2] = C[7][7];
    M[8][1] = C[8][8];
    M[9][0] = C[9][9];
    //
    M[0][0] = C[0][9];
    M[1][1] = C[1][8];
    M[2][2] = C[2][7];
    M[3][3] = C[3][6];
    M[4][4] = C[4][5];
    M[5][5] = C[5][4];
    M[6][6] = C[6][3];
    M[7][7] = C[7][2];
    M[8][8] = C[8][1];
    M[9][9] = C[9][0];
    //
    for(int l=0; l<10; l++){
        N[0][l] = M[4][l];
        M[4][l] = M[l][9];
        M[l][9] = N[0][l];
    }
    for(int l=0; l<10; l++){
            cout<<"\n\n";
        for(int c=0; c<10; c++){
            cout<<" ";
            cout<<M[l][c];
        }
    }

     cout<<"\n\n\n\n\n\n\n\n\n";
}
