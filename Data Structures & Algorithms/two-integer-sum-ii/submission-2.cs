public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int r = 0;
        int l = numbers.Length - 1;
        
        while(r < l){
           while(r < l && numbers[r] + numbers[l] > target) l--;
           while(r < l && numbers[r] + numbers[l] < target) r++;

           if (numbers[r] + numbers[l] == target)
           return new int[] {r+1, l+1 };
        }
        return new int[] {-1,-1};
    }
}
