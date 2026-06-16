public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
      int[] res = new int[temperatures.Length];

      for(int i = 0; i< temperatures.Length; i++){
        int count = 0;
        for(int j = i; j < temperatures.Length; j++){
            if (temperatures[j] > temperatures[i]){
                count = j - i;
                break;
            }
        }
        res[i] = count;
      }

      return res;
    }
}
