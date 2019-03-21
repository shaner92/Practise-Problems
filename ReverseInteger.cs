/**
Given a 32-bit signed integer, reverse digits of an integer.

Example 1:

Input: 123
Output: 321
Example 2:

Input: -123
Output: -321
Example 3:

Input: 120
Output: 21
Note:
Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [−231,  231 − 1]. 
For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.
**/
public class Solution {
    public int Reverse(int x) {
        try {
			var newInt;;
			int val;
			var isNegative = false;
			var intString = Math.Abs(x).ToString();
			
			if (x < 0){
				isNegative = true;    
			}
			
			foreach(char i in intString){
				newInt = i + newInt;
			}
			
		   if (!Int32.TryParse(newInt,out val)){
			   return 0;
		   }else if(isNegative){
			   return -Int32.Parse(newInt);
			}else{
				return Int32.Parse(newInt);
			}    
      
        }catch{
            return 0;
        }
       }
}