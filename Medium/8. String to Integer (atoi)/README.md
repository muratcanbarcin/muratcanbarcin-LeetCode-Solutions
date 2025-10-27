# 8. String to Integer (atoi)

**Difficulty:** Medium
| **Platform:** LeetCode | **Status:** Solved |
| :--- | :--- |

[Link to Problem on LeetCode](https://leetcode.com/problems/string-to-integer-atoi/)

## Problem Description

Implement the `myAtoi(string s)` function, which converts a string to a 32-bit signed integer.

The algorithm for `myAtoi(string s)` is as follows:

1.  **Whitespace:** Ignore any leading whitespace (`" "`).
2.  **Signedness:** Determine the sign by checking if the next character is `'-'` or `'+'`, assuming positivity if neither present.
3.  **Conversion:** Read the integer by skipping leading zeros until a non-digit character is encountered or the end of the string is reached. If no digits were read, then the result is 0.
4.  **Rounding:** If the integer is out of the 32-bit signed integer range `[-2^31, 2^31 - 1]`, then round the integer to remain in the range. Specifically, integers less than -2^31 should be rounded to -2^31, and integers greater than 2^31 - 1 should be rounded to 2^31 - 1.

Return the integer as the final result.

### Example 1:

**Input:** s = "42"
**Output:** 42

### Example 2:

**Input:** s = " -042"
**Output:** -42

### Example 3:

**Input:** s = "1337c0d3"
**Output:** 1337

### Example 4:

**Input:** s = "0-1"
**Output:** 0

## Solution Analysis (Java)

The provided Java solution implements a "state machine" approach, carefully following the 4 steps outlined in the problem description.

* [Solution.java](./Solution.java)

### Key Concepts
* **Iterative Parsing:** The solution iterates through the string using an `index`, character by character, rather than using regular expressions or built-in parsing functions.
* **Step-by-Step Logic:**
    1.  (Whitespace) A `while` loop skips all leading spaces.
    2.  (Signedness) An `if` block checks for `'-'` or `'+'` *once* to determine the `sign`.
    3.  (Conversion) A second `while` loop runs as long as the current character `Character.isDigit()`.
* **Critical: Overflow Check & Clamping:**
    * This problem requires *clamping* (rounding) to the 32-bit integer limits, unlike Problem 7 (Reverse Integer) which required returning 0.
    * The overflow check is performed *before* adding the next digit, using the same "divide by 10" trick to prevent the check itself from overflowing.
    ```java
    // Check if (result * 10 + digit) will overflow
    if (result > Integer.MAX_VALUE / 10 || (result == Integer.MAX_VALUE / 10 && digit > 7)) {
        // If it overflows, clamp to the respective limit
        return (sign == 1) ? Integer.MAX_VALUE : Integer.MIN_VALUE;
    }
    ```
    * If the check passes, the digit is added: `result = result * 10 + digit;`.
* **Final Result:** After the loop (which stops at the first non-digit character), the final `result` is multiplied by the determined `sign`.
* **Performance:**
    * **Time Complexity:** `O(N)`, where `N` is the length of the string `s`. The algorithm scans the string at most once.
    * **Space Complexity:** `O(1)`. Only a few integer variables are used.