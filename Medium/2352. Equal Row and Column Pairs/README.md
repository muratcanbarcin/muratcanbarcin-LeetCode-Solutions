# 2352. Equal Row and Column Pairs

**Difficulty:** Medium
| **Platform:** LeetCode | **Status:** Solved |
| :--- | :--- | 

[Link to Problem on LeetCode](https://leetcode.com/problems/equal-row-and-column-pairs/)

## Problem Description

Given an `n x n` matrix `grid`, return the number of pairs `(ri, cj)` such that row `ri` is equal to column `cj`.

- `ri` denotes the `i`-th row (0-indexed)
- `cj` denotes the `j`-th column (0-indexed)

A row and column pair are considered equal if they contain the exact same sequence of values.

### Example 1:

**Input:**
```
grid = [[3,2,1],
        [1,7,6],
        [2,7,7]]
```
**Output:** 1

### Example 2:

**Input:**
```
grid = [[3,1,2,2],
        [1,4,4,5],
        [2,4,2,2],
        [2,4,2,2]]
```
**Output:** 3

## Solution Analysis

The solution counts how many times each row appears (using a string key for Java/C# or tuple for Python). Then it iterates over each column, constructs the comparable representation, and looks up how many identical rows exist, summing those counts.

* [Solution.java](./Solution.java)
* [Solution.cs](./Solution.cs)
* [Solution.py](./Solution.py)

### Key Concepts
* **Row vs Column Representation:** Convert rows and columns into a comparable immutable form (string or tuple).
* **Hash Map / Counter:** Use a dictionary to store row frequencies for constant-time lookups when scanning columns.
* **Time Complexity:** O(n^2) for iterating through grid entries.
* **Space Complexity:** O(n^2) in the worst case (storing all row keys).

### Performance
- **Time:** O(n²)
- **Space:** O(n²)
- **Runtime:** Efficient for typical constraints (`n ≤ 200` on LeetCode).
