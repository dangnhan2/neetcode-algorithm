public class Solution {
    public int LongestConsecutive(int[] nums) {
      int res = 0;
      HashSet<int> store = new HashSet<int>(nums);

      for(int i = 0; i< nums.Length; i++){
        int count = 1;
        while(store.Contains(nums[i] + count)){        
           count++;           
        }
        res = Math.Max(res, count);
      }
      return res;
    }
}
