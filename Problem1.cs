//Link - https://leetcode.com/problems/search-a-2d-matrix/

// Time Complexity : O(log(m*n))
// Space Complexity : O(1)
// Did this code successfully run on Leetcode : Yes
// Any problem you faced while coding this : No

// Approach - I perform a binary search on the matrix, since each row is sorted in increasing order and the first integer of
// each row is greater than last integer of the previous row, I can treat it as one large sorted array and get the exact
// position of the middle element by performing mid / columns & mid % columns to get the row and column value.
public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        int rows = matrix.Length;
        int columns = matrix[0].Length;
        int low = 0, high = rows * columns - 1;

        //Binary Search
        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            int r = mid / columns;
            int c = mid % columns;
            int ele = matrix[r][c];

            if (ele == target)
            {
                return true;
            }

            else if (ele < target)
            {
                low = mid + 1;
            }

            else
            {
                high = mid - 1;
            }
        }

        return false;
    }
}