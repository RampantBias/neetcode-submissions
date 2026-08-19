public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0, right = numbers.Length - 1;
        int sum = numbers[left] + numbers[right];
        while (sum != target && left < right) {
            sum = numbers[left] + numbers[right];
            if (sum > target) {
                right--;
            }
            if (sum < target) {
                left++;
            }
        }
        return [left + 1, right + 1];
    }
}
