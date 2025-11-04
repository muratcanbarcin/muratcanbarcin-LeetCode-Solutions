# 334. Increasing Triplet Subsequence

**Difficulty:** Medium
| **Platform:** LeetCode | **Status:** Solved |
| :--- | :--- |

[Link to Problem on LeetCode](https://leetcode.com/problems/increasing-triplet-subsequence/)

## Problem Description

Given an integer array `nums`, return `true` if there exists a triple of indices `(i, j, k)` such that `i < j < k` and `nums[i] < nums[j] < nums[k]`. If no such indices exists, return `false`.

### Example 1:

**Input:** nums = [1,2,3,4,5]
**Output:** true
**Explanation:** Any triplet where i < j < k is valid.

### Example 2:

**Input:** nums = [5,4,3,2,1]
**Output:** false
**Explanation:** No triplet exists.

### Example 3:

**Input:** nums = [2,1,5,0,4,6]
**Output:** true
**Explanation:** One of the valid triplet is (3, 4, 5), because nums[3] == 0 < nums[4] == 4 < nums[5] == 6.

## Solution Analysis (Java / C# / Python)

This problem can be solved with a "greedy" approach in `O(n)` time and `O(1)` space complexity.

The key insight is that we don't need to track the indices `i`, `j`, and `k`. We only need to maintain the *smallest possible values* for the first (`nums[i]`) and second (`nums[j]`) elements of a potential triplet as we iterate through the array.

* [Solution.java](./Solution.java)
* [Solution.cs](./Solution.cs)
* [Solution.py](./Solution.py)

### Key Concepts
* **Greedy `O(1)` Space:** We use two variables, `first_min` and `second_min`, initialized to infinity (`Integer.MAX_VALUE`).
    * `first_min`: Stores the smallest number encountered so far (a candidate for `nums[i]`).
    * `second_min`: Stores the smallest number that is *greater than* `first_min` (a candidate for `nums[j]`).
* **Single-Pass Iteration:** We iterate through each `num` in the `nums` array:
    1.  **`if (num <= first_min)`:** If the current number is smaller than or equal to `first_min`, it's a better (smaller) candidate for the *first* number in a new triplet. We update `first_min = num`.
    2.  **`else if (num <= second_min)`:** If the number is larger than `first_min` but smaller than or equal to `second_min`, it's a better (smaller) candidate for the *second* number. We update `second_min = num`.
    3.  **`else`:** If the number is greater than *both* `first_min` and `second_min`, we have found our triplet (`first_min < second_min < num`). We can immediately return `true`.
* **How it Handles `[2, 1, 5, 0, 4, 6]`:**
    * `num=2`: `first_min = 2`
    * `num=1`: `first_min = 1`
    * `num=5`: `second_min = 5` (Potential triplet: `1, 5, ?`)
    * `num=0`: `first_min = 0` (We found a *new* smallest number. `second_min` remains `5`, holding the "memory" that a number smaller than `5` (i.e., `1`) existed).
    * `num=4`: `second_min = 4` (We update `second_min` because `4` is better than `5`, and it's still larger than the current `first_min` of `0`. Potential triplet: `0, 4, ?`)
    * `num=6`: `num > second_min` (since `6 > 4`). We return `true`.

* **Performance:**
    * **Time Complexity:** `O(N)`. We iterate through the `nums` array only once.
    * **Space Complexity:** `O(1)`. We only use two extra variables (`first_min` and `second_min`).