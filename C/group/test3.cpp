
#include<stdio.h>
#include<stdlib.h>
#include<conio.h>
#include<math.h>

int main()
{
    int element1=1010,element2=0,jiu;

    int result=0;
    int i,j,e1,e2,r1;
    float k,length=4;
    k=pow(10,length-1);
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

    printf("\n%d",result);
    getch();
}
