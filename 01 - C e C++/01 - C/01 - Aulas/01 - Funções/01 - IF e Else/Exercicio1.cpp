#include <iostream>
using namespace std;
main()
{
    setlocale(LC_ALL,"Portuguese");


float presta,salario, resultado;
cout << "Digite o salario bruto: ";
cin >> salario;
cout << "Digite sua prestaçao: ";
cin >> presta;

resultado = salario * 0.30;

if(presta > resultado)
    cout << "seu credito nao foi aprovado";

else
cout << "seu credito foi aprovado";



}
