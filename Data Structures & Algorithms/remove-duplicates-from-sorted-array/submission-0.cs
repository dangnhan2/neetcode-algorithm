public class Solution {
    public int RemoveDuplicates(int[] nums) {
        HashSet<int> store = new HashSet<int>(nums);
        int i = 0;

    foreach (int num in store)
    {
        nums[i++] = num;
    }

    return store.Count;

    }
}