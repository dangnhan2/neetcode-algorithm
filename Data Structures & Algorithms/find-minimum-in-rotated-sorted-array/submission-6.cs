public class Solution {
    public int FindMin(int[] nums) {
        int r = nums.Length - 1;
        int l = 0;

        while (l < r){
            int m = (r + l) /2;
            
            if (nums[m] > nums[r]){
                l = m + 1;
            }else{
                r = m;
            }
        }

        return nums[r];
    }
}
