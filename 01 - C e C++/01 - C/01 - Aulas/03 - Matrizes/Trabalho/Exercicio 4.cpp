#include <iostream>
using namespace std;

main()
{
    int B[10][10], i, j, soma[10];
    int maior = 0;
    cout<<"\n  Matriz";
    for (i=0; i<10; i++){
        cout<<"\n\n";
        soma[i] = 0;
        for(j=0; j<10; j++){
            cout<<"   ";
            B[i][j] = rand() % 10;
            cout<<B[i][j];
            soma[i] += B[i][j];
            if(soma[i]>maior)
                maior = soma[i];
        }
    }

    cout<<"\n\n";
    cout<<maior;
 }
