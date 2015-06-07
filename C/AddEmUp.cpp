/*
Check inside the game for instructions on how to play Add 'em Up @
http://www.mathsisfun.com/games/addemup.html

*/




#include<stdio.h>
#include<stdlib.h>
#include<conio.h>
#include<time.h>
#include<math.h>
#include <windows.h>


#define row_of_board 24
#define colume_of_board 24
void setcolor(unsigned short color);
void out_put(int [],int board[][colume_of_board], int, int, int *D );
void get_input(int input[][2], int board[][colume_of_board], int *D);
void check(int queue[], int input[][2], int board[][colume_of_board],int , int , int *D );
int test_get_input(int test_input[][2], int board[][colume_of_board], int row_m, int column_n);
int  test_clean_up(int k, int row_m, int column_n, int board[][row_of_board], 
                   int test_input[][2], int queue[], int *D, int input[][2], int zhu[]);
int main()
{
      srand((unsigned)time(NULL));                                              //set time for random seed
      system("cls");                                                            //clean the screen
      int row_m, column_n, sum, tot;
      int board[row_of_board][colume_of_board];                                 //set an array for board
      int save_board[row_of_board][colume_of_board];                            //save the initial board
      int b[1000],q=0,w=300,e=600;                                              //get 1000 random number and store in array   
      int queue[1000];                                                          //
      char c,ee;                                                              
      int i,j,d,*D,k,l,zt,ii,jj;        
      int zhu[300];                                                             /*store the number of cleaned space 
                                                                                for each test_input*/ 
      int test_input[600][2];                                                   //store all possible input
      int input[600][2];                                                        //use to store user's input                                                          
      char DD,dd;                                                               //store user's choice for play model
      d=0;                                                                      //use to count the number of input
      D=&d;
      for (i=0;i<1000;++i)
      {
        b[i]=rand()%10;
      }                                              
      do
      {
           printf("Do you have an initial board? ==>(Y/N)\t");
           fflush(stdin);
           scanf("%c",&dd);
           system("cls");
      }
      while(dd=='Y'&&dd=='y'&&dd=='n'&&dd=='N');
/*****************read file****************************/    
      if(dd=='Y'||dd=='y')
      {
            FILE *input;
            char filename[13];
            printf(" Please enter a filename (xxxxxxxx.yyy): ");
            scanf("%s", filename);
            if ((input = fopen(filename, "r")) == NULL) 
            {
               printf("\n Filename invalid");
               return -1;
            }
            fscanf(input,"%i",&row_m);
            fscanf(input,"%i",&column_n);
            fscanf(input,"%c",&c);
            for(i=0;i<row_m;i++)                                                      
            {
                  for(j=0;j<column_n;j++)                                              // get random numbers for board
                  {
                      fscanf(input,"%c",&c);    
                      if(c=='x')
                      {
                          board[i][j]=100;
                      }
                      else
                      {
                          board[i][j]=c-48;                          
                      }
                      
                  }
                  fscanf(input,"%c",&c);  
            }
            for(i=0;i<row_m;i++)
            {
                 fscanf(input,"%c",&c);
                 queue[i]=c-48;
            }
            for(i=row_m;i<200;i++,e++)
            queue[i]=b[e];

            
             
      }
/****************fill the board**********************/
      else
      {
            printf("Please input the number of row for the board\n");                 //get input for numbers of row and column
            scanf("%i",&row_m);
            printf("Please input the number of column for the board\n");
            scanf("%i",&column_n);
            for(i=0;i<200;i++)  
            {
                  e++;
                  queue[i]=b[e];                                                       // get random numbers for queue        
            }      
            for(i=0;i<row_m;i++)                                                      
            {
                  for(j=0;j<column_n;j++)                                              // get random numbers for board
                  {
                      w++;
                      if((b[w]-5)>=0)                                                  //check if put a number on board
                      {
                          q++;
                          board[i][j]=b[q];
                      }
                      else
                      {
                          board[i][j]=100;
                      } 
               
                  }  
            }
      }
      do
      {
           printf("\nHumen play or Computer play ==>(H/C)\t");
           fflush(stdin);
           scanf("%c",&DD);
           system("cls");
      }
      while(DD=='H'&&DD=='h'&&DD=='C'&&DD=='c');
      out_put(queue, board, row_m, column_n, D);
/*******copy board**************************************************************/     
       for(ii=0;ii<row_m;ii++)                                                      
         {
              for(jj=0;jj<column_n;jj++)
              {
                   save_board[ii][jj]=board[ii][jj];                    
              }
         }
      

/******************humen play part*******************************************************************/
      if(DD=='H'||DD=='h')
      {
           do
           {  
                   tot=row_m*column_n*100;
                   sum=0;
                   for(i=0;i<row_m;i++)                                                      
                   {
                        for(j=0;j<column_n;j++)                                              
                        {
                             sum=sum+board[i][j];
                        }
                   }
                   printf("\nPress ESC to exit, press any key go on play");
/**********save file*********************/
                   if((ee=getch())==27)
                   {
                        FILE *output;
                        char file[13];
                        printf("\nPlease enter a filename (xxxxxxxx.yyy): ");
                        fflush(stdin); 
                        scanf("%s", file);
                        printf("%s",file);
                        
              
                        if ((output = fopen(file, "w")) == NULL)  
                        {
                              printf("\n No such file, creat the new file");
                        } 
                                         
                        fprintf(output,"%c %c\n",row_m+48,column_n+48);
                        
                        for(i=0;i<row_m;i++)                                                      
                        {
                             for(j=0;j<column_n;j++)                                              // get random numbers for board
                             {
                                     
                                 if(save_board[i][j]==100)
                                 {
                                       fprintf(output,"x");
                                 }
                                 else
                                 {
                                       fprintf(output,"%c",save_board[i][j]+48);                         
                                 }
                                
                              }
                               fprintf(output,"\n");
                        }
                         
                        for(i=0;i<row_m;i++)
                        {
                             fprintf(output,"%c",queue[i]+48);
                        }
                        fprintf(output,"\nSTART\n");
                        for(i=0;i<*D;i++)
                        {
                            fprintf(output,"%c %c %c\n",input[i][0]+64,input[i][1]+64,i+48);
                        }
                        fprintf(output,"END"); 
                        return -1; 
                   }                     
                       
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                   
                   get_input(input, board, D);
                   board[input[*D-1][0]-1][input[*D-1][1]-1]=queue[*D-1];
                   out_put(queue, board, row_m, column_n, D);
                   board[input[*D-1][0]-1][input[*D-1][1]-1]=100;
                   Sleep(3000);
                   check(queue, input, board, row_m, column_n, D);
                   out_put(queue, board, row_m, column_n, D);
           }while(sum!=tot);
           system("cls");            
           setcolor(12);
           printf("\n¨q¨r£ß£ß¨q¨q¨q¨q¨q£ß£ß¨q¨r");
           printf("\n©¦¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡©¦¡¡¡¡¡¡¨q©¤©¤©¤©¤©¤©¤©¤©¤©¤¨r");
           printf("\n©¦¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡©¦¡¡¡¡¡¡©¦GOOD!       ¡¡     ©¦");
           printf("\n©¦¡¡¡ñ  ¨q©¤©¤©¤¨r¡¡¡ñ¡¡©¦¡¡¨q¨r©¦Congratulations !  ©¦");
           printf("\n©¦¡Ô¡¡  ©¦¡ñ¡¡¡ñ ©¦¡¡¡Ô ©¦£Ï¨t¨s¨t©¤©¤©¤©¤©¤©¤©¤©¤©¤¨s");
           printf("\n©¦¡¡¡¡  ¨t©¤©¤©¤¨s¡¡  ¡¡©¦¡¡");
           printf("\n¨t©¤©¤©Ð¡ð©¤©¤©¤©¤©Ð©¤¡ð¨s ");
           setcolor(15);
      }
/***************************copmuter play part********************************************/      
      if(DD=='C'||DD=='c')
      {
           do
           {  
                   tot=row_m*column_n*100;
                   sum=0;
                   for(i=0;i<row_m;i++)                                                      
                   {
                        for(j=0;j<column_n;j++)                                              
                        {
                             sum=sum+board[i][j];
                        }
                   }
                   k=test_get_input(test_input, board, row_m, column_n);        //k store the number of possible input           
                   
                   
                   l=test_clean_up(k, row_m, column_n, board, test_input, 
                                   queue, D, input, zhu);                       //get the best input                                                            
                   input[*D][0]=test_input[l][0];
                   input[*D][1]=test_input[l][1];
                   printf("\nScore: %i",*D);  
                   printf("\ncomputer put %c %c",input[*D][0]+64,input[*D][1]+64);
                   getch();   
                   (*D)++;
  /*********display the input****************/                 
                   board[input[*D-1][0]-1][input[*D-1][1]-1]=queue[*D-1];
                   out_put(queue, board, row_m, column_n, D);
                   board[input[*D-1][0]-1][input[*D-1][1]-1]=100;
                   Sleep(3000);
  /*change the board and output*******/
                   check(queue, input, board, row_m, column_n, D);
                   out_put(queue, board, row_m, column_n, D);               
           }while(sum!=tot);
                   
      }    
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
                   
          system("cls"); 
          setcolor(12);
          printf("\n¨q¨r£ß£ß¨q¨q¨q¨q¨q£ß£ß¨q¨r");
          printf("\n©¦¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡©¦¡¡¡¡¡¡¨q©¤©¤©¤©¤©¤©¤©¤©¤©¤¨r");
          printf("\n©¦¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡¡©¦¡¡¡¡¡¡©¦GOOD!       ¡¡     ©¦");
          printf("\n©¦¡¡¡ñ  ¨q©¤©¤©¤¨r¡¡¡ñ¡¡©¦¡¡¨q¨r©¦Congratulations !  ©¦");
          printf("\n©¦¡Ô¡¡  ©¦¡ñ¡¡¡ñ ©¦ ¡¡¡Ô©¦£Ï¨t¨s¨t©¤©¤©¤©¤©¤©¤©¤©¤©¤¨s");
          printf("\n©¦¡¡¡¡  ¨t©¤©¤©¤¨s¡¡  ¡¡©¦¡¡");
          printf("\n¨t©¤©¤©Ð¡ð©¤©¤©¤©¤©Ð©¤¡ð¨s ");
          setcolor(15);
          getch();
          return 0;
      
}
void out_put(int queue[],int board[][colume_of_board], int row_m, int column_n, int *D)
{
     system("cls");
     int i,j;
     printf("\n       ");
     for(j=0;j<column_n;j++)
     {
         printf("%c|",j+65);
     }
     printf("\n      ");
     for(j=0;j<column_n;j++)
     {                      
         printf("__");
     }
     for(i=0;i<row_m;i++)
     {
         printf("\n%c|     ",i+65);
         for(j=0;j<column_n;j++)                                                //check if there is a number and print out it
         {
             if(board[i][j]==100)
             {                
                 printf(" |");
             }
             else
             {
                 setcolor(1+board[i][j]);
                 printf("%X",board[i][j]);
                 setcolor(15);
                 printf("|");
             }
             setcolor(15);
         }
         printf("      ");
         setcolor(1+queue[*D+i]);
         printf("%X",queue[*D+i]);
         setcolor(15);
         
     }
}
void get_input(int input[][2], int board[][colume_of_board], int *D)
{
      int r,c;
      char o,p;
      
      do
      {
           printf("\nScore: %i",*D);  
           printf("\nEnter the position(row/column), seperated by ' '==>");
           fflush(stdin);
           scanf("%c %c",&o,&p);
           if(o>96)
           o=o-32;
           if(p>96)
           p=p-32;
           r=o-64;
           c=p-64;
      }
      while(board[r-1][c-1]<10);                                                 //check if the position is occupited     
      input[*D][0]=r;
      input[*D][1]=c;       
      (*D)++;
}



         
void check(int queue[], int input[][2], int board[][colume_of_board],int row_m, int column_n, int *D)
{
     int sum,m,n;
     (*D)--;
     row_m--;
     column_n--;
/******************check for 4 corner points *******************/     
     if(input[*D][0]==1&&input[*D][1]==1)                                       //check for (1,1)
     {
          sum= (board[0][1]+board[1][1]+board[1][0])%10;
          if(sum==queue[*D])
          {
              board[0][1]=100;
              board[1][1]=100;
              board[1][0]=100;
              board[0][0]=100;
          }
          else
          {
              board[0][0]=queue[*D];
          }
     }
     else if(input[*D][0]==1&&input[*D][1]==column_n+1)                           // check for (1,n)
     {
          sum= (board[0][column_n-1]+board[1][column_n-1]+board[1][column_n])%10;  
          if(sum==queue[*D])
          {
             board[0][column_n-1]=100;
             board[1][column_n-1]=100;
             board[1][column_n]=100;
             board[0][column_n]=100; 
          }
          else
          {
              board[0][column_n]=queue[*D];
          }
     }
     else if(input[*D][0]==row_m+1&&input[*D][1]==1)                              //check for (m,1)
     {
          sum= (board[row_m][1]+board[row_m-1][1]+board[row_m-1][0])%10;   
          if(sum==queue[*D])
          {
              board[row_m][1]=100;
              board[row_m-1][1]=100;
              board[row_m-1][0]=100;
              board[row_m][0]=100;
          }
          else
          {
              board[row_m][0]=queue[*D];
          }
     }
     else if(input[*D][0]==row_m+1&&input[*D][1]==column_n+1)                       //check for (m,n)
     {
          sum= (board[row_m-1][column_n]+board[row_m-1][column_n-1]+board[row_m-1][column_n])%10; 
          if(sum==queue[*D])
          {
              board[row_m-1][column_n]=100;
              board[row_m-1][column_n-1]=100;
              board[row_m-1][column_n]=100;
              board[row_m][column_n]=100;
          }
          else
          {
              board[row_m][column_n]=queue[*D];
          }
     }
/****check for 4  side lines(without 4 corner points)**************************************************/    
           else if(input[*D][0]==1)                                              //check for top line
           {
               sum=(                        board[0][input[*D][1]-2]+board[0][input[*D][1]]+
                   board[1][input[*D][1]-1]+board[1][input[*D][1]-2]+board[1][input[*D][1]])%10;
               if(sum==queue[*D])
               {
                   board[0][input[*D][1]-1]=100;
                   board[0][input[*D][1]-2]=100;
                   board[0][input[*D][1]]  =100;
                   board[1][input[*D][1]-1]=100;
                   board[1][input[*D][1]-2]=100;
                   board[1][input[*D][1]]=100;
               }
               else
               {
                   board[0][input[*D][1]-1]=queue[*D];
               }              
           }
           else if(input[*D][0]==row_m+1)                                        //check for bottom line
           {
                sum=(board[row_m][input[*D][1]-2]+board[row_m][input[*D][1]]+
                     board[row_m-1][input[*D][1]-1]+board[row_m-1][input[*D][1]-2]+
                     board[row_m-1][input[*D][1]])%10;
                if(sum==queue[*D])
                {
                   board[row_m][input[*D][1]-1]=100;
                   board[row_m][input[*D][1]-2]=100;
                   board[row_m][input[*D][1]]  =100;
                   board[row_m-1][input[*D][1]-1]=100;
                   board[row_m-1][input[*D][1]-2]=100;
                   board[row_m-1][input[*D][1]]=100;
                }
                else
                {
                   board[row_m][input[*D][1]-1]=queue[*D];
                }
           }
           else if(input[*D][1]==1)                                              //check for left line
           {
                sum=(board[input[*D][0]-2][0]+board[input[*D][0]][0]+board[input[*D][0]-1][1]+
                     board[input[*D][0]-2][1]+board[input[*D][0]][1])%10;
                if(sum==queue[*D])
                {
                    board[input[*D][0]-2][0]=100;
                    board[input[*D][0]][0]=100;
                    board[input[*D][0]-1][1]=100;
                    board[input[*D][0]-2][1]=100;
                    board[input[*D][0]][1]=100;
                    board[input[*D][0]-1][0]=100; 
                }
                else
                {
                    board[input[*D][0]-1][0]=queue[*D];
                }                                
           }
           else if(input[*D][1]==column_n+1)                                     //check for right line
           {
                sum=(board[input[*D][0]-2][column_n]+board[input[*D][0]][column_n]+board[input[*D][0]-1][column_n-1]+
                     board[input[*D][0]-2][column_n-1]+board[input[*D][0]][column_n-1])%10;
                if(sum==queue[*D])
                {
                     board[input[*D][0]-2][column_n]=100;
                     board[input[*D][0]][column_n]=100;
                     board[input[*D][0]-1][column_n-1]=100;
                     board[input[*D][0]-2][column_n-1]=100;
                     board[input[*D][0]][column_n-1]=100;
                     board[input[*D][0]-1][column_n]=100;
                }
                else
                {
                     board[input[*D][0]-1][column_n]=queue[*D];
                }
           }                      
/**********check for other points***********************************************/
           else
           {
               sum=(board[input[*D][0]-2][input[*D][1]-1]+board[input[*D][0]][input[*D][1]-1]+
                    board[input[*D][0]-1][input[*D][1]-2]+board[input[*D][0]-1][input[*D][1]]+
                    board[input[*D][0]-2][input[*D][1]-2]+board[input[*D][0]][input[*D][1]]+
                    board[input[*D][0]-2][input[*D][1]]+board[input[*D][0]][input[*D][1]-2])%10;
               if(sum==queue[*D])
               {
                    board[input[*D][0]-2][input[*D][1]-1]=100;
                    board[input[*D][0]][input[*D][1]-1]=100;
                    board[input[*D][0]-1][input[*D][1]-2]=100;
                    board[input[*D][0]-1][input[*D][1]]=100;
                    board[input[*D][0]-2][input[*D][1]-2]=100;
                    board[input[*D][0]][input[*D][1]]=100;
                    board[input[*D][0]-2][input[*D][1]]=100;
                    board[input[*D][0]][input[*D][1]-2]=100;
                    board[input[*D][0]-1][input[*D][1]-1]=100;     
               }
               else
               {
                    board[input[*D][0]-1][input[*D][1]-1]=queue[*D];
               }  
           }   
     (*D)++;   
     row_m++;
     column_n++;  
     
}













