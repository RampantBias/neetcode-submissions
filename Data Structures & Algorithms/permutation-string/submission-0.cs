public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s2.Length < s1.Length) return false;

        // Build frequency counts of s1
        int[] s1Frequency = new int[26];
        foreach(char c in s1) {
            s1Frequency[c - 'a']++;
        }

        // Build sliding window to analyze each substring in s2 for a match
        int left = 0, right = 0;
        int[] s2Frequency = new int[26];
        while (right < s2.Length) {
            s2Frequency[s2[right] - 'a']++;

            // Expand window to correct size
            while (right - left < s1.Length - 1) {
                right++;
                s2Frequency[s2[right] - 'a']++;              
            }

            int matches = 0;
            for (int i = 0; i < 26; i++) {
                if (s1Frequency[i] == s2Frequency[i]) {
                    matches++;
                }
            }
            if (matches == 26) {
                return true;
            }

            s2Frequency[s2[left] - 'a']--;
            left++;
            right++;
        }
        return false;
    }
}
