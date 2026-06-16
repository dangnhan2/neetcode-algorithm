public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int l =0;
        int h = nums.Length - 1;
        int index = nums.Length;
        while(l <= h){
            int m = l + (h-l)/2;
            if(nums[m] == target) return m;
            if(nums[m] > target){
               h = m-1;
               index = m;
            } 
            else{
              l = m + 1;
            }
        }
        return index;
    }
}