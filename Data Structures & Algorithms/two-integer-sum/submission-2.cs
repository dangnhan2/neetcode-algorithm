public class Solution {
    public int[] TwoSum(int[] nums, int target) {
       Dictionary<int,int> store = new Dictionary<int,int>();
       
       for(int i = 0; i <nums.Length;i++){
        int diff = target - nums[i];
        if(!store.ContainsKey(diff)){
            store[nums[i]] = i;
        }else{
            return new int[] {store[diff], i};
        }
       }

       return new int[] {0,0};
    }
}
