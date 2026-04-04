public class Solution {
    public bool IsValidSudoku(char[][] board) {
        // we probably want nine hashes
        var squares =  new HashSet<int>[9];
        for(int i = 0; i < squares.Length; i++)
            squares[i] = new HashSet<int>();
        
        // we also need to check the columns
        // ... this is a LOT of space...
        var columns = new HashSet<int>[9];
        for(int i = 0; i < columns.Length; i++)
            columns[i] = new HashSet<int>();

        // o(n^2) search
        for(int row = 0; row < board.Length; row++)
        {
            // 0-2
            int hashRow = row / 3;
            var currentRowNumbers = new HashSet<int>();
            for(int col = 0; col < board[0].Length; col++)
            {
                // dont care about '.'s
                if(board[row][col] == '.')
                    continue;
                
                // check if this row is still valid
                int curNum = (int)(board[row][col]);
                if(currentRowNumbers.Contains(curNum)) return false;
                else currentRowNumbers.Add(curNum);

                // check if this column is still valid
                if(columns[col].Contains(curNum)) return false;
                else columns[col].Add(curNum);
                
                // check subsquares
                int hashCol = col / 3;
                // Console.WriteLine($"hashRow: {hashRow}, hashCol: {hashCol}");
                HashSet<int> curSquare = squares[3 * hashRow + hashCol];
                if(curSquare.Contains(curNum)) return false;
                else curSquare.Add(curNum);

            }
            // Console.WriteLine("---");
        }
        return true;
    }
}
