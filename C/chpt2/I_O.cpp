#include <iostream>
using namespace std;
#include<conio.h>
#include <sstream>

int main()
{
   /* int gg;
    cout<< "input gg\n";
    cin >> gg;
    cout<<"gg is "<<gg*2;
    cout <<"\nGGGGG";
    int a,b;
    cin >>a>>b;
    cout<<a<<"\t"<<b;
    string ab;
    cin >> ab;
    cout<<ab;    */
    string line;
    getline(cin,line);
    cout<<line;
    int myint;
    stringstream(line)>>myint;
    cout<<"\n"<<myint;
    
    getch();
    return 0;
}
