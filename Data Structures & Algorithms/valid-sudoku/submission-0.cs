public class Solution {
    public bool IsValidSudoku(char[][] board) {
        bool[,] seenRows = new bool[9, 9];
        bool[,] seenCols = new bool[9, 9];
        bool[,] seenGrids = new bool[9, 9];

        for (int i = 0; i < board.Length; i++) {
            for (int j = 0; j < board[i].Length; j++) {
                if (board[i][j] == '.') {
                    continue;
                }

                int cellValue = board[i][j] - '1';
                int gridPos = (i / 3) * 3 + j / 3;

                if (seenRows[i, cellValue] || seenCols[j, cellValue] || seenGrids[gridPos, cellValue]) {
                    return false;
                }

                seenRows[i, cellValue] = seenCols[j, cellValue] = seenGrids[gridPos, cellValue] = true;
            }
        }

        return true;
    }
}
