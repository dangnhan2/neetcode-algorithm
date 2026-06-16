public class Solution {
    public int FindMin(int[] nums) {
        int res = nums[0];
        for(int i = 1; i < nums.Length; i++){
            if (res > nums[i]){
                res = nums[i];
            }
        }
        return res;
    }
}
