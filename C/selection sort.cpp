#include<stdio.h>
#include<conio.h>
#include<stdlib.h>

main()
{
      int A[6]= {32,23,16,14,13,8};
      int i,key,j,l,z;
    
      
      for(j=0;j<6;j++)
      {
                      key = A[j];
       for(i =j+1;i<6;i++)
       {
           if (A[i]<key)
           {
           key = A[i];
            l=i;
           }
           
      
       }
       z= A[j];
       
      A[j]=key;
      A[l]=z;
      printf("%i ",A[j]);
      
      }
     
      system("pause");
}
