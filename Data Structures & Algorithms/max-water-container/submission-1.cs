public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0, right = heights.Length - 1;
        int maxArea = 0;
        while (left < right) {
            int width = right - left;
            if (heights[left] <= heights[right]) {
                maxArea = Math.Max(maxArea, heights[left] * width);
                left++;
            } else {
                maxArea = Math.Max(maxArea, heights[right] * width);
                right--;
            }
        }
        return maxArea;
    }
}
