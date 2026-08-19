public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);

        List<List<int>> sums = new List<List<int>>();
        for (int i = 0; i < nums.Length; i++) {
            if (i > 0 && nums[i] == nums[i - 1]) {
                continue;
            }

            int numToHold = nums[i];
            int left = i + 1, right = nums.Length - 1;
            while (left < right) {
                int sum = numToHold + nums[left] + nums[right];
                if (sum == 0) {
                    sums.Add(new List<int>() { numToHold, nums[left], nums[right] });
                    left++;
                    right--;
                    // Move left and right, ensuring we find new numbers
                    while (left < right && nums[left] == nums[left - 1]) {
                        left++;
                    }
                    while (right > left && nums[right] == nums[right + 1]) {
                        right--;
                    }
                }
                else if (sum < 0) {
                    left++;
                }
                else {
                    right--;
                }
            }
        }
        return sums;
        
    }
}
