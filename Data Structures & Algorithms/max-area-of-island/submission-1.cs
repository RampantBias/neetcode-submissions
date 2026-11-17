public class Solution {
    private readonly int[][] directions = new int[][] {
        new int[2] { 1, 0 },
        new int[2] { -1, 0 },
        new int[2] { 0, 1 },
        new int[2] { 0, -1 }
    };

    public int MaxAreaOfIsland(int[][] grid) {
        int maxArea = 0;
        
        for (int row = 0; row < grid.Length; row++) {
            for (int col = 0; col < grid[0].Length; col++) {
                if (grid[row][col] == 1) {
                    int area = 0;
                    Explore(grid, row, col, ref area);
                    maxArea = Math.Max(maxArea, area);
                }
            }
        }
        return maxArea;
    }

    private void Explore(int[][] grid, int row, int col, ref int area) {
        if (row < 0 || row >= grid.Length || col < 0 || col >= grid[0].Length) {
            return;
        }

        if (grid[row][col] == 0) {
            return;
        }
        
        area++;
        grid[row][col] = 0;

        foreach(var direction in directions) {
            Explore(grid, row + direction[0], col + direction[1], ref area);
        }
    }
}
