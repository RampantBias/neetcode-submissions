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
                    maxArea = Math.Max(maxArea, Explore(grid, row, col));
                }
            }
        }
        return maxArea;
    }

    private int Explore(int[][] grid, int row, int col) {
        if (row < 0 || row >= grid.Length || col < 0 || col >= grid[0].Length) {
            return 0;
        }

        if (grid[row][col] == 0) {
            return 0;
        }
        
        int area = 1;
        grid[row][col] = 0;

        foreach(var direction in directions) {
            area += Explore(grid, row + direction[0], col + direction[1]);
        }
        return area;
    }
}
