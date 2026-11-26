public class Solution {
    List<List<int>> subsets = new();
    public List<List<int>> SubsetsWithDup(int[] nums) {
        // seems simple enough with a sorted array
        Array.Sort(nums);
        List<int> currentSubset = new();
        Backtrack(nums, 0, ref currentSubset);
        return subsets;
    }

    private void Backtrack(int[] nums, int index, ref List<int> currentSubset) {
        // Anytime we backtrack, we have a valid subset
        subsets.Add(new List<int>(currentSubset));

        for (int i = index; i < nums.Length; i++) {
            // Check for duplicate
            if (i > 0) {
                if (index != i && nums[i] == nums[i - 1]) {
                    continue;
                }
            }

            currentSubset.Add(nums[i]);
            Backtrack(nums, i + 1, ref currentSubset);
            currentSubset.RemoveAt(currentSubset.Count - 1);
        }
    }
}
