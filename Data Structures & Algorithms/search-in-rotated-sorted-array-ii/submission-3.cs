public class Solution {
    public bool Search(int[] nums, int target) {
        int r = nums.Length - 1;
        int l = 0;
        while(l <= r){
            
            int m = (r+l)/2;
            if(nums[m] == target){
                return true;
            }

            if (nums[l] < nums[m]){
                if (nums[l] <= target && nums[m] > target){
                    r = m - 1;
                }else{
                    l = m + 1;
                }
            }else if (nums[l] > nums[m]){
                if (nums[r] >= target && nums[m] < target){
                    l = m + 1;
                }else{
                    r = m - 1;
                }
            }else{
                l++;
            }
        }
        return false;
    }
}