public class Solution {

    private readonly int[][] _dirs = [ [1,0], [0,1], [-1,0], [0,-1] ];

    public int MaxAreaOfIsland(int[][] grid) {

        int M = grid.Length;
        int N = grid[0].Length;
        int maxArea = 0;

        for(int r = 0; r < M; r++) {
            for(int c = 0; c < N; c++) {

                if(grid[r][c] == 0) continue;
                int islandArea = FindArea(r, c, grid, M, N);
                maxArea = Math.Max(maxArea, islandArea);

            }
        }

        return maxArea;
    }


    private int FindArea(int row, int col, int[][] grid, int M, int N) {

        grid[row][col] = 0;
        int area = 0;

        foreach(var di in _dirs) {

            int r = row + di[0];
            int c = col + di[1];

            if(!IsValid(r,c,grid,M,N)) continue;
            area += FindArea(r,c,grid,M,N);

        }

        return area + 1;
    }

    private bool IsValid(int row, int col, int[][] grid, int M, int N) {
        return row >= 0 && row < M && col >= 0 && col < N && grid[row][col] == 1;
    }
}
