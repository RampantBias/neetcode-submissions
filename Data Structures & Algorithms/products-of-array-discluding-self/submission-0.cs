public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] prefix = new int[nums.Length];
        int[] suffix = new int[nums.Length];

        // Set beginning of prefix and end of suffix to 1 to account for start/end
        prefix[0] = suffix[nums.Length - 1] = 1;
        for (int i = 1; i < nums.Length; i++) {
            prefix[i] = nums[i - 1] * prefix[i - 1];
        }

        for (int i = nums.Length - 2; i >= 0; i--) {
            suffix[i] = nums[i + 1] * suffix[i + 1];
        }

        int[] answer = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++) {
            answer[i] = prefix[i] * suffix[i];
        }
        return answer;
    }
}
