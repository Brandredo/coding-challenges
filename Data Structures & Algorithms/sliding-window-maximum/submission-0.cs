public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        
        var maxQueue = new PriorityQueue<int,int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
        var start = 0;
        var result = new List<int>();

        for(int end = 0; end < nums.Length; end++) {

            if(maxQueue.Count > 0) {

                if(nums[end] > maxQueue.Peek()) {
                    maxQueue.Clear();
                }
            }
            
            maxQueue.Enqueue(element: nums[end], priority: nums[end]);

            if(end - start + 1 == k) {
                result.Add(maxQueue.Peek());
                
                // leaving stage
                if(maxQueue.Count > 0 && nums[start] == maxQueue.Peek()) {
                    maxQueue.Dequeue();
                }
                
                start++;
            }



        }

        return result.ToArray();


    }
}
