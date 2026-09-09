public class Solution {
    public int Trap(int[] height) {
        if (height.Length <= 2) {
            return 0;
        }
        int[] prefix = new int[height.Length];
        int[] suffix = new int[height.Length];
        prefix[0] = height[0];
        suffix[height.Length - 1] = height[height.Length - 1];
        for (int i = 1; i < height.Length; i++) {
            prefix[i] = Math.Max(height[i], prefix[i - 1]);
            suffix[height.Length - i - 1] = Math.Max(suffix[height.Length - i], height[height.Length - i - 1]);
        }

        int area = 0;
        for (int i = 1; i < height.Length - 1; i++) {
            int level = Math.Min(prefix[i - 1], suffix[i + 1]);
            area += Math.Max(0, level - height[i]);
        }
        return area;
    }
}
