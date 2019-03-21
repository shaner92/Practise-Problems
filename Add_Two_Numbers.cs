/**
You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.

Example:

Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
Output: 7 -> 0 -> 8
Explanation: 342 + 465 = 807.
**/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var sumL1 = l1.val.ToString();
        var sumL2 = l2.val.ToString();
        
        while (l1 != null && l1.next != null){
            l1 = l1.next;
            sumL1 = l1.val.ToString() + sumL1;
        }
        
       
          while (l2 != null && l2.next != null){
            l2 = l2.next;
            sumL2 = l2.val.ToString() + sumL2;
        }

       var tempSum = (Int64.Parse(sumL1) + Int64.Parse(sumL2)).ToString();
       var sumL3 = "";
        
        foreach(char i in tempSum){
            sumL3 = i + sumL3;
        }
 
       ListNode head = l1;
       var firstNode = true;
        
        foreach(char i in sumL3){
                if (firstNode){
                    l1.val = Int32.Parse(i.ToString());
                    firstNode = false;
                }else{
                    l1.next = new ListNode(Int32.Parse(i.ToString()));
                    l1 = l1.next;
                }
           }
          return head;
        }
    }