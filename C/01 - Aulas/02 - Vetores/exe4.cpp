#include <iostream>
using namespace std;

main()
{
    //declarando os vetores F e G
int F[20],G[20],resultado,i;
cout<<"Digite os valores do vetor F"<<endl;
for (i=0; i<20; i++) {
    // os valores digitados de F vai ser armazenados no cin>>F[i]
   cin>>F[i];
}
cout<<"Digite os valores do vetor G"<<endl;
for(i=0; i<20; i++) {
    // os valores digitados de G vai ser armazenados no cin>>G[i]
cin>>G[i];
}
for(i=0; i<20; i++) {
    {
        // A variavel resultado vai imprimir os numeros digitados de F * os numeros digitados de G
        resultado=F[i]*G[i];
        cout<<"Resultado"<<resultado<<endl;
    }
}
}

