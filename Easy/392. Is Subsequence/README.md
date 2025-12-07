# 392. Is Subsequence

**Difficulty:** Easy
| **Platform:** LeetCode | **Status:** Solved |
| :--- | :--- |

[Link to Problem on LeetCode](https://leetcode.com/problems/is-subsequence/)

## Problem Description

Given two strings `s` and `t`, return `true` if `s` is a **subsequence** of `t`, or `false` otherwise.

A subsequence of a string is a new string that is formed from the original string by deleting some (can be none) of the characters without disturbing the relative positions of the remaining characters. (i.e., `"ace"` is a subsequence of `"abcde"` while `"aec"` is not).

### Example 1:

**Input:** s = "abc", t = "ahbgdc"
**Output:** true

### Example 2:

**Input:** s = "axc", t = "ahbgdc"
**Output:** false

## Solution Analysis (Java / C# / Python)

The provided solution uses a classic **Two Pointers** approach, which is optimal for a single check.

- [Solution.java](./Solution.java)
- [Solution.cs](./Solution.cs)
- [Solution.py](./Solution.py)

### Key Concepts

- **Two Pointers:** We use two indices (pointers):
  1.  `sIndex`: Points to the current character we are looking for in `s`.
  2.  `tIndex` (Loop variable): Iterates through the string `t`.
- **Greedy Matching:** We iterate through `t`. Whenever we find a character that matches the current character in `s` (`t[tIndex] == s[sIndex]`), we move our `sIndex` forward. This is "greedy" because we take the first valid match we find; waiting for a later occurrence of the same character never gives us an advantage in finding the subsequent characters.
- **Early Exit:** As soon as `sIndex` reaches the length of `s`, we know we have found all characters in the correct order, so we immediately return `true`.

- **Performance:**
  - **Time Complexity:** `O(T)`, where `T` is the length of the string `t`. In the worst case, we traverse `t` completely.
  - **Space Complexity:** `O(1)`. We only use a few integer variables for pointers.

### Follow-up Note

If there were **many** incoming `s` strings to check against the **same** `t` (as mentioned in the problem description), this `O(T)` approach might be too slow for each check.

In that scenario, a more efficient approach would be to **pre-process** `t`:

1.  Store the indices of each character in a Hash Map (e.g., `'a' -> [0, 5]`, `'b' -> [2]`).
2.  For each char in `s`, use **Binary Search** (Upper Bound) on the stored indices to find the next valid occurrence in `t`.
    This would reduce the query time to `O(S * log T)`.
