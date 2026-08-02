public class Solution {
    public int CountComponents(int n, int[][] edges) {

        if(edges == null || edges.Length == 0 || n <= 0) return 0;

        var graph = new Dictionary<int, List<int>>();
        var seen = new HashSet<int>();
        int connectedComponents = 0;

        foreach(var edge in edges) {
            int from = edge[0];
            int to = edge[1];

            if(!graph.ContainsKey(from)) {
                graph[from] = new List<int>();
            }

            if(!graph.ContainsKey(to)) {
                graph[to] = new List<int>();
            }

            graph[from].Add(to);
            graph[to].Add(from);
        }

        // for(int j = 0; j < n; j++) {
        //     if
        // }


        // 0 -> [1], 1 -> [2], 3 -> [4]
        // seen: [0,1,2,3,4]
        for(int i = 0; i < n; i++) {

            //if(!graph.ContainsKey(i)) continue;
            if(seen.Contains(i)) continue;
            
            DFS(i, seen, graph);
            connectedComponents++; // 2
            
        }

        return connectedComponents;
    }

    private void DFS(int node, HashSet<int> seen, Dictionary<int, List<int>> graph) {

        seen.Add(node);

        if(!graph.ContainsKey(node)) return;

        foreach(var neighbor in graph[node]) {
            if(!seen.Contains(neighbor)) {
                DFS(neighbor, seen, graph);
            }
        }

    }

}


// 0 -> [1]
// 1 -> [2]
// 3 -> [4]


// O(n*e)