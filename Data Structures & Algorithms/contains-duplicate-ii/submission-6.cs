public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
       HashSet<int> s = new HashSet<int>();

       for(int i=0; i < nums.Length; i++){
        if(s.Contains(nums[i])){
            return true;
        }

        s.Add(nums[i]);

        if(s.Count() > k){
            s.Remove(nums[i - k]);
        }     
       }
       return false;
    }
}