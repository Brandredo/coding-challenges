// T: O(n)
// S: O(n)
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        if(nums.Length == 0) {
            return new int[0];
        }

        var map = new Dictionary<int, int>();

        // [5,5]
        // [(5,0)]
        for(int i = 0; i < nums.Length; i++) {

            int diff = target - nums[i];

            if(!map.ContainsKey(diff)) {
                map.Add(nums[i], i);
            } else {
                return new int[2] { map[diff], i };
            }

        }

        return new int[0];
    }
}
