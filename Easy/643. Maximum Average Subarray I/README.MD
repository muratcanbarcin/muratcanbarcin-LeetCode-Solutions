# 643. Maximum Average Subarray I

**Difficulty:** Easy
| **Platform:** LeetCode | **Status:** Solved |
| :--- | :--- |

[Link to Problem on LeetCode](https://leetcode.com/problems/maximum-average-subarray-i/)

## Problem Description

You are given an integer array `nums` consisting of `n` elements, and an integer `k`.

Find a contiguous subarray whose length is equal to `k` that has the maximum average value and return this value. Any answer with a calculation error less than `10^-5` will be accepted.

### Example 1:

**Input:** nums = [1,12,-5,-6,50,3], k = 4
**Output:** 12.75000
**Explanation:** Maximum average is (12 - 5 - 6 + 50) / 4 = 51 / 4 = 12.75

### Example 2:

**Input:** nums = [5], k = 1
**Output:** 5.00000

## Solution Analysis (Java / C# / Python)

The problem asks for the maximum average of a contiguous subarray of length `k`. This is a classic application of the **Sliding Window** technique.

- [Solution.java](./Solution.java)
- [Solution.cs](./Solution.cs)
- [Solution.py](./Solution.py)

### Key Concepts

- **Sliding Window:** Instead of calculating the sum of every possible subarray of length `k` from scratch (which would be `O(N*k)`), we maintain a running sum.
  1.  Calculate the sum of the first `k` elements. This initializes our window.
  2.  Slide the window one step to the right:
      - Add the new element entering the window (`nums[i]`).
      - Subtract the element leaving the window (`nums[i-k]`).
  3.  Update the maximum sum found so far.
- **Integer Arithmetic vs. Floating Point:** It is more efficient and accurate to track the **sum** (integer) throughout the loop and perform the division by `k` only once at the very end. Repeated floating-point division inside the loop is computationally more expensive and can introduce precision errors.

- **Performance:**
  - **Time Complexity:** `O(N)`, where `N` is the number of elements in `nums`. We iterate through the array once.
  - **Space Complexity:** `O(1)`. We only use a few variables to store the current sum and maximum sum.
