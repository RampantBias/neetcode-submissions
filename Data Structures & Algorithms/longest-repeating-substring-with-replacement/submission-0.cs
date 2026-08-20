public class Solution {
    public int CharacterReplacement(string s, int k) {
        int left = 0, right = 0;
        int maxLength = 0, maxFrequency = 0;
        Dictionary<char, int> counts = new();

        while (right < s.Length) {
            if (counts.ContainsKey(s[right])) {
                counts[s[right]]++;
            } else {
                counts[s[right]] = 1;
            }
            maxFrequency = Math.Max(maxFrequency, counts[s[right]]);

            while ( right - left + 1 - maxFrequency > k) {
                counts[s[left]]--;
                left++;
            }

            maxLength = Math.Max(right - left + 1, maxLength);
            right++;
        }
        return maxLength;
    }
}
