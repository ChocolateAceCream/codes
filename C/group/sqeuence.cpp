#include<stdio.h>
#include<conio.h>
#include<stdlib.h>


void perm(int array[],int k,int n);

void output (int array[], int n);

main()
{
      int array[10];
      int n = 30,i,k=0;
      for(i=0;i<n;i++)
      {
                      array[i]=i+1;
      }
       output(array,n);
      
      perm(array,k,n) ;
      
      
      getch();
      
}

void perm(int array[],int k,int n)
{
     int i,temp,;
 
     if(k!=n)

     {
          for(i=k;i<n;i++)
          {
               temp=array[k];
               
               array[k]=array[i];
               array[i]=temp;
              output(array,n);
               perm(array,k+1,n);
                temp=array[k];
               
               array[k]=array[i];
               array[i]=temp;
          }
     }
    
   
}

void output (int array[], int n)
{    
     int i;
     for( i=0;i<n;i++)
     printf("%d ",array[i]);
     printf("\n");
    
     
}
