//Link - https://leetcode.com/problems/search-in-a-sorted-array-of-unknown-size/

// Time Complexity : O(log(n))
// Space Complexity : O(1)
// Did this code successfully run on Leetcode : Yes
// Any problem you faced while coding this : No

// Approach - I initially take the values of low = 0 and high = 1. Until reader.get(high) > target, I multiply high by 2
// and set low to previous value of high. I then perform binary search with the low and high values obtained.

/**
 * // This is ArrayReader's API interface.
 * // You should not implement it, or speculate about its implementation
 * class ArrayReader {
 *     public int Get(int index) {}
 * }
 */

class Solution
{
    public int Search(ArrayReader reader, int target)
    {
        int low = 0, high = 1;

        while (target > reader.get(high))
        {
            low = high;
            high = high * 2;
        }

        return bSearch(reader, low, high, target);
    }

    public int bSearch(ArrayReader reader, int low, int high, int target)
    {
        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (reader.get(mid) == target)
            {
                return mid;
            }

            else if (reader.get(mid) < target)
            {
                low = mid + 1;
            }

            else
            {
                high = mid - 1;
            }
        }

        return -1;
    }
}