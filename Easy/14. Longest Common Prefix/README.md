# 14. Longest Common Prefix

**Difficulty:** Easy
| **Platform:** LeetCode | **Status:** Solved |
| :--- | :--- |

[Link to Problem on LeetCode](https://leetcode.com/problems/longest-common-prefix/)

## Problem Description

Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string `""`.

### Example 1:

**Input:** strs = ["flower","flow","flight"]
**Output:** "fl"

### Example 2:

**Input:** strs = ["dog","racecar","car"]
**Output:** ""
**Explanation:** There is no common prefix among the input strings.

## Solution Analysis

Solutions in Java and C# are provided using an efficient "Horizontal Scanning" approach.

* [Solution.java](./Solution.java)
* [Solution.cs](./Solution.cs)

### Key Concepts: Horizontal Scanning

This method is an intuitive way to solve the problem. The algorithm works as follows:

1.  **Assume First String is Prefix:** The algorithm starts by assuming the *entire first string* (`strs[0]`) is the longest common prefix.
2.  **Iterate and Compare:** It then iterates through the rest of the strings in the array (from `i = 1` to the end).
3.  **Shrink Prefix:** For each string, it checks if the string *starts with* the current `prefix`.
    * If it doesn't (e.g., comparing "flower" (prefix) to "flow"), it "shrinks" the `prefix` by removing the last character.
    * This check is repeated in a `while` loop:
        * `prefix` is "flower". Does "flow" start with "flower"? No.
        * `prefix` becomes "flowe". Does "flow" start with "flowe"? No.
        * `prefix` becomes "flow". Does "flow" start with "flow"? Yes.
    * The algorithm then moves to the next string ("flight") with "flow" as the prefix.
4.  **Early Exit:** If the `prefix` ever shrinks to an empty string (`""`), it means no common prefix exists, and the function immediately returns `""`.
5.  **Final Result:** If the loop finishes, the `prefix` that remains is the longest common prefix shared by all strings.

* **Time Complexity:** `O(S)`, where `S` is the sum of all characters in all strings. In the worst case, every character of every string is compared.
* **Space Complexity:** `O(1)`. The algorithm uses a constant amount of extra space.