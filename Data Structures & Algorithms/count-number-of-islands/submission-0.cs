public class Solution {

    private readonly int[][] directions = new int[][] {
        new int[] { 1, 0 },
        new int[] { -1, 0 },
        new int[] { 0, 1 },
        new int[] { 0, -1 }
    };

    public int NumIslands(char[][] grid) {
        int islandCount = 0;

        for (int row = 0; row < grid.Length; row++) {
            for (int col = 0; col < grid[0].Length; col++) {
                if (grid[row][col] == '1') {
                    Explore(grid, row, col);
                    islandCount++;
                }
            }
        }
        return islandCount;
    }

    // explore island and sink each land cell
    private void Explore(char[][] grid, int i, int j) {
        // Water boundary check
        if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length) {
            return;
        }

        // Hit water, can't search
        if (grid[i][j] == '0') {
            return;
        }

        grid[i][j] = '0';
        foreach (var direction in directions) {
            Explore(grid, i + direction[0], j + direction[1]);
        }
    }
}
