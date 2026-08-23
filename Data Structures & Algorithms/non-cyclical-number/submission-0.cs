public class Solution {
    public bool IsHappy(int n) {
        HashSet<int> seen = new HashSet<int>();
        while (!seen.Contains(n)) {
            seen.Add(n);

            int sum = 0;
            foreach(char c in n.ToString()) {
                int val = c - '0';
                sum += val * val;
            }

            if (sum == 1) {
                return true;
            }
            n = sum;
        }
        return false;
    }
}
