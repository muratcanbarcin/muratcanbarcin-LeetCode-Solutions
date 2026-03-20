# 2390. Removing Stars From a String

**Difficulty:** Medium
| **Platform:** LeetCode | **Status:** Solved |
| :--- | :--- | 

[Link to Problem on LeetCode](https://leetcode.com/problems/removing-stars-from-a-string/)

## Problem Description

You are given a string `s` containing stars `*` and other characters.

In one operation, you can:
- Choose a star in `s`
- Remove the star and the character immediately to its left

Return the string after all stars have been removed.

Note:
- The input will be generated such that the operation is always possible.
- It is guaranteed the star won't appear as the first character in `s`.

### Example 1:

**Input:** s = "leet**cod*e"  
**Output:** "lecoe"  
**Explanation:** Performing the removals from left to right:
- "leet**cod*e" -> "le*cod*e" -> "lecod*e" -> "lecoe"

### Example 2:

**Input:** s = "ab**cd**e*f"  
**Output:** "ef"  
**Explanation:** Performing the removals from left to right:
- "ab**cd**e*f" -> "a*cd**e*f" -> "cd**e*f" -> "c*e*f" -> "e*f" -> "ef"

### Example 3:

**Input:** s = "a*b*c"  
**Output:** "abc"  

## Solution Analysis

The solution uses a **Stack** data structure to efficiently handle the removal process. As we iterate through the string:
- If the current character is a star `*`, we pop the top character from the stack (removing the character immediately to the left).
- Otherwise, we push the character onto the stack.

The final result is constructed by converting the stack contents back to a string.

* [Solution.java](./Solution.java)
* [Solution.cs](./Solution.cs)
* [Solution.py](./Solution.py)

### Key Concepts
* **Stack Data Structure:** Maintains a Last-In-First-Out (LIFO) order, perfect for this removal operation.
* **Single Pass:** The algorithm processes the string in one pass from left to right.
* **Time Complexity:** O(n) where n is the length of the string, as each character is processed once.
* **Space Complexity:** O(n) in the worst case, when the stack stores all non-star characters.

### Performance
- **Time:** O(n)
- **Space:** O(n)
- **Runtime:** Efficient and straightforward solution for typical string lengths.