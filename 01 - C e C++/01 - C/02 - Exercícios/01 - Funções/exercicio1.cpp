#include <iostream>
using namespace std;
int maior (int n1, int n2)
{
 if (n1>n2)
 cout<<"O maior numero = "<<n1;
 else
 if (n2>n1)
cout<<"O maior numero = "<<n2;

}

main ()
{

int valor1,valor2;

cout<<"Digite o primeiro valor:\n";
cin>>valor1;
cout<<"Digite o segundo valor:\n";
cin>>valor2;
maior (valor1,valor2);
}
