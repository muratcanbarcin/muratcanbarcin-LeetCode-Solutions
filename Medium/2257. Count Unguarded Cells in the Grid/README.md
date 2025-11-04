# 2257. Count Unguarded Cells in the Grid

**Difficulty:** Medium
| **Platform:** LeetCode | **Status:** Solved |
| :--- | :--- |

[Link to Problem on LeetCode](https://leetcode.com/problems/count-unguarded-cells-in-the-grid/)

## Problem Description

You are given two integers `m` and `n` representing a 0-indexed `m x n` grid. You are also given two 2D integer arrays `guards` and `walls` where `guards[i] = [rowi, coli]` and `walls[j] = [rowj, colj]` represent the positions of the `i`th guard and `j`th wall respectively.

A guard can see every cell in the four cardinal directions (north, east, south, or west) starting from their position unless obstructed by a wall or another guard. A cell is guarded if there is at least one guard that can see it.

Return the *number of unoccupied cells that are not guarded*.

### Example 1:

**Input:** m = 4, n = 6, guards = [[0,0],[1,1],[2,3]], walls = [[0,1],[2,2],[1,4]]
**Output:** 7
**Explanation:** The guarded and unguarded cells are shown in red and green respectively in the above diagram. There are a total of 7 unguarded cells, so we return 7.

### Example 2:

**Input:** m = 3, n = 3, guards = [[1,1]], walls = [[0,1],[1,0],[2,1],[1,2]]
**Output:** 4
**Explanation:** The unguarded cells are shown in green in the above diagram. There are a total of 4 unguarded cells, so we return 4.

## Solution Analysis (Java / C#)

Attempting to solve this problem by casting rays from each guard in 4 directions (`O(NumGuards * (m+n))`) will lead to a "Time Limit Exceeded" (TLE) error, as `m` or `n` can be very large.

The correct, optimized approach is a **"Stateful Scan"** method that runs in `O(m*n)` complexity.

* [Solution.java](./Solution.java)
* [Solution.cs](./Solution.cs)

### Key Concepts
* **Grid States:** We use integer values to track the state of each cell:
    * `0`: `EMPTY`
    * `1`: `GUARD`
    * `2`: `WALL`
    * `3`: `GUARDED` (Marked by our scan)
* **Initial Setup:** First, we place all walls (`2`) and guards (`1`) onto the grid.
* **4-Directional Scan:** We scan the grid 4 times:
    1.  **Left-to-Right:** For each row, we iterate from left to right. We maintain an `isGuarded` flag.
        * If we see a `GUARD`, `isGuarded` becomes `true`.
        * If we see a `WALL`, `isGuarded` becomes `false` (sight is blocked).
        * If the cell is `EMPTY` (`0`) and `isGuarded == true`, we mark this cell as `GUARDED` (`3`).
    2.  **Right-to-Left:** We repeat the same logic for each row, iterating from right to left.
    3.  **Top-to-Bottom:** We repeat the same logic for each column, iterating from top to bottom.
    4.  **Bottom-to-Top:** We repeat the same logic for each column, iterating from bottom to top.
* **Final Count:** After these 4 scans are complete, we traverse the grid one last time. We count all cells that remain `EMPTY` (`0`). These are the cells that are not seen by any guard and are not walls/guards themselves.

* **Performance:**
    * **Time Complexity:** `O(m * n)`. We scan the grid 4 times (`O(4 * m * n)`) and once more for the final count (`O(m*n)`). This simplifies to `O(m*n)`.
    * **Space Complexity:** `O(m * n)`. We require an `m x n` grid to store the states.