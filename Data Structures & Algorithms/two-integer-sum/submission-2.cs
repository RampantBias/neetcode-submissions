public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // Numbers seen and their index position
        Dictionary<int, int> seen = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++) {
            int difference = target - nums[i];
            if (seen.ContainsKey(difference)) {
                return new int[2] { seen[difference], i  };
            }
            seen[nums[i]] = i;
        }
        return new int[2] { 0, 0 };
    }
}
