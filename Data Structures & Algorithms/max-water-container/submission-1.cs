public class Solution {
    public int MaxArea(int[] heights) {
        int l = 0;
        int r = heights.Length - 1;
        int amount = 0;
        while(l < r){
           int area = (r - l) * Math.Min(heights[l], heights[r]);
             amount = Math.Max(area,  amount);
           if(heights[l] > heights[r]){
             r--;
           }else{
             l++;
           }      
        }

        return amount;
    }
}
