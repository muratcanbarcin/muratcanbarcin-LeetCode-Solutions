# 1526. Minimum Number of Increments on Subarrays to Form a Target Array

**Difficulty:** Hard
| **Platform:** LeetCode | **Status:** Solved |
| :--- | :--- |

[Link to Problem on LeetCode](https://leetcode.com/problems/minimum-number-of-increments-on-subarrays-to-form-a-target-array/)

## Problem Description

You are given an integer array `target`. You have an integer array `initial` of the same size as `target` with all elements initially zeros.

In one operation, you can choose any **subarray** from `initial` and increment each value by one.

Return the *minimum number of operations* to form a `target` array from `initial`.

### Example 1:

**Input:** target = [1,2,3,2,1]
**Output:** 3
**Explanation:**
[0,0,0,0,0] -> [1,1,1,1,1] (op 1: from index 0 to 4)
[1,1,1,1,1] -> [1,2,2,2,1] (op 2: from index 1 to 3)
[1,2,2,2,1] -> [1,2,3,2,1] (op 3: at index 2)
Target array is formed.

### Example 2:

**Input:** target = [3,1,1,2]
**Output:** 4

### Example 3:

**Input:** target = [3,1,5,4,2]
**Output:** 7

## Solution Analysis (Java)

This problem, while labeled "Hard," has a very elegant and simple `O(N)` solution once the core insight is understood. The solution provided uses this "peak climbing" logic.

* [Solution.java](./Solution.java)

### Key Concepts: "Peak Climbing" Logic

The problem can be re-imagined as finding the cost to "build" the array from left to right, where we only pay a cost when we "climb" (increase the value).

1.  **Core Insight:** Any "increment" operation on a subarray (e.g., from index `i` to `j`) will set all elements in that subarray to the same level. When we move to `target[i+1]`, if it's *smaller* than `target[i]`, we don't need new operations; the operations used to build `target[i]` already cover `target[i+1]`.
2.  **The Algorithm:** We only need to sum the "uphill" movements.
    * `target = [1, 2, 3, 2, 1]`
    * **`target[0] = 1`:** We must climb from `0` to `1`. Cost: `1`. (Total Ops: 1)
    * **`target[1] = 2`:** We must climb from `1` to `2`. Cost: `2 - 1 = 1`. (Total Ops: 2)
    * **`target[2] = 3`:** We must climb from `2` to `3`. Cost: `3 - 2 = 1`. (Total Ops: 3)
    * **`target[3] = 2`:** We are at level `3`, and we need to go to `2`. This is "downhill". No cost is incurred. (Total Ops: 3)
    * **`target[4] = 1`:** We are at level `2`, and we need to go to `1`. This is "downhill". No cost. (Total Ops: 3)
    * **Final Result:** 3.

3.  **Implementation:**
    * The Java solution initializes `totalOperations = target[0]` (the cost of the first climb from 0).
    * It then iterates from `i = 1`.
    * If `target[i] > target[i - 1]` (an "uphill" move), it adds the difference (`target[i] - target[i - 1]`) to the total.
    * If `target[i] <= target[i - 1]` (a "downhill" or "flat" move), it adds nothing.

* **Performance:**
    * **Time Complexity:** `O(N)`, where `N` is the length of the `target` array. We iterate through the array only once.
    * **Space Complexity:** `O(1)`. We only use a few variables to store the total.