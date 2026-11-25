public class Solution {
    private bool[,] visited;
    public bool Exist(char[][] board, string word) {
        // We'll search for the occurrence of the first letter
        // in the word. Once found, we can search the the vertical
        // and horizontal neighbors for a match to the second letter.
        
        // Generated visited set
        bool[,] visited = new bool[board.Length, board[0].Length];

        for (int i = 0; i < board.Length; i++) {
            for (int j = 0; j < board[i].Length; j++) {
                // Check if we can navigate a match
                if (DFS(board, word, 0, i, j, ref visited)) {
                    return true;
                }
            }
        }
        return false;
    }

    private bool DFS(char[][] board, string word, int wordIndex, int i, int j, ref bool[,] visited) {
        // Check word position
        if (wordIndex >= word.Length) {
            return true;
        }

        // visited and bounds check
        if (i < 0 || j < 0 || i >= board.Length || j >= board[0].Length || visited[i,j] || 
            word[wordIndex] != board[i][j]) {
            return false;
        }
        visited[i,j] = true;

        // Check each direction
        bool result = 
            DFS(board, word, wordIndex + 1, i + 1, j,     ref visited) ||
            DFS(board, word, wordIndex + 1, i - 1, j,     ref visited) ||
            DFS(board, word, wordIndex + 1, i,     j + 1, ref visited) ||
            DFS(board, word, wordIndex + 1, i,     j - 1, ref visited);
        visited[i,j] = false;
        return result;
    }
}
