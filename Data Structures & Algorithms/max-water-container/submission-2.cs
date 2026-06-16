public class Solution {
    public int MaxArea(int[] heights) {
        int maxWaterContainer = 0;
        for (int i = 0; i < heights.Length; i++){
            for (int j = i + 1; j < heights.Length; j++){
                int minBar = Math.Min(heights[i], heights[j]);
                maxWaterContainer = Math.Max(minBar * (j - i), maxWaterContainer);
            }
        }

        return maxWaterContainer;
    }
}
