public class Solution {
    public int FindMin(int[] nums) {
        
        int left = 0;
        int right = nums.Length - 1;

        while(left < right) {

            int mid = left + (right - left) / 2;

            if(nums[mid] < nums[right]) {
                // search left
                right = mid;
            } else {
                // search right
                left = mid + 1;
            }
            // if(nums[left] <= nums[mid]) {
            //     // left side is sorted
            // } else {
            //     // right side is sorted
            //     if(nums[mid] < nums[right]) {
            //         // search left
            //         right = mid;

            //     } else {
            //         // search right
            //         left = mid + 1;

            //     }
            // }


        }


        return nums[left];
    }
}


// find sorted side by checking left against mid
//     check mid against right
//         move to right side if mid greater than right
//     else
//         move to left