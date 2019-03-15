/**
Write a function that reverses a string. The input string is given as an array of characters char[].

Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.

You may assume all the characters consist of printable ascii characters.

 

Example 1:

Input: ["h","e","l","l","o"]
Output: ["o","l","l","e","h"]
Example 2:

Input: ["H","a","n","n","a","h"]
Output: ["h","a","n","n","a","H"]

**/

public class Solution {
    public void ReverseString(char[] s) {
        var sLength = s.Length-1;
        var j = 0;
        var i = s.Length - 1;
       if (s.Length > 0){
        for(j=0; j< sLength/2 + 1; j++){
            var temp = s[j];
            s[j] = s[i];
            s[i] = temp;
            i = i - 1;
        }
       }
       
    }
}