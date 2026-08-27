public class Solution {
    public int ClimbStairs(int n) {
        if (n <=1 ) {
            return 1;
        }

        int twoBack = 1;
        int oneBack = 1;
        for (int i = 2; i <= n; i++) {
            int current = oneBack + twoBack;
            twoBack = oneBack;
            oneBack = current;
        }
        return oneBack;
    }
}
