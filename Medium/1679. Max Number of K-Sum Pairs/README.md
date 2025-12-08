# 1679. Max Number of K-Sum Pairs

**Difficulty:** Medium
| **Platform:** LeetCode | **Status:** Solved |
| :--- | :--- |

[Link to Problem on LeetCode](https://leetcode.com/problems/max-number-of-k-sum-pairs/)

## Problem Description

You are given an integer array `nums` and an integer `k`.

In one operation, you can pick two numbers from the array whose sum equals `k` and remove them from the array.

Return the _maximum number of operations_ you can perform on the array.

### Example 1:

**Input:** nums = [1,2,3,4], k = 5
**Output:** 2
**Explanation:** - Remove 1 and 4 (1 + 4 = 5). nums becomes [2,3].

- Remove 2 and 3 (2 + 3 = 5). nums becomes [].
  Total 2 operations.

### Example 2:

**Input:** nums = [3,1,3,4,3], k = 6
**Output:** 1
**Explanation:** - Remove 3 and 3. nums becomes [1,4,3].
There are no more pairs that sum up to 6. Total 1 operation.

## Solution Analysis (Java / C# / Python)

This problem asks us to find pairs that sum up to a target `k`. There are two main approaches: using a Frequency Map (HashMap) or Sorting with Two Pointers. The solution provided here uses the **Sorting + Two Pointers** approach to optimize for space complexity.

- [Solution.java](./Solution.java)
- [Solution.cs](./Solution.cs)
- [Solution.py](./Solution.py)

### Key Concepts

- **Sorting:** First, we sort the array in ascending order. This allows us to make decisions about which numbers to pair based on their magnitude.
- **Two Pointers:** We place one pointer at the beginning (`left`) and one at the end (`right`) of the sorted array.

  - **Sum == k:** If `nums[left] + nums[right]` equals `k`, we found a valid pair. We increment the count and move _both_ pointers inward to discard these used numbers.
  - **Sum < k:** If the sum is less than `k`, we need a larger sum. Since the array is sorted, moving the `left` pointer to the right gives us a larger (or equal) number.
  - **Sum > k:** If the sum is greater than `k`, we need a smaller sum. Moving the `right` pointer to the left gives us a smaller (or equal) number.

- **Performance:**
  - **Time Complexity:** `O(N log N)`. This is dominated by the sorting step. The two-pointer traversal takes linear time `O(N)`.
  - **Space Complexity:** `O(1)` (or `O(log N)` depending on the sorting implementation's stack usage), as we do not use any auxiliary data structures like a HashMap to store frequencies.
