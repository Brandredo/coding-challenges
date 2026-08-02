public class Solution {
    public int NumIslands(char[][] grid) {
        if(grid.Length == 0) return 0;
        var rows = grid.Length;
        var cols = grid[0].Length;

        var numOfIslands = 0;
        
        var seen = new bool[rows][];
        for(int i = 0; i < rows; i++) {
            seen[i] = new bool[cols];
        }

        // ["0",t,"1","1","0"],
        // ["0",t,"0","1","0"],
        // [t,t,"0","0","0"],
        // ["0","0","0","0","0"]

        for(int r = 0; r < rows; r++) {
            for(int c = 0; c < cols; c++) {
                if(seen[r][c] == true || grid[r][c] == '0') continue;
                Explore(r, c, grid, seen, rows, cols);
                numOfIslands++;// 1
            }
        }

        return numOfIslands;

    }

    private void Explore(int row, int col, char[][] grid, bool[][] seen, int maxRows, int maxCols) {

        seen[row][col] = true;

        var directions = new int[][] {[1,0],[0,1],[-1,0],[0,-1]};

        for(int n = 0; n < 4; n++) {
            
            int newRow = row + directions[n][0];
            int newCol = col + directions[n][1];
            
            if(newRow < 0 || newCol < 0 || newRow >= maxRows || newCol >= maxCols) continue;
            if(seen[newRow][newCol] == true || grid[newRow][newCol] == '0') continue;
            Explore(newRow, newCol, grid, seen, maxRows, maxCols);
        }

    }
}
