public class Solution {
    public int MaxArea(int[] heights) {
        int maxWaterContainer = 0;
        int l = 0;
        int r = heights.Length - 1;
        while(l < r){
            maxWaterContainer = Math.Max((Math.Min(heights[l], heights[r]) * (r - l)), maxWaterContainer);

            if (heights[l] > heights[r]){
                r--;
            }else{
                l++;
            }
        }
        return maxWaterContainer;
    }
}
