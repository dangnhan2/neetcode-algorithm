public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> store = new HashSet<int>(nums);

        if (store.Count() != nums.Length)
           return true;

        return false;
    }
}