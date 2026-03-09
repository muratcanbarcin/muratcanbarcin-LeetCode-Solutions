# 1657. Determine if Two Strings Are Close

**Difficulty:** Medium
| **Platform:** LeetCode | **Status:** Solved |
| :--- | :--- | 

[Link to Problem on LeetCode](https://leetcode.com/problems/determine-if-two-strings-are-close/)

## Problem Description

Two strings are considered **close** if you can attain one from the other using the following operations:

- **Operation 1:** Swap any two existing characters.
- **Operation 2:** Transform every occurrence of one existing character into another existing character, and do the same with the other character.

You have to use the operations on **every occurrence** of the chosen characters.

Given two strings, `word1` and `word2`, return `true` if `word1` and `word2` are close, and `false` otherwise.

### Example 1:

**Input:** word1 = "abc", word2 = "bca"  
**Output:** true  
**Explanation:** You can attain word2 from word1 in 2 operations.  
Apply Operation 1: "abc" -> "acb"  
Apply Operation 1: "acb" -> "bca"

### Example 2:

**Input:** word1 = "a", word2 = "aa"  
**Output:** false  
**Explanation:** It is impossible to attain word2 from word1, or vice versa, in any number of operations.

### Example 3:

**Input:** word1 = "cabbba", word2 = "abbccc"  
**Output:** true  
**Explanation:** You can attain word2 from word1 in 3 operations.  
Apply Operation 1: "cabbba" -> "caabbb"  
Apply Operation 2: 'b' -> 'c', "caabbb" -> "ccaacc"  
Apply Operation 2: 'a' -> 'b', "ccaacc" -> "bbccee"

## Solution Analysis

The solution determines if two strings are "close" by checking two key conditions:

1. **Same Character Set:** Both strings must contain exactly the same unique characters. This ensures that no character is present in one string but absent in the other.

2. **Same Frequency Distribution:** The frequencies of the characters must be rearrangeable to match. This is checked by sorting the frequency arrays and comparing them.

The provided solutions use frequency arrays (Java/C#) or Counters (Python) to count character occurrences, then verify the conditions.

* [Solution.java](./Solution.java)
* [Solution.cs](./Solution.cs)
* [Solution.py](./Solution.py)

### Key Concepts
* **Frequency Counting:** Using arrays or maps to count character frequencies.
* **Character Set Comparison:** Ensuring both strings have identical sets of characters.
* **Frequency Sorting:** Sorting frequency values to compare distributions.
* **Time Complexity:** O(n + k log k) where n is string length and k is alphabet size (26), dominated by sorting.
* **Space Complexity:** O(k) for frequency storage.

### Performance
- **Time:** O(n + k log k)
- **Space:** O(k)
- **Runtime:** Efficient for typical string lengths, with sorting being the bottleneck for large alphabets.