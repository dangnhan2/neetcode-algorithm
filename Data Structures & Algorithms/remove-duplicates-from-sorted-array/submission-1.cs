public class Solution {
    public int RemoveDuplicates(int[] nums) {
      int r = 1;
      for(int l = 1; l < nums.Length; l++){
        if (nums[l] != nums[l - 1]){
           nums[r] = nums[l];
           r++;
        }
      }

      return r;
    }
}