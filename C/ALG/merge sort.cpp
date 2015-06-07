#include<stdio.h>
#include<conio.h>
#include<stdlib.h>

void fun(int A[],int n);  

main()
{
      int A[]= {50,35,42,32,31,27,15,4};
      int B[100],C[100],D[100];
      
      int i,key,j,l,n,p,q;

      n = sizeof(A)/sizeof(A[0]);
      p=n/2;
      q=n-p;
      for(i=0;i<p;i++)
      {
          B[i]=A[i];
          printf("%i ",B[i]);
      }
      printf("\n");
       for(i=p;i<n;i++)
      {
          C[i-p]=A[i];
           printf("%i ",C[i-p]);
      }
      printf("\n");
     
     fun(B,p);
      B[p]=100;
     fflush(stdin);
      fun(C,q);
      C[q]=100;
      j=0;
      l=0;
      printf("\n");
      for (i=0;i<n;i++)
      {
          if (B[j]<=C[l])
          {
             D[i]=B[j];
             j++;
          }
          else 
          {
             D[i]=C[l];
             l++;
          }
      
      
          printf("%i ",D[i]);
      }
      system("pause");
}

void fun(int A[],int n)
{
      int i,key,j,l,z;
    
      
      for(j=0;j<n;j++)
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
