
#include<stdio.h>
#include<conio.h>
#include<stdlib.h>


#include <string>




typedef struct
{
        string name;
        string title;
        string ssnum;
        double salary;
        int withholding;
}employeeRecordT;


main()
{
      employeeRecordT empRec ;
      empRec.name = "GG simida";
      empRec.title = "FFKKY";
      empRec.salary = 14.42;
      employeeRecordT *empPtr;

      
      empPtr = &empRec;

      empPtr->salary = 15.52;
      
      
      printf("%f",empRec.salary);
      
      getch();
}
