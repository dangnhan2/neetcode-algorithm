public class Solution {
    public int[] SortArray(int[] nums) {
        int temp = 0;
        for(int i = 0; i< nums.Length - 1; i++){
            for (int j = i + 1; j< nums.Length; j++){
                if(nums[i] > nums[j]){
                    temp = nums[j];
                    nums[j] = nums[i];
                    nums[i] = temp;
                }
            }
        }
        return nums;
    }
}