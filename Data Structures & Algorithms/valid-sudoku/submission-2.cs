public class Solution {
    public bool IsValidSudoku(char[][] board) {
        int[,] rows = new int[9, 9];
        int[,] cols = new int[9, 9];
        int[,] grids = new int[9, 9];

        for (int row = 0; row < 9; row++) {
            for (int col = 0; col < 9; col++) {
                // evaluate char->int
                char element = board[row][col];
                if (element == '.')
                    continue;

                int index = element - '1';
                int gridNumber = (row / 3) * 3 + (col / 3);

                if (rows[row, index] != 0 || cols[col, index] != 0 || grids[gridNumber, index] != 0) {
                    return false;
                }
                rows[row, index] = cols[col, index] = grids[gridNumber, index] = 1;
            }
        }

        return true;
    }
}
