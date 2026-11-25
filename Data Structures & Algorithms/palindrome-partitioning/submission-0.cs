public class Solution {
    public List<List<string>> Partition(string s) {
        List<List<string>> partitions = new();
        List<string> current = new();
        Backtrack(s, 0, 0, ref current, ref partitions);
        return partitions;
    }

    private void Backtrack(string s, int left, int right, ref List<string> current, ref List<List<string>> partitions) {
        if (right >= s.Length) {
            if (left == right) {
                partitions.Add(new List<string>(current));
            }
            return;
        }

        // Evaluate current string as palindrome, if it is
        // we can add remaining strings
        if (IsPalindrome(s, left, right)) {
            current.Add(s.Substring(left, right - left + 1));
            // We move to the next available character
            Backtrack(s, right + 1, right + 1, ref current, ref partitions);
            current.RemoveAt(current.Count - 1);
        }

        Backtrack(s, left, right + 1, ref current, ref partitions);
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
