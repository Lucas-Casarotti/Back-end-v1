#include<iostream>
#include<locale>
using namespace std;

void cal (float &a, float &b)
{
    int a1, a2;
    a1=a;
    a2=b;

    a=a1*a2;
    b=2*(a1+a2);
    if(a1==a2)
    cout<<"1\n";
    else
    cout<<"0\n";
}

main()
{

    setlocale(LC_ALL,"Portuguese");

    float n1,n2;
    cout<<"Digite a Base:";
    cin>>n1;
    cout<<"Digite a Altura:";
    cin>>n2;

    cal(n1, n2);

    cout<<"area  = " <<n1<<"\n";
    cout<<"Perimetro  = " <<n2<<"\n";


}
