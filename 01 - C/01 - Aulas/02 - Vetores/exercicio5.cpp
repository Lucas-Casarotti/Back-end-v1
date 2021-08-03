 #include <iostream>
using namespace std;

main()
{
//declarando as variaveis
int valores[20],i,pares;
pares=0;
cout<<"Digite 20 numeros para poder imprimir os pares"<<endl;

for (i=0; i<20; i++) {

cin>>valores[i];
// um if , se o numero digitado for divido por 2 e o resultado for igual a  zero,conta mais um pro pares
if (valores[i]%2==0)
pares++;}

//vai imprimir os numeros pares
cout<<"O total de numeros pares:\n"<<pares<<endl;

}
