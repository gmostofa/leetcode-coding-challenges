public class Solution {
    public bool Exist(char[][] board, string word) {
        int rows = board.Length;
        int cols = board[0].Length;

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (DFS(board, word, i, j, 0))
                    return true;
            }
        }
        return false;
    }

    private bool DFS(char[][] board, string word, int i, int j, int index) {
        if (index == word.Length)
            return true; // all characters matched

        if (i < 0 || i >= board.Length || j < 0 || j >= board[0].Length || board[i][j] != word[index])
            return false;

        char temp = board[i][j];
        board[i][j] = '#'; // mark visited

        bool found = DFS(board, word, i + 1, j, index + 1) ||
                     DFS(board, word, i - 1, j, index + 1) ||
                     DFS(board, word, i, j + 1, index + 1) ||
                     DFS(board, word, i, j - 1, index + 1);

        board[i][j] = temp; // backtrack
        return found;
    }
}