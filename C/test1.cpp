#include<stdio.h>
#include "genlib.h"
#include<stdlib.h>
#include<math.h>
main()
{
      int i,j,queue[100],ee,gg;

      for(i=0;i<8;i++)
            {
                  queue[i]=0;
                  for(j=3;j>0;j--)
                  {
                     gg=pow(2,j-1);
                     printf("\n**%i",gg);
                     system("pause");
                     if((i/(pow(2,j-1))>0)
                                 { ee=1;}
                                  else
                                  ee=0;
                                  printf("\t%i",ee);
                  queue[i] = queue[i]+(10^(j-1))*ee;
                  }
                  printf("\n**%i",queue[i]);
            }

 
      system("pause");
}

