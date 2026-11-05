public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        // sort nums to ensure least to greatest, simpler checking
        Array.Sort(nums);
        List<List<int>> combos = new();
        Backtrack(nums, 0, new List<int>(), target, ref combos);
        return combos;
    }

    private void Backtrack(int[] nums, int index, List<int> current, int target, ref List<List<int>> combos) {
        // check success condition
        int sum = 0;
        foreach(int num in current) {
            sum += num;
        }
        if (sum == target) {
            List<int> newCombo = new();
            foreach(int num in current) {
                newCombo.Add(num);
            }
            combos.Add(newCombo);
            return; // exit
        }
        else if (sum > target) {
            return;// exit because no new numbers can bring us to target (assumption: nums[n] > 0)
        }

        for (int i = index; i < nums.Length; i++) {
            current.Add(nums[i]);
            Backtrack(nums, i, current, target, ref combos); // feed i back in to ensure we can double/triple/etc count
            current.RemoveAt(current.Count - 1);
        }
    }
}
