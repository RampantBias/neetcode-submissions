public class Solution {
    public int ClimbStairs(int n) {
        if (n <=1 ) {
            return (n == 0) ? 0 : 1;
        }
        int[] state = new int[n];
        state[0] = 1;
        state[1] = 2;
        for (int i = 2; i < n; i++) {
            state[i] = state[i - 1] + state[i - 2];
        }
        return state[n - 1];
    }
}
