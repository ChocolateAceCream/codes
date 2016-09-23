#include<stdio.h>
#include<conio.h>
#include<stdlib.h>

main()
{
     int array[100][100];
     int size,temp,count;
     int i,j=0;
     char result[100];
     printf("Please input the size of E-relation==>  ");
     scanf("%d",&size);
     
     //ask for input
     for(i=0;i<size;i++)
     {
         while (j<i)
         {
               array[i][j]=array[j][i];
               j++;
         }
         for(j=i;j<size;j++)
         {
              printf("\nPlease input relation %i R %i (1 for yes 0 for not)=>  ",i+1,j+1);
              scanf("%d",&temp);
              while((temp!=0)&&(temp!=1))
              {
                  printf("\nWrong input, re-enter==> ");
                  scanf("%d",&temp);
              }
              array[i][j] = temp;
              array[j][i]=temp;
              
         }
     }
     //print input 2d array
     system("cls");
     printf("\n Here is your 2D input array==> \n ");
     
     for(i=0;i<size;i++)
     {
         printf("      %i",i+1);
     }
     printf("\n      ");
     for(i=0;i<size;i++)
     {
         printf("______",i+1);
     }
     for(i=0;i<size;i++)
     {
          printf("\n%i      ",i+1);
          for(j=0;j<size;j++)
         {
              printf("%i      ",array[i][j]);
         }
         
     }
     //check
     count = 65;
     for(i=0;i<size;i++)
     {
        if(array[i][0]>1)
        {
             i++;
        }
        else
        {   
           for(j=i;j<size;j++)
           {
               if(array[i][j]==1)
               {
                     result[i]=count;
                     result[j]=count;
                     array[j][0]=count;
                  
                     
               }
               
           }
           count++;
        }  
     }
        
     printf("\n\n Here is 1-D representation==>\n");
     for(i=0;i<size;i++)
     printf("%i\t%c\n",i+1,result[i]);   
     
    
        
     getch();
     
}















