public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates);
        List<List<int>> combos = new ();
        Backtrack(candidates, target, 0, new List<int>(), ref combos);
        return combos;
    }

    private void Backtrack(int[] candidates, int target, int index, List<int> current, ref List<List<int>> combos) {
        // evaluate success
        int sum = 0;
        foreach(int num in current) {
            sum += num;
        }
        if (sum == target) {
            List<int> newCombo = new ();
            foreach(int num in current) {
                newCombo.Add(num);
            }
            combos.Add(newCombo);
            return;
        }
        else if (sum > target) {
            return;
        }

        // iterate
        for(int i = index; i < candidates.Length; i++) {
            // check if prior element was duplicate
            if (i > index && candidates[i] == candidates[i - 1]) {
                continue;
            }
            current.Add(candidates[i]);
            Backtrack(candidates, target, i + 1, current, ref combos);
            current.RemoveAt(current.Count - 1);
        }
    }
}
