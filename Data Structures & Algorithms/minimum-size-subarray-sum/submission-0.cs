public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int res = int.MaxValue;
        for (int l = 0; l < nums.Length; l++) {
            int sum = 0;
            for (int r = l; r < nums.Length; r++) {
                sum = sum + nums[r];

                if (sum >= target){
                    res = Math.Min(res, r - l + 1);
                    break;
                }
            }
        }

        return res == int.MaxValue ? 0 : res;
    }
}