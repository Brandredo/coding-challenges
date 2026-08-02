public class Solution {
    public int MaxArea(int[] heights) {
        

        int left = 0;
        int right = heights.Length - 1;
        int maxWater = 0;

        // [1,7,2,5,4,7,3,6]
        //.   l     r
        while(left < right) {

            int containerWater = Math.Min(heights[left], heights[right]) * (right - left);

            maxWater = Math.Max(maxWater, containerWater); // 36

            if(heights[left] < heights[right]) {
                left++;
            } else {
                right--;
            }

        }

        return maxWater;

    }
}
