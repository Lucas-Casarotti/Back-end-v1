#include <stdio.h>
#include <iostream>
using namespace std;
main()
{
    int t, i, A[3][3], T[3][3],;

    for (t=0; t<3; t++){
      cout<<"\n";
     for (i=0; i<3; i++){
       A[t][i] = rand() % 10;
       cout<<A[t][i]<<" ";
    }
    }
cout<<"\n"<<"\n";
     for (t=0; t<3; t++){
            cout<<"\n";
     for (i=0; i<3; i++){
       T[t][i] = A[i][t];
       cout<<T[t][i]<<" ";
    }
    }


}
