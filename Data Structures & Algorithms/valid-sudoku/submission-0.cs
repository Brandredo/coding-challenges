public class Solution {
    public bool IsValidSudoku(char[][] board) {
        
        var seen = new HashSet<char>();

        for(int r = 0; r < 9; r++) {
            for(int c = 0; c < 9; c++) {
                if(board[r][c] == '.') continue;
                if(seen.Contains(board[r][c])) return false;
                seen.Add(board[r][c]);
            }
            seen.Clear();
        }

        seen.Clear();
        for(int c = 0; c < 9; c++) {
            for(int r = 0; r < 9; r++) {
                if(board[r][c] == '.') continue;
                if(seen.Contains(board[r][c])) return false;
                seen.Add(board[r][c]);
            }
            seen.Clear();
        }
        Console.WriteLine("Checking last condition");

        if( IsSubgridInvalid(0,2,0,2,board) ||
            IsSubgridInvalid(0,2,3,5,board) ||
            IsSubgridInvalid(0,2,6,8,board) ||
            IsSubgridInvalid(3,5,0,2,board) ||
            IsSubgridInvalid(3,5,3,5,board) ||
            IsSubgridInvalid(3,5,6,8,board) ||
            IsSubgridInvalid(6,8,0,2,board) ||
            IsSubgridInvalid(6,8,3,5,board) ||
            IsSubgridInvalid(6,8,6,8,board)) {
            return false;
        }

        return true;

    }

    private bool IsSubgridInvalid(int sr, int er, int sc, int ec, char[][] board) {

        var seen = new HashSet<char>();
        for(int r = sr; r <= er; r++) {

            for(int c = sc; c <= ec; c++) {

                if(board[r][c] == '.') continue;
                if(seen.Contains(board[r][c])) return true;
                seen.Add(board[r][c]);

            }
            
        }

        return false;


    }
}
