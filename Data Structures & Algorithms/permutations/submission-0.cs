public class Solution {
    public List<List<int>> Permute(int[] nums) {
        List<List<int>> permutations = new ();
        Backtrack(nums, new HashSet<int>(), ref permutations);
        return permutations;
    }

    private void Backtrack(int[] nums, HashSet<int> current, ref List<List<int>> permutations) {
        if (current.Count == nums.Length) {
            permutations.Add(new List<int>(current));
            return;
        }


        for (int i = 0; i < nums.Length; i++) {
            if (current.Contains(nums[i])) {
                continue;
            }

            current.Add(nums[i]);
            Backtrack(nums, current, ref permutations);
            current.Remove(nums[i]);
        }
    }
}
