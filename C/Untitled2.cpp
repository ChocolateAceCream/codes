class Solution {
public:
    int divide(int A[], int low, int high){
        if(low == high) return A[low];
        if(low == high-1)
            return max(A[low]+A[high], max(A[low], A[high]));
        int mid = (low+high)/2;
        int lmax = divide(A, low, mid-1);
        int rmax = divide(A, mid+1, high);
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
    int maxSubArray(int A[], int n) {
        // Note: The Solution object is instantiated only once and is reused by each test case.
        return divide(A, 0, n-1);
    }
    
};
