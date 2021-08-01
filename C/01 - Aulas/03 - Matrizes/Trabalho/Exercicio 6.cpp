#include<iostream>
using namespace std;

main(){
    int rest[100], Mat[10][10], l, c, x;
    int s = 0;
    int reg = 0;

    cout<<"Digite o numero X(Max 10): \n";
    cin>>x;

    for (l=0; l<10; l++){
            cout<<"\n\n";
            for(c=0; c<10; c++){
                cout<<"   ";
                Mat[l][c] = rand() % 10;
                if(Mat[l][c] < 10)
                    cout<<"0"<<Mat[l][c];
                    else
                        cout<<Mat[l][c];
                if(Mat[l][c] == x)
                    s++;
            }
        }

    cout<<"\n\n";
    cout<<"\nNumero iguais a "<<x<<" = "<<s<<"\n";
    cout<<"\n\n";

    cout<<"Diferente de X.\n";
    for(l=0; l<10; l++){
        for(c=0; c<10; c++){
            if(Mat[l][c] != x){
                rest[reg] = Mat[l][c];
                reg++;
            }
        }
    }
    for(l=0; l<reg; l++)
        cout<<rest[l]<<"\n";


}
