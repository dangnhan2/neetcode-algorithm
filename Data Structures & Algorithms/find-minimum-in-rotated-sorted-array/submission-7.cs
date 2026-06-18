public class Solution {
    public int FindMin(int[] nums) {
       int min = nums[0];
       for(int i = 1; i < nums.Length; i++){
        if (min > nums[i]){
          min = nums[i];
        }
       }
       return min;
    }
}
