public class Solution {
    public int FindMin(int[] nums) {
        int left = 0, right = nums.Length - 1;
        int result = nums[0];
        while (left <= right) {
            if (nums[left] < nums[right]) {
                result = Math.Min(nums[left], result);
            }
            
            int mid = left + (right - left) / 2;
            result = Math.Min(nums[mid], result);

            if (nums[mid] >= nums[left]) {
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }
       return result;
    }
}
