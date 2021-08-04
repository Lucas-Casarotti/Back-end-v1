
#include <iostream>
using namespace std;

main()
{
int mat [3] [3];
int vet [3];
int i, j;
int soma = 0;

for (i = 0; i < 3; i++)
{
for (j = 0; j < 3; j++)
{
cout<<"Digite o valor da posicao: \n";
cin>>mat [i] [j];
}
}
cout<<"\n\n\n";
cout<<("*************  Soma dos valores de cada coluna  ******************* \n\n\n");
for (j = 0; j < 3; j++)
{
for (i = 0; i < 3; i++)
{
    soma = soma + mat [i] [j];
    vet [j] = soma;
}

}
for (i = 0; i < 3; i++)
{
cout<<vet[i];
cout<<"\n";
}

          cout<<("\n\n\n");



 system("pause");
 }
