public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] store = new int[nums.Length];

        for(int i = 0; i< nums.Length; i++){
            int product = 1;
            for(int j = 0; j < nums.Length; j++){
               if (i != j){
                  product *= nums[j];
               }
               
            }

            store[i] = product;
        }

        return store;
    }
}
