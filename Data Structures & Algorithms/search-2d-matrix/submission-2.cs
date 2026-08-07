public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        
        int m = matrix.Length;
        int n = matrix[0].Length;
        int left = 0;
        int right = m * n - 1;

        while(left <= right) { // l = 3, r = 4

            int mid = left + (right - left) / 2; // 3

            int row = mid / n; // 1
            int col = mid % n; // 3

            if(matrix[row][col] == target) {
                return true;
            } else if(matrix[row][col] > target) {
                right = mid - 1;
            } else {
                left = mid + 1; 
            }

        }

        return false;

    }
}


// 0 1 2 3  0  1 2  3  0   1  2  3 
// 1,2,4,8,10,11,12,13,14,20,30,40
// 0        1          2


// m = rows
// n = columns

// left = 0
// right = m * n - 1


// mid = left + (right - left) / 2 -> 

// index 5 -> m = 1, n = 1

// index / m -> row
// index % n -> col