int test_get_input(int test_input[][2], int board[][colume_of_board], int row_m, int column_n)
{
     int i,j,k;
     k=0;
     for(i=0;i<row_m;i++)
     {
          for(j=0;j<column_n;j++)
          {
               if(board[i][j]==100)                                             //get all possible input
               {
                   test_input[k][0]=i+1;
                   test_input[k][1]=j+1;
                   k++;
               }
          }
     }   
     return k;
}

















int  test_clean_up(int k, int row_m, int column_n, int board[][row_of_board], 
                   int test_input[][2], int queue[], int *D, int input[][2], int zhu[])
{
     int i,j,qq,max,ii,jj,sum,pp;
     max=0;
     int copy_board[row_of_board][colume_of_board]; 
     
     for(i=0;i<k;i++)
     zhu[i]=0;
    
     for(i=0;i<k;i++)
     {
         pp=0;
         for(ii=0;ii<row_m;ii++)                                                       //copy board
         {
              for(jj=0;jj<column_n;jj++)
              {
                   copy_board[ii][jj]=board[ii][jj];                    
              }
         }

/**********************************check for 4 corner points ***************************/     
          if(test_input[i][0]==1&&test_input[i][1]==1)                                       //check for (1,1)
          {
                sum= (copy_board[0][1]+copy_board[1][1]+copy_board[1][0])%10;
                if(sum==queue[*D])
                {
                      copy_board[0][1]=100;
                      copy_board[1][1]=100;
                      copy_board[1][0]=100;
                }
                
                
          }
          else if(test_input[i][0]==1&&test_input[i][1]==column_n)                           // check for (1,n)
          {
                sum= (copy_board[0][column_n-2]+copy_board[1][column_n-2]+copy_board[1][column_n-1])%10;  
                if(sum==queue[*D])
                {
                      copy_board[0][column_n-2]=100;
                      copy_board[1][column_n-2]=100;
                      copy_board[1][column_n-1]=100;
                }
          }
          else if(test_input[i][0]==row_m&&test_input[i][1]==1)                              //check for (m,1)
          {
                sum= (copy_board[row_m-1][1]+copy_board[row_m-2][1]+copy_board[row_m-2][0])%10;   
                if(sum==queue[*D])
                {
                      copy_board[row_m-1][1]=100;
                      copy_board[row_m-2][1]=100;
                      copy_board[row_m-2][0]=100;
                }
          }
          else if(test_input[i][0]==row_m&&test_input[i][1]==column_n)                       //check for (m,n)
          {
                sum= (copy_board[row_m-2][column_n-1]+copy_board[row_m-2][column_n-2]+copy_board[row_m-1][column_n-2])%10; 
                if(sum==queue[*D])
                {
                      copy_board[row_m-2][column_n-1]=100;
                      copy_board[row_m-2][column_n-2]=100;
                      copy_board[row_m-1][column_n-2]=100;
                }
          }
/****check for 4  side lines(without 4 corner points)**************************************************/    
           else if(test_input[i][0]==1)                                              //check for top line
           {
               sum=(copy_board[0][test_input[i][1]-2]+copy_board[0][test_input[i][1]]+
                   copy_board[1][test_input[i][1]-1]+copy_board[1][test_input[i][1]-2]+
                   copy_board[1][test_input[i][1]])%10;
               if(sum==queue[*D])
               {
                   copy_board[0][test_input[i][1]-2]=100;
                   copy_board[0][test_input[i][1]]  =100;
                   copy_board[1][test_input[i][1]-1]=100;
                   copy_board[1][test_input[i][1]-2]=100;
                   copy_board[1][test_input[i][1]]=100;
               }     
           }
           else if(test_input[i][0]==row_m)                                        //check for bottom line
           {
                sum=(copy_board[row_m-1][test_input[i][1]-2]+copy_board[row_m-1][test_input[i][1]]+
                     copy_board[row_m-2][test_input[i][1]-1]+copy_board[row_m-2][test_input[i][1]-2]+
                     copy_board[row_m-2][test_input[i][1]])%10;
                if(sum==queue[*D])
                {
                   copy_board[row_m-1][test_input[i][1]-2]=100;
                   copy_board[row_m-1][test_input[i][1]]=100;
                   copy_board[row_m-2][test_input[i][1]-1]  =100;
                   copy_board[row_m-2][test_input[i][1]-2]=100;
                   copy_board[row_m-2][test_input[i][1]]=100;
                }
           }
           else if(test_input[i][1]==1)                                              //check for left line
           {
                sum=(copy_board[test_input[i][0]-2][0]+copy_board[test_input[i][0]][0]+
                     copy_board[test_input[i][0]-1][1]+copy_board[test_input[i][0]-2][1]+
                     copy_board[test_input[i][0]][1])%10;
                if(sum==queue[*D])
                {
                    copy_board[test_input[i][0]-2][0]=100;
                    copy_board[test_input[i][0]][0]=100;
                    copy_board[test_input[i][0]-1][1]=100;
                    copy_board[test_input[i][0]-2][1]=100;
                    copy_board[test_input[i][0]][1]=100;
                }              
           }
           else if(test_input[i][1]==column_n)                                     //check for right line
           {
                sum=(copy_board[test_input[i][0]-2][column_n-1]+copy_board[test_input[i][0]][column_n-1]+
                     copy_board[test_input[i][0]-1][column_n-2]+copy_board[test_input[i][0]-2][column_n-2]+
                     copy_board[test_input[i][0]][column_n-2])%10;
                if(sum==queue[*D])
                {
                     copy_board[test_input[i][0]-2][column_n-1]=100;
                     copy_board[test_input[i][0]][column_n-1]=100;
                     copy_board[test_input[i][0]-1][column_n-2]=100;
                     copy_board[test_input[i][0]-1][column_n-2]=100;
                     copy_board[test_input[i][0]][column_n-2]=100;
                }
           }                      
/**********check for other points***********************************************/
           else
           {
               sum=(copy_board[test_input[i][0]-2][test_input[i][1]-1]+copy_board[test_input[i][0]][test_input[i][1]-1]+
                    copy_board[test_input[i][0]-1][test_input[i][1]-2]+copy_board[test_input[i][0]-1][test_input[i][1]]+
                    copy_board[test_input[i][0]-2][test_input[i][1]-2]+copy_board[test_input[i][0]][test_input[i][1]]+
                    copy_board[test_input[i][0]-2][test_input[i][1]]+copy_board[test_input[i][0]][test_input[i][1]-2])%10;
               if(sum==queue[*D])
               {
                    copy_board[test_input[i][0]-2][test_input[i][1]-1]=100;
                    copy_board[test_input[i][0]][test_input[i][1]-1]=100;
                    copy_board[test_input[i][0]-1][test_input[i][1]-2]=100;
                    copy_board[test_input[i][0]-1][test_input[i][1]]=100;
                    copy_board[test_input[i][0]-2][test_input[i][1]-2]=100;
                    copy_board[test_input[i][0]][test_input[i][1]]=100;
                    copy_board[test_input[i][0]-2][test_input[i][1]]=100;
                    copy_board[test_input[i][0]][test_input[i][1]-2]=100;
                    copy_board[test_input[i][0]-1][test_input[i][1]-1]=100;     
               }
           }
            
           for(ii=0;ii<row_m;ii++)
           {
               for(jj=0;jj<column_n;jj++)
               {
    
                    if(copy_board[ii][jj]!=board[ii][jj])
                    pp++;
                   
               }
           }
           zhu[i]=pp;

      }
      for(i=0;i<k;i++)     
     
/******************find max number in zhu[i]**************************************/     
      for(i=0;i<k;i++)
      {
           if(zhu[i]>=max)  
           {
               max=zhu[i];
               qq=i;
           }
      }
   
      return qq;
}

void setcolor(unsigned short color)                                             //change colour                                                      
{
HANDLE hCon = GetStdHandle(STD_OUTPUT_HANDLE);
SetConsoleTextAttribute(hCon,color);
}











