#include <iostream>
using namespace std;

main ()
{

 int cont, num1, num2, opc;
 cont=1;

 cout <<"Digite um valor 1:\n";
cin>>num1;

cout <<"Digite um valor 2:\n";
cin>>num2;

while (cont <= 3){
cout <<"Digite opcao 1 2 3 4:\n";
cin>>opc;

if (opc == 1)
 cout<<"Soma ="<<num1+num2;

   else if (opc == 2)
     cout<<"sub ="<<num1-num2;

      else if (opc ==3)
         cout<<"mult ="<<num1*num2;


cont++;
}
}
