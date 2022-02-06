#include <iostream>
using namespace std;
int pot (int x, int y){

 int aux=1;
 for ( int i=1; i<=y; i++){

   aux=aux*x;

}
   return aux;


}
main ()
{ int x,y;
cout<<"Digite x =";
cin>>x;
cout<<"Digite y =";
cin>>y;

cout<<"A potencia = "<<pot (x, y);
}
