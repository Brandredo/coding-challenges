public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        // Solution 1: Dictionary Frequency + Sort values descending
        // var freq = new Dictionary<int,int>();

        // foreach(var num in nums) {
        //     if(!freq.ContainsKey(num)) {
        //         freq.Add(num,0);
        //     }

        //     freq[num]++;
        // }

        // int[] result = new int[k];
        // int i = 0;
        // foreach(var kvp in freq.OrderByDescending(entry => entry.Value)) {
        //     if(i == k) break;
        //     result[i] = kvp.Key;
        //     i++;
        // }

        // return result;

        // Solution 2: Heap/Priority Queue

        // (1,1) -> [1:1]
        // (2,2) -> [1:1, 2:2]
        // ()


        

        PriorityQueue<int,int> pq = new PriorityQueue<int,int>();
        Dictionary<int,int> freq = new Dictionary<int,int>();
        foreach(var num in nums) {
            if(!freq.ContainsKey(num)) {
                freq.Add(num,0);
            }

            freq[num]++;
        }

        foreach(var kvp in freq) {

            pq.Enqueue(element: kvp.Key, priority: kvp.Value);

            if(pq.Count > k) {
                pq.Dequeue();
            }

        }

        int[] result = new int[k];
        while (pq.TryDequeue(out int element, out int priority))
        {
            result[--k] = element;
        }

        return result;
    }
}
