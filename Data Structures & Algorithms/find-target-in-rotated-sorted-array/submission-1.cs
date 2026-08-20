public class Solution {
    public int Search(int[] nums, int target) {
        
        int left = 0;
        int right = nums.Length - 1;

        while(left <= right) {

            int mid = left + (right - left) / 2;

            Console.WriteLine($"{left}, {mid}, {right}");

            if(nums[mid] == target) {
                return mid;
            }

            if(nums[left] <= nums[mid]) {
                // left half is sorted
                if(nums[left] <= target && target < nums[mid]) {
                    right = mid - 1;
                } else {
                    left = mid + 1;
                }
            } else {
                // right half is sorted
                if(nums[mid] < target && target <= nums[right]) {
                    left = mid + 1;
                } else {
                    right = mid - 1;
                }
            }

        }

        if(left >= nums.Length || nums[left] != target) return -1;

        return left;
        
    }
}
