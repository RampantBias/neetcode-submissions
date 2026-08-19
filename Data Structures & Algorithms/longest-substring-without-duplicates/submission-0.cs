public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s == null || s.Length == 0) return 0;

        int left = 0, right = 0;
        int maxLength = 0;
        HashSet<char> seen = new HashSet<char>();
        while (right < s.Length) {
            while (seen.Contains(s[right])) {
                seen.Remove(s[left]);
                left++;
            }
            seen.Add(s[right]);
            right++;
            maxLength = Math.Max(maxLength, right - left);
        }
        return maxLength;
    }
}
