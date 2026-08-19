public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }

        int[] characters = new int[26];
        foreach(char c in s) {
            characters[c - 'a']++;
        }

        foreach(char c in t) {
            int position = c - 'a';
            if (characters[position] == 0) {
                return false;
            }
            characters[position]--;
        }

        foreach(int character in characters) {
            if (character > 0) {
                return false;
            }
        }
        return true;
    }
}
