public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // Get total number counts
        Dictionary<int, int> counts = new Dictionary<int, int>();
        foreach(int num in nums) {
            if (!counts.ContainsKey(num)) {
                counts[num] = 0;
            }
            counts[num]++;
        }

        // Build bucket frequency list
        List<int>[] frequency = new List<int>[nums.Length + 1];
        for (int i = 0; i < frequency.Length; i++) {
            frequency[i] = new List<int>();
        }
        
        foreach(var count in counts) {
            frequency[count.Value].Add(count.Key);
        }

        int[] result = new int[k];
        int resultIndex = 0;
        for (int i = frequency.Length - 1; i >= 0; i--) {
            foreach(int num in frequency[i]) {
                result[resultIndex++] = num;
                if (resultIndex == k) {
                    return result;
                }
            }
        }
        return result;
    }
}
