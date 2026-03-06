# 1493. Longest Subarray of 1's After Deleting One Element

**Difficulty:** Medium
| **Platform:** LeetCode | **Status:** Solved |
| :--- | :--- |

[Link to Problem on LeetCode](https://leetcode.com/problems/longest-subarray-of-1s-after-deleting-one-element/)

## Problem Description

Given a binary array `nums`, you need to find the **longest contiguous subarray** of 1's that you could create by deleting **exactly one element**.

Return _the size of the longest contiguous subarray of 1's that you could create by deleting exactly one element from the original array_.

### Example 1:

**Input:** nums = [1,1,0,1]
**Output:** 3
**Explanation:** After deleting the number in position 2, [1,1,1] has the longest contiguous of 1's with count equal to 3.

### Example 2:

**Input:** nums = [0,1,1,1,0,1,1,0,1]
**Output:** 5
**Explanation:** After deleting the number in position 4, [0,1,1,1,1,1,0,1] longest contiguous of 1's with count equal to 5.

### Example 3:

**Input:** nums = [1,1,1]
**Output:** 2
**Explanation:** You must delete exactly one element. After deleting any element, the longest contiguous of 1's will be 2. Since we need to delete exactly one element, if the entire array is composed of 1's, we must still delete one, resulting in n-1.

## Solution Analysis (Java / C# / Python)

The most efficient solution uses the **Sliding Window** technique with **two pointers**. The key insight is that we want to find the longest window that contains *at most one zero*. By deleting that one zero, we get a contiguous array of 1's.

- [Solution.java](./Solution.java)
- [Solution.cs](./Solution.cs)
- [Solution.py](./Solution.py)

### Key Concepts

- **Sliding Window Approach with At Most One Zero:**
  1. We maintain a window `[left, right]` that contains **at most one zero**.
  2. As we expand the window to the right (`right` pointer), we count the zeros.
  3. If the window contains more than one zero, we shrink it from the left (`left` pointer) until we have at most one zero again.
  4. At each step, the valid window size is `right - left + 1 - zeros` (total length minus the count of zeros).

- **Why Subtract Zeros from Window Size:**
  - The window size includes both 1's and 0's.
  - `right - left + 1` gives the total length of the current window.
  - Subtracting the count of zeros gives us the number of 1's in the window.
  - This represents the subarray of 1's we would get if we deleted the single zero.

- **Edge Case - All 1's:**
  - If the entire array is composed of 1's (ans == n), we must still delete exactly one element, so we return `n - 1`.
  - Otherwise, we return `ans`, which already accounts for the deleted zero.

- **Performance:**
  - **Time Complexity:** `O(N)`. Both pointers traverse the array at most once.
  - **Space Complexity:** `O(1)`. We only use a few variables (`left`, `right`, `zeros`, `ans`).

### Walkthrough Example

For `nums = [0,1,1,1,0,1,1,0,1]`:

| Step | right | nums[right] | zeros | Window [left, right] | Window Size - Zeros | ans |
|:---:|:---:|:---:|:---:|:---:|:---:|:---:|
| 1 | 0 | 0 | 1 | [0, 0] | 0 | 0 |
| 2 | 1 | 1 | 1 | [0, 1] | 1 | 1 |
| 3 | 2 | 1 | 1 | [0, 2] | 2 | 2 |
| 4 | 3 | 1 | 1 | [0, 3] | 3 | 3 |
| 5 | 4 | 0 | 2 | Shrink: [1, 4] | 3 | 3 |
| 6 | 5 | 1 | 2 | Shrink: [2, 5] | 3 | 3 |
| 7 | 6 | 1 | 2 | Shrink: [3, 6] | 3 | 3 |
| 8 | 7 | 0 | 3 | Shrink until zeros ≤ 1: [5, 7] | 2 | 3 |
| 9 | 8 | 1 | 2 | Shrink: [6, 8] | 2 | 5 |

**Final Answer:** 5 (corresponding to the subarray [1,1,1,1,1] at indices [3,4,5,6,8] if we delete the zero at index 7).
