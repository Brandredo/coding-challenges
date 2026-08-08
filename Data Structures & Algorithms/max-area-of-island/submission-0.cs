public class Solution {

    private readonly int[][] _dirs = [ [1,0], [0,1], [-1,0], [0,-1] ];

    public int MaxAreaOfIsland(int[][] grid) {
        
        //Console.WriteLine("test");
        int M = grid.Length;
        int N = grid[0].Length;
        int maxArea = 0;
        bool[][] visited = new bool[M][];

        for(int i = 0; i < M; i++) {
            visited[i] = new bool[N];
        }

        for(int r = 0; r < M; r++) {
            for(int c = 0; c < N; c++) {

                if(grid[r][c] == 0 || visited[r][c]) continue;
                visited[r][c] = true;
                int islandArea = FindArea(r, c, grid, visited, M, N);
                maxArea = Math.Max(maxArea, islandArea);

            }
        }

        return maxArea;
    }


    private int FindArea(int row, int col, int[][] grid, bool[][] visited, int M, int N) {

        int area = 0;

        if(!IsValid(row,col,grid,visited,M,N)) return area;

        foreach(var di in _dirs) {

            int r = row + di[0];
            int c = col + di[1];

            if(!IsValid(r,c,grid,visited,M,N) || visited[r][c]) continue;

            //Console.WriteLine($"row:{r},col:{c}");
            visited[r][c] = true;
            area += FindArea(r,c,grid,visited,M,N);

        }

        //Console.WriteLine("returning: " + area + 1);
        return area + 1;
    }

    private bool IsValid(int row, int col, int[][] grid, bool[][] visited, int M, int N) {
        return row >= 0 && row < M && col >= 0 && col < N && grid[row][col] == 1;
    }
}
