public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int[] known = new int[26];
        foreach(char c in s1) {
            known[c - 'a']++;
        }

        int[] windowFreq = new int[26];
        int left = 0, right = s1.Length - 1;
        for (int i = 0; i < right; i++) {
            windowFreq[s2[i] - 'a']++;
        }

        while (right < s2.Length) {
            windowFreq[s2[right] - 'a']++;
            // Compare frequencies
            bool match = false;
            for (int i = 0; i < 26; i++) {
                if (known[i] != windowFreq[i]) {
                    match = false;
                    break;
                } else {
                    match = true;
                }
            }
            if (match) {
                return true;
            }

            windowFreq[s2[left] - 'a']--;
            left++;
            right++;
        }
        return false;
    }
}
