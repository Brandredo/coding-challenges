public class Solution {
    public int[][] Merge(int[][] intervals) {
        
        List<int[]> merged = new List<int[]>();
        Array.Sort(intervals, (a,b) => a[0] - b[0]); // sort by start time

        merged.Add(intervals[0]);

        for(int i = 1; i < intervals.Length; i++) {

            if(intervals[i][0] <= merged[merged.Count - 1][1]) {
                merged[merged.Count - 1][1] = Math.Max(merged[merged.Count - 1][1], intervals[i][1]);
            } else {
                merged.Add(intervals[i]);
            }

        }

        return merged.ToArray();


    }
}
