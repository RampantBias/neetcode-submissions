public class Solution {
    
    public bool Exist(char[][] board, string word) {
        // We'll search for the occurrence of the first letter
        // in the word. Once found, we can search the the vertical
        // and horizontal neighbors for a match to the second letter.

        for (int i = 0; i < board.Length; i++) {
            for (int j = 0; j < board[i].Length; j++) {
                // guaranteed word.Length >= 1
                if (board[i][j] == word[0]) {
                    // Generated visited set
                    bool[][] visited = new bool[board.Length][];
                    for(int v = 0; v < board.Length; v++) {
                        visited[v] = new bool[board[i].Length];
                    }

                    // Check if we can navigate a match
                    if (DFS(board, word, 0, i, j, ref visited)) {
                        return true;
                    }
                }
            }
        }
        return false;
    }

    private bool DFS(char[][] board, string word, int wordIndex, int i, int j, ref bool[][] visited) {
        // Check word position
        if (wordIndex >= word.Length) {
            return true;
        }

        // visited and bounds check
        if (i < 0 || j < 0 || i >= visited.Length || j >= visited[i].Length || visited[i][j] || 
            word[wordIndex] != board[i][j]) {
            return false;
        }
        visited[i][j] = true;

        // Check each direction
        bool result = 
            DFS(board, word, wordIndex + 1, i + 1, j,     ref visited) ||
            DFS(board, word, wordIndex + 1, i - 1, j,     ref visited) ||
            DFS(board, word, wordIndex + 1, i,     j + 1, ref visited) ||
            DFS(board, word, wordIndex + 1, i,     j - 1, ref visited);
        visited[i][j] = false;
        return result;
    }
}
