#include <iostream>
using namespace std;

int soma (int n1, int n2)
{
return (n1+n2);
}
int sub(int n1, int n2)
{
return (n1-n2);
}
int mult (int n1, int n2)
{
return (n1*n2);
}


main ()
{
    int valor1, valor2,resp,opc;
    cout<<"Digite valor1 =";
    cin>>valor1;

    cout<<"Digite valor2 =";
    cin>>valor2;

    //CHAMADA SUBPROGRAMA
    cout <<"Digite opcao 1-Soma 2-Subtração 3- Multiplicação:\n";
    cin>>opc;

    if (opc == 1)
    cout<<"Soma ="<<valor1+valor2;

    else if (opc == 2)
    cout<<"sub ="<<valor1+valor2;

    else if (opc ==3)
    cout<<"mult ="<<valor1+valor2;





}


