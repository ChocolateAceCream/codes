
#include<stdio.h>
#include<stdlib.h>
#include<conio.h>

int operation(int element1,int element2,int IM);
int associative(int [],int IM);
int identy(int [],int IM);
int inverse(int [],int IM,int ID);

int main()
{
    char dd,bb;
 
    int IM,ii=0,i=0,result,ee;
    int queue[100];
    int asso,ID,IV;
      do
      {
           printf("Do you have an initial set? ==>(Y/N)\t");
           fflush(stdin);
           scanf("%c",&dd);
           system("cls");
      }while(!((dd=='Y')||(dd=='y')||(dd=='n')||(dd=='N')));
      
      if(dd == 'Y' ||dd =='y')
      {
            system("cls");
            printf("Please enter the number of interger module==> ");
            scanf("%i",&IM);
     
            for(i=0;i<IM;i++)
            {
                  queue[i] = i;
            }
      }
      
      else
      {
          printf("\nPlease enter your element one by one, end by '#'\n");
          while(1)
          {
                   fflush(stdin);
                   scanf("%i",&ee);
                   if ((bb = getchar()) =='#') 
                   break;
                   else
                   {
                       
                       queue[ii] = ee;
                       
                       
                       ii++;
                       
                   }
          }
          IM = ii;
      }
      
      result = operation(queue[0],queue[1],IM);
      
      //Associative proof
      if(IM<3)
      asso = 1;
      else
      asso= associative(queue,IM);  
      if(asso = 1)
      {
      
              
              printf("\nThis set satisfied the associative condition");
      //finding indentity         
              ID = identy(queue,IM);
              if(ID!=100)
              {
                     printf("\nThe identity element is %i",ID);
                     
      //inverse proof
                     IV = inverse(queue,IM,ID);
                   
                     if(IV==1)
                     printf("This set satisfied the inverse condition, therefore this set is a group");
                     else
                     printf("\nThis set did not satisfy the inverse conditionis,therefore it is not a group");
              
              }
              else
              printf("\nThis set did not have an identity element,therefore it is not a group");
      }
      else
      printf("\nThis set did not satisfy the associative conditionis,therefore it is not a group");
     


      getch();
}

int operation(int element1,int element2,int IM)
{
    int result;
    result = (element1+element2)%IM;
    return result;
}

int associative(int queue[],int IM)
{
    int i,j,k,result1,result2;
    
    for (i=0;i<IM-2;i++)
    {
          for(j=i+1;j<IM-1;j++)
          {
                for(k=j+1;k<IM;k++)
                {
                       result1= operation(operation(queue[i],queue[j],IM),queue[k],IM);
                       result2= operation(operation(queue[j],queue[k],IM),queue[i],IM);
                       if(result1 != result2)        
                       return 0;
                       
                }
          }                   
        
    }
     
     return 1;
}

int identy(int queue[],int IM)
{
     int i,j,k,result1,result2,ID;
     
     for(i=0;i<IM;i++)
     {
        ID = queue[i];
        k = 0;
        
        for(j=0;j<IM;j++)
        {
          result1 = operation(ID,queue[j],IM);
          result2 = operation(queue[j],ID,IM);
          if ((result1 == result2)&&(result2 == queue[j]))
          {
               k++;
                
          }
          
        }
        if(k ==IM)
        {
             return ID;
            
        }
           
     }
     return 100;
}

int inverse(int queue[],int IM,int ID)
{
    int i,j,k=0,result1;
    for(i=0;i<IM;i++)
    {
         
         for(j=0;j<IM;j++)
        {
            result1 = operation(queue[i],queue[j],IM);
            if (result1==ID)
            {
                 k++;
                 break;
            }
        }
    }
    if (k=IM)
    return 1;
    else
    return 0;
    
}









