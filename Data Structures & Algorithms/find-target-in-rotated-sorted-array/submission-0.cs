public class Solution {
    public int Search(int[] nums, int target) {
        // Find pivot point
        int left = 0, right = nums.Length - 1;
        while (left < right) {
            int mid = left + (right - left) / 2;
            if (nums[mid] > nums[right]) {
                left = mid + 1;
            }
            else {
                right = mid;
            }
        }
        int pivot = left;

        // Search left-half
        int result = BinarySearch(nums, target, 0, pivot - 1);
        if (result != -1) {
            return result;
        }
        return BinarySearch(nums, target, pivot, nums.Length - 1);
    }

    private int BinarySearch(int[] nums, int target, int left, int right) {
        while (left <= right) {
            int mid = left + (right - left) / 2;
            if (nums[mid] == target) {
                return mid;
            }
            else if (nums[mid] > target) {
                right = mid - 1;
            }
            else {
                left = mid + 1;
            }
        }
        return -1;
    }
}
