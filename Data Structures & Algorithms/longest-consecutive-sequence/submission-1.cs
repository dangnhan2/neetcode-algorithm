public class Solution {
    public int LongestConsecutive(int[] nums) {
       HashSet<int> store = new HashSet<int>(nums);
       int res = 0;

       foreach (int num in nums){
        if(!store.Contains(num -1)){
            int length = 1;
            while(store.Contains(num + length)){
              length++;
            }
            res = Math.Max(res, length);
        }
       }

       return res;
    }
}
