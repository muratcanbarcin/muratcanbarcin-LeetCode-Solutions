# 13. Roman to Integer

**Difficulty:** Easy
| **Platform:** LeetCode | **Status:** Solved |
| :--- | :--- |

[Link to Problem on LeetCode](https://leetcode.com/problems/roman-to-integer/)

## Problem Description

Roman numerals are represented by seven different symbols: `I`, `V`, `X`, `L`, `C`, `D` and `M`.

| Symbol | Value |
| :--- | :--- |
| I | 1 |
| V | 5 |
| X | 10 |
| L | 50 |
| C | 100 |
| D | 500 |
| M | 1000 |

Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not `IIII`. Instead, the number four is written as `IV`. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as `IX`. There are six instances where subtraction is used:

* `I` can be placed before `V` (5) and `X` (10) to make 4 and 9.
* `X` can be placed before `L` (50) and `C` (100) to make 40 and 90.
* `C` can be placed before `D` (500) and `M` (1000) to make 400 and 900.

Given a roman numeral, convert it to an integer.

### Example 1:

**Input:** s = "III"
**Output:** 3
**Explanation:** III = 3.

### Example 2:

**Input:** s = "LVIII"
**Output:** 58
**Explanation:** L = 50, V= 5, III = 3.

### Example 3:

**Input:** s = "MCMXCIV"
**Output:** 1994
**Explanation:** M = 1000, CM = 900, XC = 90 and IV = 4.

## Solution Analysis (Java)

The solution for this problem (`Solution.java`) uses a **left-to-right** iteration approach with a specific check to handle subtraction cases.

* [Solution.java](./Solution.java)
* [Solution.cs](./Solution.cs)
* [Solution.py](./Solution.py)

### Key Concepts
* **Helper Function:** A `romanAlphabet(char c)` function is used, which contains a `switch` statement to efficiently map each Roman numeral `char` to its corresponding `int` value.
* **Left-to-Right Traversal:** The algorithm iterates through the string starting from the *second* character (`i=1`). It compares the current character's value (`num2`) with the previous character's value (`num1`).
* **Initial Value:** The `output` variable is initialized with the value of the *first* character (`sArray[0]`) *before* the loop starts.
* **Subtraction Detection:** The core logic to identify all six subtraction cases (IV, IX, XL, XC, CD, CM) is done with a single, clever check:
    ```java
    if(num1 * 5 == num2 || num1*10 ==num2)
    ```
    This works because `I(1)` is subtracted from `V(5)` and `X(10)`; `X(10)` from `L(50)` and `C(100)`; and `C(100)` from `D(500)` and `M(1000)`.
* **Summation Logic:**
    * **`else` block (Standard Addition):** If the `if` condition is false (e.g., "VI", `num1=5, num2=1`), the values are simply additive, so `output += num2`.
    * **`if` block (Subtraction Logic):** If the condition is true (e.g., "IV", `num1=1, num2=5`), it means `num1` should *not* have been added at all. The code corrects the `output` in two steps:
        1.  `output += num2 - num1;` (Example "IV": `output` was `1`. This line adds `(5-1)`, so `output` becomes `1 + 4 = 5`).
        2.  `output -= num1;` (This line removes the original `num1` that was added at the start. `output` becomes `5 - 1 = 4`).
        * This logic correctly adjusts the total by effectively calculating `output + num2 - (2 * num1)`.
* **Performance:**
    * **Time Complexity:** `O(N)`, as it iterates the string once.
    * **Space Complexity:** `O(N)`, because `s.toCharArray()` creates a new character array in memory proportional to the size of the input string `s`.