public class Solution {
    public void Rotate(int[] nums, int k) {
       int n = nums.Length;
       int[] temp = new int[n];

       for (int i=0 ; i<n;i++){
        temp[(i + k) % n] = nums[i];
       }

       for(int j=0; j< n;j++){
        nums[j] = temp[j];
       }
    }
}