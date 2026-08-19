public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> counts = new();
        List<int>[] freq = new List<int>[nums.Length + 1];
        for (int i = 0; i < freq.Length; i++) {
            freq[i] = new List<int>();
        }

        foreach(int num in nums) {
            if (counts.ContainsKey(num)) {
                counts[num]++;
            } else {
                counts[num] = 1;
            }
        }

        foreach (var kvp in counts) {
            freq[kvp.Value].Add(kvp.Key);
        }

        int[] solution = new int[k];
        int index = 0;
        for (int i = freq.Length - 1; i >= 0 && index < k; i--) {
            foreach(int n in freq[i]) {
                solution[index++] = n;
                if (index == k) {
                    return solution;
                }
            }
        }

        return solution;
    }
}
