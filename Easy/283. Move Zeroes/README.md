# 283. Move Zeroes

**Difficulty:** Easy
| **Platform:** LeetCode | **Status:** Solved |
| :--- | :--- |

[Link to Problem on LeetCode](https://leetcode.com/problems/move-zeroes/)

## Problem Description

Given an integer array `nums`, move all `0`'s to the end of it while maintaining the relative order of the non-zero elements.

Note that you must do this **in-place** without making a copy of the array.

### Example 1:

**Input:** nums = [0,1,0,3,12]
**Output:** [1,3,12,0,0]

### Example 2:

**Input:** nums = [0]
**Output:** [0]

## Solution Analysis (Java / C# / Python)

The problem asks us to modify the array in-place, moving zeros to the back while keeping non-zero elements in their original order. The provided solution uses the **Two Pointers** technique to achieve this efficiently.

* [Solution.java](./Solution.java)
* [Solution.cs](./Solution.cs)
* [Solution.py](./Solution.py)

### Key Concepts

* **Two Pointers (Slow & Fast):**
    * `fast` pointer: Iterates through the array to find non-zero elements.
    * `slow` pointer: Tracks the position where the next non-zero element should be placed.
* **Swap Logic:**
    * We iterate through the array with the `fast` pointer.
    * Whenever `nums[fast]` is non-zero, we swap it with `nums[slow]`.
    * After the swap, we increment `slow`.
    * This effectively pushes non-zero elements to the front (to the `slow` position) and, by consequence of the swap, pushes zeros towards the `fast` pointer (eventually to the back).
* **Minimizing Operations:** By using a swap operation instead of overwriting, we handle the case where the array has no zeros (e.g., `[1, 2, 3]`) very efficiently. In that case, `slow` and `fast` are equal, and we just swap the element with itself, avoiding unnecessary writes or a second loop to fill zeros.

* **Performance:**
    * **Time Complexity:** `O(N)`, where `N` is the length of the array. We traverse the array exactly once.
    * **Space Complexity:** `O(1)`. We perform the operations in-place using only two integer variables.