# 1732. Find the Highest Altitude

**Difficulty:** Easy
| **Platform:** LeetCode | **Status:** Solved |
| :--- | :--- |

[Link to Problem on LeetCode](https://leetcode.com/problems/find-the-highest-altitude/)

## Problem Description

There is a biker going on a road trip. The road trip consists of `n + 1` points labeled from `0` to `n`. You are given an integer array `gain` of length `n` where `gain[i]` is the net gain in altitude between points `i` and `i + 1` for all `0 <= i < n`.

Return *the highest altitude of a point*. The altitude of point `0` is `0`.

### Example 1:

**Input:** gain = [-5,1,5,0,-7]
**Output:** 1
**Explanation:** The altitudes are [0,-5,-4,1,1,-6]. The highest is 1.

### Example 2:

**Input:** gain = [-4,-3,-2,-1,4,3,2]
**Output:** 0
**Explanation:** The altitudes are [0,-4,-7,-9,-10,-6,-3,-1]. The highest is 0.

## Solution Analysis (Java / C# / Python)

The task is to compute cumulative altitude changes and keep track of the maximum value seen so far. A single pass over the `gain` array suffices, updating a running `current` altitude and updating `max` whenever `current` exceeds it.

* [Solution.java](./Solution.java)
* [Solution.cs](./Solution.cs)
* [Solution.py](./Solution.py)

### Key Concepts

* **Prefix Sum / Running Total:** We iterate through `gain`, adding each element to `currentAltitude` (or its language equivalent).
* **Track Maximum:** After updating `current`, we compare it with `max` and update `max` if larger. The starting altitude (0) is accounted for implicitly by initializing `max` and `current` to 0.
* **Performance:**
    * **Time Complexity:** `O(N)` since we traverse the `gain` list exactly once.
    * **Space Complexity:** `O(1)` — only a couple of integer variables are used, and no additional data structures are needed.