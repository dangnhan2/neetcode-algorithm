public class Solution {
    public int FindDuplicate(int[] nums) {
        int res = 0;
        Dictionary<int, int> store = new Dictionary<int,int>();
        for(int i = 0; i < nums.Length; i++){
            if(!store.ContainsKey(nums[i])){
                store[nums[i]] = 0;
            }else{
               res = nums[i];
               break;
            }

            store[nums[i]]++;
        }

        return res;
    }
}
