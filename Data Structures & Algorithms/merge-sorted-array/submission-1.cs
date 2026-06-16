public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int[] tmp = nums2.Concat(nums1).ToArray();
        
        for(int i=0 ; i < nums1.Length; i++){
            nums1[i] = tmp[i];
        }
        Array.Sort(nums1);
        
    }
}