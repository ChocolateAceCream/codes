#include<stdio.h>
#include<conio.h>
#include<stdlib.h>
#include <math.h>

int fun(int A[],int low,int high);
int max(int a,int b);

main()
{
      
       int A[]= {13,-3,-25,20,-3,-16-5,-22,15,-4,7,-23,20,20,-7,12};
       int result,n;
       n = sizeof(A)/sizeof(A[0]);
       int low =0;
       
       int high = (n-1);
       result = fun (A,low,high);
       
       printf("%i ",result);
       system("pause");
}

int fun(int A[],int low,int high)
{
    
       if(low == high) return A[low];
        if(low == high-1)
            return max(A[low]+A[high], max(A[low], A[high]));
        int mid = (low+high)/2;
        int lmax = fun(A, low, mid-1);
        int rmax = fun(A, mid+1, high);
        int mmax = A[mid];
        int tmp = mmax;
        for(int i = mid-1; i >=low; i--){
            tmp += A[i];
            if(tmp > mmax)  mmax = tmp;
        }
        tmp = mmax;
        for(int i = mid+1; i <= high; i++){
            tmp += A[i];
            if(tmp > mmax)  mmax = tmp;
        }
        return max(mmax, max(lmax, rmax));
        
}
            
int max(int a,int b)
{   
       if (a>b) return a;
       else return b;
}    
       
