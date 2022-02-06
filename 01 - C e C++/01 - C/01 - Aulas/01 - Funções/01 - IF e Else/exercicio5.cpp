#include <iostream>
using namespace std;


float re (int &a, int &b){

float area,peri;
area=a;
peri=b;
a = area*peri;
b= 2*(area+peri);



}

main(){
int a,p;

cout<<"Digite o lado do retangulo:";
cin>>a;
cout<<"Digite o segundo lado:";
cin>>p;
re (a,p);

cout<<"A area do retangulo  = "<<a<<endl;
cout<<"O perimetro do retangulo  = "<<p<<endl;



}
