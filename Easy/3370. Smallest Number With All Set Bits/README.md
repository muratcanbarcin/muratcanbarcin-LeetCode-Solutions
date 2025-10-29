# 3370. Smallest Number With All Set Bits

**Difficulty:** Easy
| **Platform:** LeetCode | **Status:** Solved |
| :--- | :--- |

[Link to Problem on LeetCode](https://leetcode.com/problems/smallest-number-with-all-set-bits/)

## Problem Description

You are given a positive number `n`.

Return the smallest number `x` greater than or equal to `n`, such that the binary representation of `x` contains only set bits (e.g., "1", "11", "111").

### Example 1:

**Input:** n = 5
**Output:** 7
**Explanation:** The binary representation of 7 is "111".

### Example 2:

**Input:** n = 10
**Output:** 15
**Explanation:** The binary representation of 15 is "1111".

### Example 3:

**Input:** n = 3
**Output:** 3
**Explanation:** The binary representation of 3 is "11".

## Solution Analysis

The solutions provided iteratively construct the numbers composed of all set bits until one is found that is greater than or equal to `n`.

* [Solution.java](./Solution.java)
* [Solution.cs](./Solution.cs)
* [Solution.py](./Solution.py)

### Key Concepts
* **Mersenne Numbers (Yaklaşık):** The numbers being generated ("1", "11", "111", "1111"...) are numbers of the form $2^k - 1$ (Mersenne sayıları).
    * `k=1`: $2^1 - 1 = 1$ (Binary "1")
    * `k=2`: $2^2 - 1 = 3$ (Binary "11")
    * `k=3`: $2^3 - 1 = 7$ (Binary "111")
* **Iterative Construction:** The algorithm builds these numbers step-by-step. It starts with `result = 0` and adds powers of 2 in each iteration.
    ```java
    // (Java/C# syntax)
    while (n > result) {
        result += (int) Math.Pow(2, bitPosition);
        bitPosition++;
    }
    ```
    * **Loop 1:** `result = 0 + 2^0 = 1`
    * **Loop 2:** `result = 1 + 2^1 = 3`
    * **Loop 3:** `result = 3 + 2^2 = 7`
    * **Loop 4:** `result = 7 + 2^3 = 15`
* **Termination:** The `while (n > result)` loop condition cleverly ensures that the loop continues as long as the generated number (`result`) is *strictly less than* `n`. The moment `result` becomes greater than or equal to `n` (e.g., `n=10`, `result` becomes `15`), the loop terminates, and this `result` is returned.
* **Alternative (Bitwise) Approach:** The same result can be achieved using bitwise operations, which avoids floating-point math (`Math.Pow`):
    ```csharp
    // int result = 1; // Start at 1
    // while (n > result) {
    //    result = (result << 1) | 1;
    // }
    ```
* **Performance:**
    * **Time Complexity:** `O(log n)`. The loop runs `k` times, where `k` is the number of bits in the *output*. Since `n <= 1000`, the loop runs at most 10 times.
    * **Space Complexity:** `O(1)`. No extra storage is used.