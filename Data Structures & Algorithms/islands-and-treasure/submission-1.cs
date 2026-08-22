public class State {
    public int Steps { get; set; }
    public int Row { get; set; }
    public int Col { get; set; }
    public State(int s, int r, int c) {
        Steps = s;
        Row = r;
        Col = c;
    }
}

public class Solution {
    public void islandsAndTreasure(int[][] grid) {
        
        int[][] dirs = [[1,0],[0,1],[-1,0],[0,-1]];
        int M = grid.Length;
        int N = grid[0].Length;

        var queue = new Queue<State>();

        for(int r = 0; r < M; r++) {
            for(int c = 0; c < N; c++) {
                if(grid[r][c] == 0) {
                    queue.Enqueue(new State(0,r,c));
                }
            }
        }

        // q: [(1,1,2),(1,2,0)]


        while(queue.Count > 0) {

            var state = queue.Dequeue();// (1,0,3),

            for(int i = 0; i < 4; i++) {

                int nr = dirs[i][0] + state.Row; //
                int nc = dirs[i][1] + state.Col;

                // check bounds
                if(nr < 0 || nr >= M || nc < 0 || nc >= N) continue;

                // skip water (-1) and 0s
                if(grid[nr][nc] == 0 || grid[nr][nc] == -1) continue;

                // might need to check minimum if we encounter state.steps + 1 < current steps ???
                if(grid[nr][nc] == int.MaxValue || (state.Steps + 1 < grid[nr][nc])) {
                    queue.Enqueue(new State(state.Steps + 1, nr, nc));
                    grid[nr][nc] = state.Steps + 1;
                }

            }


        }




    }
}


// [3,-1,0,1],
// [2,2,1,-1],
// [1,-1,2,-1],
// [0,-1,3,4]