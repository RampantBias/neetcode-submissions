public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }

        int[] sFrequency = new int[26];
        foreach(char c in s) {
            sFrequency[c - 'a']++;
        }

        foreach(char c in t) {
            if (sFrequency[c - 'a'] == 0) {
                return false;
            }
            sFrequency[c - 'a']--;
        }
        return true;
    }
}
