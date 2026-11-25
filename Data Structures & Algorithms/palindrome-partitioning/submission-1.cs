public class Solution {

    private List<List<string>> partitions = new();
    public List<List<string>> Partition(string s) {
        List<string> current = new();
        Backtrack(s, 0, 0, ref current);
        return partitions;
    }

    private void Backtrack(string s, int left, int right, ref List<string> current) {
        if (right >= s.Length) {
            partitions.Add(new List<string>(current));
            return;
        }

        for (int i = right; i < s.Length; i++) {
            if (IsPalindrome(s, left, i)) {
                string newPalindrome = s.Substring(left, i - left + 1);
                current.Add(newPalindrome);
                Backtrack(s, i + 1, i + 1, ref current);
                current.RemoveAt(current.Count - 1);
            }
        }
    }

    private bool IsPalindrome(string s, int left, int right) {
        while (left < right) {
            if (s[left] != s[right]) {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}
