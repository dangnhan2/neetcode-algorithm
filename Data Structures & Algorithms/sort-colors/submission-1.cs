public class Solution {
    public void SortColors(int[] nums) {
      int low = 0;
      int mid = 0;
      int hight = nums.Length - 1;
      while(mid <= hight){
        if(nums[mid] == 0){
            int temp = nums[low];
            nums[low] = nums[mid];
            nums[mid] = temp;
            low++;
            mid++;
        }else if (nums[mid] == 1){
            mid++;
        }else{
            int temp = nums[mid];
            nums[mid] = nums[hight];
            nums[hight] = temp;
            hight--;
        }
      } 
    }
}