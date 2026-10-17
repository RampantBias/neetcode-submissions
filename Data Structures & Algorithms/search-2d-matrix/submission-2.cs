public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int left = 0, right = matrix.Length - 1;
        while (left <= right) {
            int mid = left + (right - left) / 2;
            int sLength = matrix[mid].Length - 1;
            
            // could function binarysearch
            if (matrix[mid][0] <= target && matrix[mid][sLength] >= target) {
                int sLeft = 0, sRight = sLength;
                while (sLeft <= sRight) {
                    int sMid = sLeft + (sRight - sLeft) / 2;
                    if (matrix[mid][sMid] == target) {
                        return true;
                    }
                    else if (matrix[mid][sMid] > target) {
                        sRight = sMid - 1;
                    }
                    else {
                        sLeft = sMid + 1;
                    }
                }
                return false;
            }
            else if (matrix[mid][0] < target) {
                left = mid + 1;
            }
            else if (matrix[mid][sLength] > target) {
                right = mid - 1;
            }
        }
        return false;
    }
}
