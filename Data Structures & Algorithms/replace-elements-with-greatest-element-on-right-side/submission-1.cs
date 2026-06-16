public class Solution {
    public int[] ReplaceElements(int[] arr) {
       int n = arr.Length;
       int[] newArr = new int[n];
       int rightMax = -1;

       for(int i = n-1; i >= 0; i--){
         newArr[i] = rightMax;
         rightMax = Math.Max(rightMax, arr[i]);
       }

       return newArr;
    }
}
