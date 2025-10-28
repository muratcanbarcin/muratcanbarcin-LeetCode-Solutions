# 3354. Make Array Elements Equal to Zero

**Difficulty:** Easy
| **Platform:** LeetCode | **Status:** Solved |
| :--- | :--- |

[Link to Problem on LeetCode](https://leetcode.com/problems/make-array-elements-equal-to-zero/)

## Problem Description

You are given an integer array `nums`.

Start by selecting a starting position `curr` such that `nums[curr] == 0`, and choose a movement direction of either left or right.

After that, you repeat the following process:

1.  If `curr` is out of the range `[0, n - 1]`, this process ends.
2.  If `nums[curr] == 0`, move in the current direction (increment/decrement `curr`).
3.  Else if `nums[curr] > 0`:
    * Decrement `nums[curr]` by 1.
    * Reverse your movement direction (left becomes right and vice versa).
    * Take a step in your new direction.

A selection of the initial `curr` and movement direction is considered **valid** if every element in `nums` becomes 0 by the end of the process.

Return the *number of possible valid selections*.

### Example 1:

**Input:** nums = [1,0,2,0,3]
**Output:** 2
**Explanation:** The valid selections are (start=3, dir=left) and (start=3, dir=right).

### Example 2:

**Input:** nums = [2,3,4,0,4,1,0]
**Output:** 0
**Explanation:** There are no possible valid selections.

## Solution Analysis (Java)

The solution provided implements a **direct simulation** of the process described in the problem.

* [Solution.java](./Solution.java)

### Key Concepts
* **Brute-Force Simulation:** The problem constraints (`N <= 100`, `nums[i] <= 100`) are small enough that optimizing the simulation (as attempted in our discussion) is unnecessary and incorrect. The correct approach is to simulate the process exactly as described.
* **Test All Scenarios:** The main function iterates through every possible starting position `i` where `nums[i] == 0`. For each valid start, it runs the simulation twice: once moving left (`-1`) and once moving right (`+1`).
* **Work on a Copy:** This is the most critical part. Each simulation (`isSelectionValid`) must run on a *copy* of the original array (`Arrays.copyOf()`). If we modify the original `nums` array, the test for `dir=left` would invalidate the test for `dir=right`.
* **Direct Logic:** The simulation logic inside the `while` loop follows the problem description exactly:
    1.  Check if `curr` is within bounds (`0 <= curr < n`).
    2.  If `nums[curr] > 0`: Decrement `nums[curr]`, flip `dir = -dir`, and move `curr += dir`.
    3.  If `nums[curr] == 0`: Just move `curr += dir`.
* **Loop Prevention:** A `maxSteps` counter is included as a safeguard to prevent any potential (though unlikely given the problem logic) infinite loops, which would cause a "Time Limit Exceeded" (TLE) error.
* **Final Check:** After the simulation ends (by `curr` going out of bounds), the function iterates through the *copied* array one last time to ensure every element has successfully been reduced to `0`.
* **Performance:**
    * **Time Complexity:** `O(N * S)`, where `N` is the length of the array and `S` is the total sum of all numbers in `nums`. Each simulation takes at(most) `O(S*N)` steps in the worst case, and we run `O(N)` simulations. Given `N<=100` and `Sum<=10,000`, the total operations are well within LeetCode's time limits.
    * **Space Complexity:** `O(N)` for each simulation, required to store the `Arrays.copyOf()` of the `nums` array.