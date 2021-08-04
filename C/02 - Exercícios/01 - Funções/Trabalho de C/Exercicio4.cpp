#include<iostream>
using namespace std;




int main()

{
    setlocale(LC_ALL,"Portuguese");
    int Idade=0;

    cout<<"Digite idade para saber se é necessario ir votar:\n";
    cin>>Idade;

    if(Idade<16)
        cout<<("Não eleitor, ainda não pode votar");
    else{
    if(Idade < 18)
        cout<<("Eleitor, você não precisa votar");

    else
    if(Idade<=64)
        cout<<("Eleitor, você precisa votar");


    else
    if(Idade>=65)
    cout<<("Eleitor facultativo\n");


    }








}
