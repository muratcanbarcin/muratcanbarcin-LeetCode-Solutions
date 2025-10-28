# 17. Letter Combinations of a Phone Number

**Difficulty:** Medium
| **Platform:** LeetCode | **Status:** Solved |
| :--- | :--- |

[Link to Problem on LeetCode](https://leetcode.com/problems/letter-combinations-of-a-phone-number/)

## Problem Description

Given a string containing digits from `2-9` inclusive, return all possible letter combinations that the number could represent. Return the answer in any order.

A mapping of digits to letters (just like on the telephone buttons) is given below. Note that 1 does not map to any letters.

(Resim LeetCode sayfasındadır)

### Example 1:

**Input:** digits = "23"
**Output:** ["ad","ae","af","bd","be","bf","cd","ce","cf"]

### Example 2:

**Input:** digits = ""
**Output:** []

### Example 3:

**Input:** digits = "2"
**Output:** ["a","b","c"]

## Solution Analysis (Java & C#)

The solutions provided use a classic **Backtracking** algorithm to explore all possible combinations.

* [Solution.java](./Solution.java)
* [Solution.cs](./Solution.cs)

### Key Concepts
* **Backtracking (Geriye Dönük İz Sürme):** This problem can be modeled as a "decision tree". For `digits = "23"`, the first decision is choosing from "abc" (level 1 of the tree), and for each of those choices, the second decision is choosing from "def" (level 2 of the tree).
* **Helper Function:** A private recursive helper function (`backtrack`) is used to implement this.
* **State Parameters:** The `backtrack` function keeps track of:
    1.  `index`: Which digit in the `digits` string we are currently processing (e.g., index 0 for '2', index 1 for '3').
    2.  `currentCombination`: A `StringBuilder` that holds the combination being built so far (e.g., `"a"`, then `"ad"`).
* **Base Case (Temel Durum):** The recursion stops when `index` equals the length of `digits`. This means we have made a choice for every digit, and the `currentCombination` is complete. We add its string representation to the `results` list.
* **Recursive Step (Özyineli Adım):**
    1.  Get the letters corresponding to the current `index` (e.g., "abc" for '2').
    2.  Loop through each `letter` in those letters ("a", "b", "c").
    3.  **Choose:** Append the `letter` to `currentCombination` (e.g., `current` is now `"a"`).
    4.  **Explore:** Call `backtrack` for the *next* index (`index + 1`). This moves one level deeper into the tree.
    5.  **Unchoose (Backtrack):** *After* the explore call returns, remove the `letter` (`.deleteCharAt()` / `.Remove()`). This "backtracks" up the tree, allowing the loop to try the next letter (e.g., changing `"a"` to `"b"`).
* **Performance:**
    * **Time Complexity:** `O(4^N * N)`. `N` is the length of `digits`. `4` is the maximum number of letters for a digit ("7" or "9"). In the worst case, we have `4^N` combinations. Each combination has length `N`, and converting the `StringBuilder` to a `String` (or joining the list) takes `O(N)` time.
    * **Space Complexity:** `O(N)`. This is the space used by the recursion call stack, which goes as deep as the number of digits `N`.