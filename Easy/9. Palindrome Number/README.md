# 9. Palindrome Number

**Difficulty:** Easy
| **Platform:** LeetCode | **Status:** Solved |
| :--- | :--- |

[Link to Problem on LeetCode](https://leetcode.com/problems/palindrome-number/)

## Problem Description

Given an integer `x`, return `true` if `x` is a palindrome, and `false` otherwise.

### Example 1:

**Input:** x = 121
**Output:** true
**Explanation:** 121 reads as 121 from left to right and from right to left.

### Example 2:

**Input:** x = -121
**Output:** false
**Explanation:** From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.

### Example 3:

**Input:** x = 10
**Output:** false
**Explanation:** Reads 01 from right to left. Therefore it is not a palindrome.

## Solution Analysis

The solutions provided adhere to the "Follow up" constraint by solving the problem **without converting the integer to a string**.

* [Solution.java](./Solution.java)
* [Solution.cs](./Solution.cs)
* [Solution.py](./Solution.py)

### Key Concepts (Java Solution)
* **Mathematical (No-String) Approach:** The solution directly manipulates the integer `x` using mathematical operations.
* **First vs. Last Digit Comparison:** The core logic is to compare the *first* digit with the *last* digit, then "shrink" the number from both ends, and repeat this process for the middle digits.
* **Finding Number Length:** The total number of digits (`length`) is calculated using `(int)(Math.log10(x)+1)`.
* **Iteration:** The algorithm loops `length / 2` times, as it only needs to check the outer half of the number.
* **Digit Extraction:**
    * **Last Digit:** The last digit (`first` in the code) is easily found using the modulo operator: `first = (x % 10)`.
    * **First Digit:** The first digit (`last` in the code) is found by dividing the number by 10 raised to the power of `(length - i)`: `last = (int) (x/(Math.pow(10,length-i)))`.
* **Shrinking the Number:** After comparing, the number `x` is shrunk from both ends:
    1.  **Remove First Digit:** `x -= last*(Math.pow(10,length-i))`
    2.  **Remove Last Digit:** `x = x/10`
    3.  **Recalculate Length:** The `length` is recalculated *inside* the loop to reflect the new, shrunken number for the next iteration's `Math.pow` calculation.
* **Performance:**
    * **Time Complexity:** `O(log10(N))`. The loop runs roughly (number of digits / 2) times.
    * **Space Complexity:** `O(1)`. No extra data structures are used.