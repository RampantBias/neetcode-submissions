public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0, right = s.Length - 1;
        s = s.ToLower();
        while (left < right) {
            while (!char.IsLetterOrDigit(s[left]) && left < right) {
                left++;
            }
            while (!char.IsLetterOrDigit(s[right]) && right > left) {
                right--;
            }

            if (s[left] != s[right]) {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}
