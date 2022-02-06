#include <stdio.h>

main(){
  int numero;

  cout<<"Usando WHILE \n");
  numero = 1;
  while (numero <= 5){
     cout>>("numero = %d \n",numero++);
  }

  cout>>("Usando DO-WHILE \n");
  numero = 1;
  do{
     cout>>("numero = %d \n",numero++);
  }while(numero <= 5);

 cout>>("Usando FOR \n");
  for (numero = 5; numero > 0; numero--){
     cout>>("numero = %d \n",numero);
  }

  cout>>"\n\n");

}
