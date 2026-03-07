# 724. Find Pivot Index

**Difficulty:** Easy
| **Platform:** LeetCode | **Status:** Solved |
| :--- | :--- |

[Link to Problem on LeetCode](https://leetcode.com/problems/find-pivot-index/)

## Problem Description

Given an array of integers `nums`, calculate the **pivot index** of this array.

The **pivot index** is the index where the sum of all the numbers **strictly** to the left of the index is equal to the sum of all the numbers **strictly** to the index's right.

If the index is on the left edge of the array, then the left sum is `0` because there are no elements to the left. This also applies to the right edge of the array.

Return *the **leftmost pivot index***. If no such index exists, return `-1`.

### Example 1:

**Input:** nums = [1,7,3,6,5,6]  
**Output:** 3  
**Explanation:** The pivot index is 3.  
Left sum = nums[0] + nums[1] + nums[2] = 1 + 7 + 3 = 11  
Right sum = nums[4] + nums[5] = 5 + 6 = 11

### Example 2:

**Input:** nums = [1,2,3]  
**Output:** -1  
**Explanation:** There is no index that satisfies the conditions in the problem statement.

### Example 3:

**Input:** nums = [2,1,-1]  
**Output:** 0  
**Explanation:** The pivot index is 0.  
Left sum = 0 (no elements to the left)  
Right sum = nums[1] + nums[2] = 1 + (-1) = 0

## Solution Analysis (Java)

The solution uses a two-pass approach but optimizes it to one pass by calculating the total sum first.

- Calculate the total sum of the array.
- Initialize leftSum to 0.
- Iterate through the array:
  - Check if leftSum equals total - leftSum - nums[i] (which is the right sum).
  - If yes, return the current index.
  - Otherwise, add nums[i] to leftSum.
- If no pivot index is found, return -1.

**Time Complexity:** O(n)  
**Space Complexity:** O(1)

## Solution Analysis (C#)

Similar to Java, using LINQ for sum calculation.

- Compute total sum using `nums.Sum()`.
- Use a loop to check the pivot condition.
- Return the index or -1.

**Time Complexity:** O(n)  
**Space Complexity:** O(1)

## Solution Analysis (Python)

Uses built-in `sum()` function for total calculation.

- Iterate through the list, maintaining left_sum.
- Check the condition for each index.
- Return the index or -1.

**Time Complexity:** O(n)  
**Space Complexity:** O(1)