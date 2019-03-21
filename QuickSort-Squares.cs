/**
Given an array of integers A sorted in non-decreasing order, return an array of the squares of each number, also in sorted non-decreasing order.

Example 1:

Input: [-4,-1,0,3,10]
Output: [0,1,9,16,100]
Example 2:

Input: [-7,-3,2,3,11]
Output: [4,9,9,49,121]
 

Note:

1 <= A.length <= 10000
-10000 <= A[i] <= 10000
A is sorted in non-decreasing order.

**/
public class Solution {
    public int[] SortedSquares(int[] A) {
        for(var i = 0; i<A.Length; i++){
           A[i] = A[i] * A[i];
        }
        return quicksort(A,0, A.Length-1);
    }
    public int[] quicksort(int[] A, int lo, int hi){
        if(lo < hi){
            var p = partition(A, lo, hi);
                quicksort(A, lo, p - 1);
                quicksort(A, p+1, hi);
        }
        return A;
    }
    public int partition(int[] A, int lo, int hi){
        var pivot = A[hi];
        var i = lo;
        for(var j = lo; j < hi; j++){
            if(A[j] <= pivot){
                var temp = A[i];
                A[i] = A[j];
                A[j] = temp;
                i = i + 1;
            }
        }
        var temp2 = A[i];
        A[i] = A[hi];
        A[hi] = temp2;
        return i;
    }
}