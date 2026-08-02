public class Solution {
    public int LastStoneWeight(int[] stones) {
        var heap = new PriorityQueue<int,int>(Comparer<int>.Create((a,b) => b - a));

        foreach(var stone in stones) {
            heap.Enqueue(element: stone, priority: stone);
        }

        // [1]

        while(heap.Count >= 2) {

            int x = heap.Dequeue(); // 3
            int y = heap.Dequeue(); // 2

            if(x != y) {
                int diff = Math.Abs(x - y);
                heap.Enqueue(element: diff, priority: diff);
            }

        }

        return heap.Count == 0 ? 0 : heap.Dequeue();
    }
}


// [2,3,6,2,4]


// [1]

// 6,4->2
// 3,2->1
// 2,2->destroyed
