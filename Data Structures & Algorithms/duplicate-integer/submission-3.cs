public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> uniqueNum = new HashSet<int>();

        for (int i = 0 ; i < nums.Length; i++){
           uniqueNum.Add(nums[i]);
        }

        return uniqueNum.Count < nums.Length;
   
    }
}