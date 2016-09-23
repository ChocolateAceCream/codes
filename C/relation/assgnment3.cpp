#include<stdio.h>
#include<conio.h>
#include<stdlib.h>



main()
{
      int n,k,i,j;
      int array[100][100];
      printf("Please enter the value of n==>  ");
      scanf("%d",&n);
      printf("\nPlease enter the value of k==>  ");
      scanf("%d",&k);
      while(k>n)
      {
           system("cls");
           printf("Wrong input");
           printf("\nPlease re-enter the value of n==>  ");
           scanf("%d",&n);
           printf("\nPlease re-enter the value of k==>  ");
           scanf("%d",&k);
      }
      printf("\n%d %d",n,k);
      n++;
      k++;
      for(i=0;i<n;i++)
      {
            for(j=0;j<k;j++)
            {
                  if(i==j)
                  array[i][j] = 1;
      
                  else if(i<j)
                  array[i][j] = -1;
      
                  else if(j==0)
                  array[i][j] = 0;
      
                  else
                  {
                        array[i][j] = j*array[i-1][j]+array[i-1][j-1];
                        
                  }
            }
      }
      //print out result
     
     system("cls");
     printf("\n Here is your 2D input array for n=%d and k=%d==> \n ", n-1,k-1);
     
     for(i=0;i<k;i++)
     {
         printf("%8i",i);
     }
     printf("\n      ");
     for(i=0;i<k;i++)
     {
         printf("________",i);
     }
     for(i=0;i<n;i++)
     {
          printf("\n%-8i",i);
          for(j=0;j<k;j++)
         {
              if(array[i][j]!=-1)
                  printf("%-8i",array[i][j]);
              else
                  printf("N/A     ");
         }
         
     }
      
      getch();
}



















