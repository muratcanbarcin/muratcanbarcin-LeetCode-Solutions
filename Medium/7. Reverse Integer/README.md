# 7. Reverse Integer

**Difficulty:** Medium
| **Platform:** LeetCode | **Status:** Solved |
| :--- | :--- |

[Link to Problem on LeetCode](https://leetcode.com/problems/reverse-integer/)

## Problem Description

Given a signed 32-bit integer `x`, return `x` with its digits reversed. If reversing `x` causes the value to go outside the signed 32-bit integer range `[-2^31, 2^31 - 1]`, then return 0.

**Assume the environment does not allow you to store 64-bit integers (signed or unsigned).**

### Example 1:

**Input:** x = 123
**Output:** 321

### Example 2:

**Input:** x = -123
**Output:** -321

### Example 3:

**Input:** x = 120
**Output:** 21

## Solution Analysis (Java)

The Java solution provided for this problem solves it mathematically, adhering to the constraint of not using 64-bit integers (like `long`).

* [Solution.java](./Solution.java)

### Key Concepts

* **Mathematical Approach (No String/Long):** The solution avoids converting the integer to a `String` or using a `long` to store the result. It uses a "Pop and Push" method with `int` variables only.
* **"Pop and Push" Logic:**
    1.  **Pop:** The last digit of `x` is "popped" off using the modulo operator (`pop = x % 10`).
    2.  **Shrink:** `x` is shrunk by removing the last digit using integer division (`x /= 10`).
    3.  **Push:** The `pop`'ped digit is "pushed" onto the end of the `reversed` number (`reversed = reversed * 10 + pop`).
* **Critical: Overflow (Taşma) Check:**
    * The main challenge is to detect if the *next* "push" operation will cause `reversed` to exceed the 32-bit integer limits (`Integer.MAX_VALUE` or `Integer.MIN_VALUE`).
    * This check must be done *before* the operation:
    ```java
    // Checks for positive overflow
    if (reversed > Integer.MAX_VALUE / 10 || (reversed == Integer.MAX_VALUE / 10 && pop > 7)) {
        return 0;
    }
    // Checks for negative overflow
    if (reversed < Integer.MIN_VALUE / 10 || (reversed == Integer.MIN_VALUE / 10 && pop < -8)) {
        return 0;
    }
    ```
    * **Explanation:**
        * `reversed > Integer.MAX_VALUE / 10`: If `reversed` is already greater than `214748364`, multiplying by 10 will definitely overflow.
        * `reversed == Integer.MAX_VALUE / 10 && pop > 7`: If `reversed` is exactly `214748364`, the new value will be `2147483640 + pop`. This will overflow only if `pop` is greater than `7` (the last digit of `MAX_VALUE`).
        * The same logic applies to `MIN_VALUE` (which ends in `8`).
* **Performance:**
    * **Time Complexity:** `O(log10(x))`. The loop runs once for each digit in the number `x`.
    * **Space Complexity:** `O(1)`. No extra data structures (like strings or arrays) are created.