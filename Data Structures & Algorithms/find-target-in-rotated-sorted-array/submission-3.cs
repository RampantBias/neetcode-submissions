public class Solution {
    public int Search(int[] nums, int target) {
        // find pivot point, then we can search
        // left side and right side, otherwise -1
        // run binary search for pivot
        int left = 0, right = nums.Length - 1;
        while (left < right) {
            int mid = left + (right - left) / 2;
            if (nums[right] < nums[mid]) {
                left = mid + 1;
            } else {
                right = mid;
            }
        }
        int pivot = left;

        int result = BinarySearch(nums, target, 0, pivot - 1);
        if (result == -1) {
            result = BinarySearch(nums, target, pivot, nums.Length - 1);
        }
        return result;
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
