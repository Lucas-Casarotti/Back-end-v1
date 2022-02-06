#include <iostream>
using namespace std;

void operac (int n1, int n2, int op)
{
 if (op==1)
 cout<<"A soma ="<<n1+n2<endl;
 else
 if (op==2)
 cout<<"A sub ="<<n1+n2<endl;

 if (op==3)
 cout<<"A multiplic ="<endl;
}



main ()
{
    int valor1, valor2,opc;
    cout<<"Digite valor1 =";
    cin>>valor1;

    cout<<"Digite valor2 =";
    cin>>valor2;

    //CHAMADA SUBPROGRAMA
    cout <<"Digite opcao 1-Soma 2-Subtração 3- Multiplicação:\n";
    cin>>opc;

   operac (valor1,valor2,opc)





}


