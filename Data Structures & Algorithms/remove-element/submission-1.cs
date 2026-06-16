public class Solution {
    public int RemoveElement(int[] nums, int val) {
        List<int> tmp = new List<int>();
        foreach (int num in nums) {
            if (num != val) {
                tmp.Add(num);
            }
        }
        
        for (int i = 0; i < tmp.Count; i++) {
            nums[i] = tmp[i];
        }
        
        return tmp.Count;
    }
}