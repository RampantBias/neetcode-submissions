public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length <= 1) {
            return nums.Length;
        }

        int maxLength = 1;
        HashSet<int> hashed = new HashSet<int>(nums);
        foreach(int num in nums) {
            if (!hashed.Contains(num - 1)) {
                int length = 1;
                int next = num + 1;
                while (hashed.Contains(next)) {
                    length++;
                    next++;
                }
                maxLength = Math.Max(maxLength, length);
            }
        }
        return maxLength;
    }
}
