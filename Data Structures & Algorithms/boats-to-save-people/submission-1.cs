public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        Array.Sort(people);
        int boats = 0;
        int l = 0;
        int r = people.Length -1;
        while(l <= r){
            int remain = limit - people[r];
            r--;
            boats++;

            if(remain >= people[l]){
                l++;
            }
        }
        return boats;
    }
}