# 238. Product of Array Except Self

**Difficulty:** Medium
| **Platform:** LeetCode | **Status:** Solved |
| :--- | :--- |

[Link to Problem on LeetCode](https://leetcode.com/problems/product-of-array-except-self/)

## Problem Description

Given an integer array `nums`, return an array `answer` such that `answer[i]` is equal to the product of all the elements of `nums` except `nums[i]`.

The product of any prefix or suffix of `nums` is guaranteed to fit in a 32-bit integer.

You must write an algorithm that runs in **`O(n)` time** and **without using the division operation**.

**Follow up:** Can you solve the problem in `O(1)` extra space complexity? (The output array does not count as extra space for space complexity analysis.)

### Example 1:

**Input:** nums = [1,2,3,4]
**Output:** [24,12,8,6]

### Example 2:

**Input:** nums = [-1,1,0,-3,3]
**Output:** [0,0,9,0,0]

## Solution Analysis (Java / C# / Python)

This problem requires finding the product of all elements except the current one, without using division. The key insight is that the product for any element `i` is the product of all elements to its *left* multiplied by the product of all elements to its *right*.

`answer[i] = (product of left side) * (product of right side)`

The `O(1)` extra space constraint (excluding the output array) prevents us from creating separate "prefix" and "postfix" arrays. We solve this by using a **two-pass** approach, cleverly using the `answer` array itself for intermediate storage.

* [Solution.java](./Solution.java)
* [Solution.cs](./Solution.cs)
* [Solution.py](./Solution.py)

### Key Concepts
* **Pass 1: Left-to-Right (Prefix Products)**
    1.  We initialize `answer[0] = 1` (as there are no elements to the left of the first element).
    2.  We iterate from `i = 1` to `n-1`.
    3.  In this pass, we set `answer[i]` to be the product of all elements to the *left* of `i`.
    4.  This is achieved by `answer[i] = answer[i-1] * nums[i-1]`.
    * *Example `[1,2,3,4]`*: After Pass 1, `answer` is `[1, 1, 2, 6]`.

* **Pass 2: Right-to-Left (Postfix Products)**
    1.  We introduce a single variable, `rightProduct`, and initialize it to `1` (as there are no elements to the right of the last element).
    2.  We iterate backward from `i = n-1` down to `0`.
    3.  For each element `i`, we perform two steps:
        a.  `answer[i] = answer[i] * rightProduct`: We multiply the existing value in `answer[i]` (which is the *prefix product* from Pass 1) by the current `rightProduct` (the *postfix product*). This gives us the final value.
        b.  `rightProduct = rightProduct * nums[i]`: We update the `rightProduct` to include the current element for the next iteration (moving left).
    * *Example `[1,2,3,4]`*:
        * `i=3`: `answer[3] = 6 * 1 = 6`. `rightProduct` becomes `4`.
        * `i=2`: `answer[2] = 2 * 4 = 8`. `rightProduct` becomes `12`.
        * `i=1`: `answer[1] = 1 * 12 = 12`. `rightProduct` becomes `24`.
        * `i=0`: `answer[0] = 1 * 24 = 24`. `rightProduct` becomes `24`.

* **Final Result:** The `answer` array `[24, 12, 8, 6]` is returned.

* **Performance:**
    * **Time Complexity:** `O(N) + O(N) = O(N)`. We perform two separate passes through the array.
    * **Space Complexity:** `O(1)` (extra space). The output array `answer` is not counted as extra space per the problem's follow-up. The only extra variable is `rightProduct`.