public class Solution {
    public int MySqrt(int x) {
        int l = 0;
        int h = x;
        int res = 0;
        while(l <= h){
            int mid = l + (h - l)/2;
            long sq = (long)mid*mid;
            if(sq > x) h = mid -1;
            else if (sq < x){
                l = mid+1;
                res = mid;
            } 
            else return mid;  
        }
        return res;
    }
}