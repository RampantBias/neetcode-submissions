public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> differences = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            int difference = target - nums[i];
            if (differences.ContainsKey(difference)) {
                return new int[2] { differences[difference], i};
            }
            differences[nums[i]] = i;
        }
        return new int[2];
    }
}
