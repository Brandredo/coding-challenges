public class Solution {
    public bool hasDuplicate(int[] nums) {
        
        if(nums == null || nums.Length == 0) return false;

        var uniqueElements = new HashSet<int>();
        
        foreach(var num in nums) {
            if(uniqueElements.Contains(num)) return true;
            uniqueElements.Add(num);
        }

        return false;
    }
}