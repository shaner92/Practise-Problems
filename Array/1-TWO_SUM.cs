public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] results = new int[2];
        for (int i = 0; i<nums.Length-1;i++){
          for (int j = 1+i; j<nums.Length;j++){
            int sum = nums[i] + nums[j];

            if (sum == target){
               results[0] = i;
               results[1] = j;

            }
        } 
        }
        return results;
    }
}