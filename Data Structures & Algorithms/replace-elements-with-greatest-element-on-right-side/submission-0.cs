public class Solution {
    public int[] ReplaceElements(int[] arr) {
       int n = arr.Length;
       int[] newArr = new int[n];
       int rightMax = -1;

       for(int i = 0; i < n ; i++){
        for(int j = i + 1; j < n ; j++){
            rightMax = Math.Max(rightMax, arr[j]);
        }
        newArr[i] = rightMax;
        rightMax = -1;
       }

       return newArr;
    }
}