public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
       Dictionary<int, int> s = new Dictionary<int,int>();

       for(int i = 0; i < nums.Length; i++){   
        if(s.ContainsKey(nums[i]) && Math.Abs(s[nums[i]] - i) <= k){
           return true;
        }

        s[nums[i]] = i;
       }

       return false;
    }
}