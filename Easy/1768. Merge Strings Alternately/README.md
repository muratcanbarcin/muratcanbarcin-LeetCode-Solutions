# 1768. Merge Strings Alternately

**Difficulty:** Easy
| **Platform:** LeetCode | **Status:** Solved |
| :--- | :--- |

[Link to Problem on LeetCode](https://leetcode.com/problems/merge-strings-alternately/)

## Problem Description

You are given two strings `word1` and `word2`. Merge the strings by adding letters in alternating order, starting with `word1`. If a string is longer than the other, append the additional letters onto the end of the merged string.

Return the *merged string*.

### Example 1:

**Input:** word1 = "abc", word2 = "pqr"
**Output:** "apbqcr"
**Explanation:**
word1:  a   b   c
word2:    p   q   r
merged: a p b q c r

### Example 2:

**Input:** word1 = "ab", word2 = "pqrs"
**Output:** "apbqrs"
**Explanation:** Notice that as word2 is longer, "rs" is appended to the end.

### Example 3:

**Input:** word1 = "abcd", word2 = "pq"
**Output:** "apbqcd"
**Explanation:** Notice that as word1 is longer, "cd" is appended to the end.

## Solution Analysis

The solutions provided use a single-loop approach to merge the two strings, handling different lengths efficiently.

* [Solution.java](./Solution.java)
* [Solution.cs](./Solution.cs)

### Key Concepts
* **Single-Loop Iteration:** The algorithm avoids complex logic by using a single `for` loop that runs up to the length of the *longer* string (`int longWordLength = Math.max(word1.length(),word2.length())`).
* **Boundary Checks:** Inside the loop, two separate `if` statements are used to safely append characters:
    1.  `if(word1.length() > i)`: Checks if `word1` still has a character at the current index `i`. If yes, append it.
    2.  `if(word2.length() > i)`: Checks if `word2` still has a character at the current index `i`. If yes, append it.
* **Handling Longer Strings:** This approach automatically handles cases where one string is longer. For example, if `word1` is "ab" and `word2` is "pqrs":
    * `i=0`: Appends 'a', appends 'p'.
    * `i=1`: Appends 'b', appends 'q'.
    * `i=2`: `word1` check fails. `word2` check passes. Appends 'r'.
    * `i=3`: `word1` check fails. `word2` check passes. Appends 's'.
* **StringBuilder:** The solution correctly uses `StringBuilder` (Java) or `StringBuilder` (C#) for efficient string concatenation inside a loop, avoiding the performance cost of creating multiple immutable `String` objects.
* **Performance:**
    * **Time Complexity:** `O(max(N, M))`, where `N` and `M` are the lengths of `word1` and `word2`. The loop runs as long as the longest string.
    * **Space Complexity:** `O(N + M)`. This is the space required to store the new `mergeStr`.