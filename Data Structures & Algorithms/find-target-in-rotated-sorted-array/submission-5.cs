public class Solution {
    public int Search(int[] nums, int target) {
        int res = -1;
        int l = 0;
        int h = nums.Length - 1;
        while(l <= h){
            int m = (l + h) / 2;
            if(nums[m] == target){
                res = m;
                break;
            }

            if(nums[l] < nums[m]){           
                if(target >= nums[l] && target < nums[m]){
                    h = m - 1;
                }else{
                    l = m + 1;
                }
            }else if(nums[l] > nums[m]){
                if(target <= nums[h] && target > nums[m]){
                    l = m + 1;
                }else{
                    h = m - 1;
                }
            }else{
                l++;
            }
        }

        return res;
    }
}
