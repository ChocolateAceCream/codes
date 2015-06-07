

#include<stdio.h>
#include<conio.h>
#include<stdlib.h>

int check(int i, int E[10][10][10]);
int AcceptCheck(int E[10][10][10], int temp,int i);
int 


main()
{
      int i,j,k,key=-1,temp1,temp2,check1,check2,result;
      int count[10],c2=0;                                   


      int E[10][10][10];  
      for (i=0;i<10;i++)
      {
          for (j=0;j<10;j++)
          {
              for(k=0;k<10;k++)
              {
                E[i][j][k]=key;
                count[k]=key;
              }
          }
      } 
      
      
      int element[]={0,1,2,3,4,5,6,7};
      int Action1[]={0,0,1,4,0,7,5,1};
      int Action2[]={5,3,4,7,2,4,2,4};
      //{2,4,6}
      E[0][0][0]=2;
      E[0][0][1]=4;
      E[0][0][2]=6;
      //{0,1,3,5}
      E[0][1][0]=0;
      E[0][1][1]=1;
      E[0][1][2]=3;
      E[0][1][3]=5;
      E[0][1][4]=7;
      
      count[0] =2;        //# of states for length E0
      i=0;                //current length =E0
      do
      {
           count[i+1]=count[i];
            //current checking for element in Ei
           for(j=0;j<count[i];j++)           //checking for each state, current state is j
           {
              //test for each element in state j
              count[i+1]++;
              temp1=Action1[E[i][j][0]];
              temp2=Action2[E[i][j][0]];
             
              
              check1 = AcceptCheck(E,temp1,i);
              check2 = AcceptCheck(E,temp2,i);
              
    
           
              E[i+1][j][0] = E[i][j][0];       //storing in lenght i+1 
              //check for single element:
              if(E[i][j][1]!=-1)         //skip if theres only one element in state j
              {
           
                   for(k=1;E[i][j][k]!=-1;k++)   
                   {                       
                   
                          temp1=Action1[E[i][j][k]];
                          temp2=Action2[E[i][j][k]];
                          
               /*        printf("##%i##%i##\n ",temp1,temp2);
                          printf("$$%i$$%i$$\n ",AcceptCheck(E,temp1,i),AcceptCheck(E,temp2,i));
                          getch();
                  */    
                          
                          if((check1 == AcceptCheck(E,temp1,i))&&(check2 == AcceptCheck(E,temp2,i)))
                          { 
                                 
                                c2=0;
                                while(E[i+1][j][c2]!=-1) //find the next avaliable place in new state to store 
                                {
                                       c2++;
                                }
                                E[i+1][j][c2] = E[i][j][k];     
                                //if next element in same state as 1st element for both action, store directly                                                               
                          }
                          
                          else
                          {
                                
                                   c2=0;
                                    while(E[i+1][count[i+1]-1][c2]!=-1) //find the next avaliable place in new state to store 
                                    {
                                       c2++;
                                    }
                                    E[i+1][count[i+1]-1][c2] = E[i][j][k];
                                     
                        
                          }

           
                   }    
                   
              }
             if(E[i+1][count[i+1]-1][0]==-1)
             {
                   count[i+1]--;
                                
             }    

           }
           
           i++;
           result=check(i,E);
          
           
      }while(result);
      i=0;
      j=0;
      k=0;
      
      

    for (i=0;E[i][0][0]!=-1;i++)
      {
         printf("length E%i\t \n",i);
          for (j=0;E[i][j][0]!=-1;j++)
          {
              printf("{ ");
              for(k=0;E[i][j][k]!=-1;k++)
              {
                printf("% i ",E[i][j][k]);
               
              }
              printf(" }");
          }
          printf("\n");
      } 
      getch();
}

int AcceptCheck(int E[10][10][10], int temp,int i)   //if temp in acceptp[],return 1, else return 0
{
            
    
    int y,z,result=-1;

          for (y=0;y<10;y++)
          {
              for(z=0;z<10;z++)
              {
                
                  
                  if(temp==E[i][y][z])
                  {
                       result=y;
         
             
                        return result;
                  }
              }
          }
          return result;
    
      
    
}

int check(int i, int E[10][10][10])
{
   int y,z,result=0;

          for (y=0;y<10;y++)
          {
              for(z=0;z<10;z++)
              {
                  if(E[i-1][y][z]!=E[i][y][z])
                  {
                      
                       
                       result=1;
                       return result;
                        
                  }
              }
          }
          return result;
      
}










