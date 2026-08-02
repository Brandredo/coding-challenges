public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        
        int N = nums.Length;
        int[] leftToRight = new int[N];
        int[] rightToLeft = new int[N];

        Array.Fill(leftToRight, 1);
        Array.Fill(rightToLeft, 1);

        for(int i = 1; i < N; i++) {
            leftToRight[i] = nums[i-1] * leftToRight[i-1];
        }

        for(int j = N - 2; j >= 0; j--) {
            rightToLeft[j] = nums[j+1] * rightToLeft[j+1];
        }

        for(int k = 0; k < N; k++) {
            nums[k] = leftToRight[k] * rightToLeft[k];
        }

        return nums;


    }
}

// left[i] = nums[i-1] * productleft[i-1]
// [1,2,4,6]


// [ 1, 1,2,8] from left to right
// [48,24,6,1] from right to left

// [48,24,12,8]


// [-1,1,2]

// [2,-2,-1]

// [-1,-1,1]
// [1,1,1]
