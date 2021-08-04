#include <iostream>
using namespace std;


void soma (int n1, int n2)
{
cout<<"Soma ="<<n1+n2;
}


main ()
{
    int valor1, valor2;
    cout<<"Digite valor1 =";
    cin>>valor1;

    cout<<"Digite valor2 =";
    cin>>valor2;

    //CHAMADA SUBPROGRAMA

    soma(valor1, valor2);

}
