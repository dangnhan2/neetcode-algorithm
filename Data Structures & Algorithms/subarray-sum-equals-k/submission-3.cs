public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int count = 0;
        int prefixSum = 0;
        Dictionary<int, int> store = new Dictionary<int, int>();
        store[0] = 1;
        for (int i = 0 ;i< nums.Length; i++){
            prefixSum += nums[i];
            int diff = prefixSum - k;

            if (store.ContainsKey(diff)){
                count += store[diff];
            }

            if (!store.ContainsKey(prefixSum)){
                store[prefixSum] = 0;
            }

            store[prefixSum]++;
        }

        return count;
    }
}