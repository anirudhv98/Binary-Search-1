//Link - https://leetcode.com/problems/search-in-rotated-sorted-array/

// Time Complexity : O(log(n))
// Space Complexity : O(1)
// Did this code successfully run on Leetcode : Yes
// Any problem you faced while coding this : No

// Approach - Since the array is rotated around a pivot, either the left portion of it will be sorted or the right portion.
// If the left portion is sorted(elements from low to mid), I check if target element lies in that range. Similarly, I 
// check if target element lies in the range of elements in right portion if that part is sorted. I then perform binary
// search to search for the element.


public class Solution
{
    public int Search(int[] nums, int target)
    {
        int low = 0, high = nums.Length - 1;
        int result = -1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (nums[mid] == target)
            {
                return mid;
            }

            //left sorted array
            else if (nums[low] <= nums[mid])
            {
                if (nums[low] <= target && target < nums[mid])
                {
                    high = mid - 1;
                }

                else
                {
                    low = mid + 1;
                }
            }

            //right sorted array
            else
            {
                if (nums[mid] < target && target <= nums[high])
                {
                    low = mid + 1;
                }

                else
                {
                    high = mid - 1;
                }
            }

        }

        return -1;

    }
}