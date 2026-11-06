public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int left = 1, right = piles.Max();
        int result = right;//assume highest eating speed
        while (left <= right) {
            int mid = (right - left) / 2 + left;
            
            // evaluate mid speed
            long totalTime = 0;
            foreach(int pile in piles) {
                totalTime += (long)Math.Ceiling((double)pile / (double)mid);
            }
            if (totalTime <= h) {
                right = mid - 1;
                result = mid;
            }
            else {
                left = mid + 1;
            }
        }
        return result;
    }
}
