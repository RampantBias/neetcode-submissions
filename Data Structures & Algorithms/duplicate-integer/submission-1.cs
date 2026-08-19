public class Solution {
    public bool hasDuplicate(int[] nums) {
        if (nums.Length <= 1) {
            return false;
        }

        HashSet<int> seen = new HashSet<int>();
        foreach(int num in nums) {
            if (seen.Contains(num)) {
                return true;
            } else {
                seen.Add(num);
            }
        }
        return false;
    }
}