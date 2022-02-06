#include <iostream>
using namespace std;

main()
{
//declarando as variaveis de valores que vai receber 50 numeros, o i é o contador, e a variavel positivo vai ser pros numeros positivos
int valores[50],i,positivo;
// positivo vai receber zero
positivo=0;
cout<<"Digite 50 numeros pra ver os positivos"<<endl;
for (i=0; i<50; i++) {
cin>>valores[i];

// se o numero digitado for maior que zero vai contar como mais um positivo
      if(valores[i]>0)
        positivo++;}

// vai imprimir os numeros positivos.
    cout<<"Total de numeros positivos"<<positivo<<endl;

}

