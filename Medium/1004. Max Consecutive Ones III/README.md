# 1004. Max Consecutive Ones III

**Difficulty:** Medium
| **Platform:** LeetCode | **Status:** Solved |
| :--- | :--- |

[Link to Problem on LeetCode](https://leetcode.com/problems/max-consecutive-ones-iii/)

## Problem Description

Given a binary array `nums` and an integer `k`, return the maximum number of consecutive `1`'s in the array if you can flip at most `k` `0`'s.

### Example 1:

**Input:** nums = [1,1,1,0,0,0,1,1,1,1,0], k = 2
**Output:** 6
**Explanation:** [1,1,1,0,0,**1**,1,1,1,1,**1**]
Bolded numbers were flipped from 0 to 1. The longest subarray is underlined.

### Example 2:

**Input:** nums = [0,0,1,1,0,0,1,1,1,0,1,1,0,0,0,1,1,1,1], k = 3
**Output:** 10
**Explanation:** [0,0,1,1,**1**,**1**,1,1,1,**1**,1,1,0,0,0,1,1,1,1]
Bolded numbers were flipped from 0 to 1. The longest subarray is underlined.

## Solution Analysis (Java / C# / Python)

The problem asks for the longest contiguous subarray that contains at most `k` zeros. This is a classic application of the **Sliding Window** technique.

- [Solution.java](./Solution.java)
- [Solution.cs](./Solution.cs)
- [Solution.py](./Solution.py)

### Key Concepts

- **Sliding Window:** We maintain a window defined by two pointers, `left` and `right`. The window expands to the right (`right++`) and shrinks from the left (`left++`) only when the condition is violated.
- **Condition:** The number of `0`s inside the window `[left, right]` must be less than or equal to `k`.
- **The Algorithm:**

  1.  Initialize `left`, `right`, and `zeros` count to 0.
  2.  Iterate `right` from 0 to the end of the array.
  3.  If `nums[right]` is `0`, increment the `zeros` counter.
  4.  **While** `zeros > k`: This means our window is invalid. We must shrink it from the left.
      - If `nums[left]` is `0`, decrement the `zeros` counter (since we are discarding a zero).
      - Increment `left`.
  5.  At each step (after ensuring the window is valid), update the `maxCounter` with the current window size (`right - left + 1`).

- **Performance:**
  - **Time Complexity:** `O(N)`, where `N` is the number of elements in `nums`. Both `left` and `right` pointers traverse the array at most once.
  - **Space Complexity:** `O(1)`. We only use a few integer variables to maintain the state.
