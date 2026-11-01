public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        List<List<int>> subsets = new();
        Backtrack(nums, 0, new List<int>(), ref subsets);
        return subsets;
    }

    private void Backtrack(int[] nums, int index, List<int> current, ref List<List<int>> subsets) {
        List<int> copied = new List<int>();
        foreach (int value in current) {
            copied.Add(value);
        }
        subsets.Add(copied);
        
        for (int i = index; i < nums.Length; i++) {
            current.Add(nums[i]);
            Backtrack(nums, i + 1, current, ref subsets);
            current.RemoveAt(current.Count - 1);
        }
    }
}
