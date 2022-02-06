#include<iostream>
using namespace std;




main()
{

setlocale(LC_ALL,"Portuguese");

int idade;
cout<<"Digite a sua idade:\n";
cin>>idade;



if (idade >=65)
    cout<<"Você e uma pessoa Idosa";
else
    if (idade >=18)
        cout<<"Maior de idade";
else
    if (idade <18)
        cout<<"Menor de idade";







}
