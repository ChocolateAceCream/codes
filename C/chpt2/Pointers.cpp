

#include<stdio.h>
#include<conio.h>
#include<stdlib.h>
#include<math.h>

void GetCoefficients(double *pa,double *pb, double *pc);
void solve(double a, double b, double c, double *px1,double *px2);
main()
{
      double a,b,c,x1,x2;
      GetCoefficients(&a,&b,&c);
      solve(a,b,c,&x1,&x2);
      printf("%g %g",x1,x2);
      getch();
}

void GetCoefficients(double *pa,double *pb, double *pc)
{
    
     *pa = 1.111;
     *pb = -12.222;
     *pc = 3.333;
     
}
void solve(double a, double b, double c, double *px1,double *px2)
{
     *px1 = (-b+sqrt(b*b-4*a*c))/2/a;
     *px2 = (-b-sqrt(b*b-4*a*c))/2/a;
     
}    
