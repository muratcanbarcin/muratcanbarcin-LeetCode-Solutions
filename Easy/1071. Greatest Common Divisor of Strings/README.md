# 1071. Greatest Common Divisor of Strings

**Difficulty:** Easy
| **Platform:** LeetCode | **Status:** Solved |
| :--- | :--- |

[Link to Problem on LeetCode](https://leetcode.com/problems/greatest-common-divisor-of-strings/)

## Problem Description

For two strings `s` and `t`, we say "t divides s" if and only if `s = t + t + t + ... + t` (i.e., `t` is concatenated with itself one or more times).

Given two strings `str1` and `str2`, return the *largest* string `x` such that `x` divides both `str1` and `str2`.

### Example 1:

**Input:** str1 = "ABCABC", str2 = "ABC"
**Output:** "ABC"

### Example 2:

**Input:** str1 = "ABABAB", str2 = "ABAB"
**Output:** "AB"

### Example 3:

**Input:** str1 = "LEET", str2 = "CODE"
**Output:** ""

## Solution Analysis

The provided solution uses a brilliant mathematical trick combined with the Euclidean algorithm for finding the Greatest Common Divisor (GCD).

* [Solution.java](./Solution.java)
* [Solution.cs](./Solution.cs)

### Key Concepts
* **The Commutative Property Check:** The core insight is that if a common divisor string `x` exists, then both `str1` and `str2` are made of repeating `x` units (e.g., `str1 = x+x+x`, `str2 = x+x`).
    * This means `str1 + str2` (e.g., "ABCABC" + "ABC" = "ABCABCABC")
    * will be equal to `str2 + str1` (e.g., "ABC" + "ABCABC" = "ABCABCABC").
    * If `str1 + str2 != str2 + str1` (e.g., "LEET" + "CODE" != "CODE" + "LEET"), no such repeating unit `x` can possibly exist, so we immediately return `""`.
* **Greatest Common Divisor (GCD) of Lengths:** If the first check passes, we know a common divisor exists. The *largest* possible common divisor string (`x`) must have a length equal to the GCD of the *lengths* of the two strings.
    * Example: `str1 = "ABABAB"` (Length 6), `str2 = "ABAB"` (Length 4).
    * `GCD(6, 4) = 2`.
    * This tells us the largest possible `x` has a length of 2.
* **Euclidean Algorithm:** A standard, efficient recursive helper function (`findGCDByEuclidean`) is used to calculate the GCD of the two lengths.
* **Final Result:** The answer is simply the prefix (substring) of `str1` (or `str2`) with the length of the calculated GCD.
    * `str1.Substring(0, gCD)` (e.g., "ABABAB".Substring(0, 2) -> "AB").

* **Performance:**
    * **Time Complexity:** `O(N + M)` (dominated by the string concatenation and equality check) + `O(log(min(N, M)))` (for the Euclidean algorithm). Total is `O(N + M)`.
    * **Space Complexity:** `O(N + M)` to create the temporary concatenated strings for the check.