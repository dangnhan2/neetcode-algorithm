public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> store = new List<List<int>>();

        for(int x =0; x< nums.Length; x++){
            for(int y= x+1; y< nums.Length; y++){
                for(int z=y+1;z< nums.Length;z++){
                   if(nums[x] + nums[y] + nums[z] == 0){
                    List<int> triplet = new List<int>{nums[x] , nums[y] , nums[z]};
                    triplet.Sort();
                    if (!store.Any(t => t.SequenceEqual(triplet))) {
                        store.Add(triplet);
                    }
                    
                }
            }
        }
    }

        return store;
    }
}
