public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int n = nums.Length * 2;
        int[] ans = new int[n];
        for (int i = 0; i < nums.Length; i++){
           ans[i] = ans[i + nums.Length] = nums[i];
        }

        return ans;
    }
}