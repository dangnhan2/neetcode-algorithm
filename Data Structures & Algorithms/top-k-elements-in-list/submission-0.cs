public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> store = new Dictionary<int,int>();
        for(int i= 0; i < nums.Length; i++){
            if(!store.ContainsKey(nums[i])){
                store[nums[i]] = 0;
            }

            store[nums[i]]++;
        }

        return store.OrderByDescending(pair => pair.Value)
                .Take(k)
                .Select(pair => pair.Key)
                .ToArray();

    }
}
