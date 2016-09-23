#include<stdio.h>
#include<conio.h>
#include<stdlib.h>

main()
{
     int array[100][100];
     int size;
     int i,j=0;
     char result[100],temp;
     printf("Please input the number of element==>  ");
     scanf("%d",&size);
     
     //ask for input
     for(i=0;i<size;i++)
     {
          printf("\nPlease indicate which block elemnt %d belongs to\n==>",i+1);
          fflush(stdin);
          scanf("%c",&temp); 
          
          result[i]=temp;
     }
     
     //print out input
     system("cls");
     printf("Here is 1-D representation==>\n");
     for(i=0;i<size;i++)
     printf("%i\t%c\n",i+1,result[i]);   
     
     
     
     //print input 2d array
     
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
              if(result[i]==result[j])
              printf("%i      ",1);
              else
              printf("%i      ",0);
         }
         
     }

    
        
     getch();
     
}















