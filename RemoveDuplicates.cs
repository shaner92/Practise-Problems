public class Solution {
    public int RemoveDuplicates(int[] nums) {
        IDictionary<int, int> dict = new Dictionary<int, int>();
        for(var i =0; i<nums.Length; i++){
            if (!(dict.ContainsKey(nums[i]))){
                 dict.Add(nums[i], nums[i]);
            }
        }
        
        nums = dict.Keys.ToArray();
        return nums.Length; 
    }
}