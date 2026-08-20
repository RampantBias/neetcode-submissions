public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s.Length <= 1) {
            return s.Length;
        }

        HashSet<char> seen = new();
        int left = 0, right = 0;
        int maxLength = 0;
        while (right < s.Length) {
            while (seen.Contains(s[right])) {
                seen.Remove(s[left++]);
            }

            seen.Add(s[right++]);
            maxLength = Math.Max(maxLength, right - left);
        }

        return maxLength;
    }


}
