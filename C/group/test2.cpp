
#include<stdio.h>
#include<stdlib.h>
#include<conio.h>
#include<math.h>

int operation(int element1,int element2,int length);
int associative(int [],int IM,int length);
int identy(int [],int IM,int length);
int inverse(int [],int IM,int ID,int length);

int main()
{
    char dd,bb;
 
    int IM,ii=0,i=0,result,length,ee;
    int queue[100];
    int asso,ID,IV;
          
          
          printf("\nPlease enter the length of binary code ==> ");
          scanf("%i",&length);
          printf("\nPlease enter your element one by one, end by '#'\n");
          while(1)
          {
                   fflush(stdin);
                   scanf("%d",&ee);
                   if ((bb = getchar()) =='#') 
                   break;
                   else
                   {
                       
                       queue[ii] = ee;
                       
                       
                       ii++;
                       
                   }
          }
          IM = ii;
      
      
 
      
      //Associative proof
      if(IM<3)
      asso = 1;
      else
      asso= associative(queue,IM,length);  
      if(asso = 1)
      {
      
              
              printf("\nThis set satisfied the associative condition");
      //finding indentity         
              ID = identy(queue,IM,length);
              if(ID!=100)
              {
                     printf("\nThe identity element is %i",ID);
                     
      //inverse proof
                     IV = inverse(queue,IM,ID,length);
                   
                     if(IV==1)
                     printf("\nThis set satisfied the inverse condition, therefore this set is a group");
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

int operation(int element1,int element2,int length)
{
    

    int result=0;
    int i,j,e1,e2,r1,jiu;
    float k,leng=length;
    k=pow(10,leng-1);
    jiu=(int)k;

    for(i=0;i<length;i++)
    {          
          e1= (element1)/jiu;
          e2= (element2)/jiu;
          element1=(element1)%jiu;
          element2=(element2)%jiu;          
          r1 = (e1||e2)&&((!e1)||(!e2));         
          result = result+r1*jiu;          
          jiu=jiu/10;              
    }

    return result;
}

int associative(int queue[],int IM,int length)
{
    int i,j,k,result1,result2;
    
    for (i=0;i<IM-2;i++)
    {
          for(j=i+1;j<IM-1;j++)
          {
                for(k=j+1;k<IM;k++)
                {
                       result1= operation(operation(queue[i],queue[j],length),queue[k],length);
                       result2= operation(operation(queue[j],queue[k],length),queue[i],length);
                       if(result1 != result2)        
                       return 0;
                       
                }
          }                   
        
    }
     
     return 1;
}

int identy(int queue[],int IM,int length)
{
     int i,j,k,result1,result2,ID;
     
     for(i=0;i<IM;i++)
     {
        ID = queue[i];
        k = 0;
        
        for(j=0;j<IM;j++)
        {
          result1 = operation(ID,queue[j],length);
       
              
          
          result2 = operation(queue[j],ID,length);
   
      
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

int inverse(int queue[],int IM,int ID,int length)
{
    int i,j,k=0,result1;
    for(i=0;i<IM;i++)
    {
         
         for(j=0;j<IM;j++)
        {
            result1 = operation(queue[i],queue[j],length);
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









