/**
Given a string, you need to reverse the order of characters in each word within a sentence while still preserving whitespace and initial word order.

Example 1:
Input: "Let's take LeetCode contest"
Output: "s'teL ekat edoCteeL tsetnoc"
Note: In the string, each word is separated by single space and there will not be any extra space in the string.
**/
public class Solution {
    public string ReverseWords(string s) {
        var newString = "";
        var tokens = s.Split(' ');
        for(var i = 0; i < tokens.Length; i ++){
            var newWord = true;
            var word = "";
            foreach(char c in tokens[i]){
               if (newWord){
                   word = c + " "+ word;
                   newWord = false;
               } else{
                   word = c +  word;
               }
            }
            newString = newString + word;
        }     
        return newString.Trim();
    }
}