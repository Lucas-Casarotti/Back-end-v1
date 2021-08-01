#include<iostream>
using namespace std;
#define pula "\n"
int main() {
    float P, A, IMC;

   cout<<("Digite o seu peso:\n");
    cin>>P;

    cout<<("Digite sua altura\n");
    cin>>A;


    IMC = P / (A*A);

    cout<<"O seu IMC:"<<IMC ;


    if(IMC>=40)
    cout<<("\nObesidade morbida, voce precisa malhar");
    else
    if(IMC>=30)
    cout<<("\nObesidade, voce precisa malhar ");
    else
    if(IMC>=25)
        cout<<("\n Voce está sobre peso");
    else
    if(IMC>=20)
        cout<<("\n Voce está com o Pesso normal");
    else
    if(IMC<20)
        cout<<("\nVoce esta abaixo do peso, precisa se alimentar");
























}


