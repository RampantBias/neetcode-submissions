public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        for (int i = 0; i < matrix.Length; i++) {
            int m = matrix[i].Length - 1;
            if (matrix[i][0] <= target && matrix[i][m] >= target) {
                int left = 0, right = m;
                while (left <= right) {
                    int mid = left + (right - left) / 2;
                    if (matrix[i][mid] == target) {
                        return true;
                    } else if (matrix[i][mid] < target) {
                        left = mid + 1;
                    } else {
                        right = mid - 1;
                    }
                }
                break;
            }
        }
        return false;
    }
}
