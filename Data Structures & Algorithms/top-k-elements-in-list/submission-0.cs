public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        var freq = new Dictionary<int,int>();

        foreach(var num in nums) {
            if(!freq.ContainsKey(num)) {
                freq.Add(num,0);
            }

            freq[num]++;
        }

        int[] result = new int[k];
        int i = 0;
        foreach(var kvp in freq.OrderByDescending(entry => entry.Value)) {
            if(i == k) break;
            result[i] = kvp.Key;
            i++;
        }

        return result;

    }
}
