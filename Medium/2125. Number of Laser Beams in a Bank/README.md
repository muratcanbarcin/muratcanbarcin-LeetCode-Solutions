# 2125. Number of Laser Beams in a Bank

**Difficulty:** Medium
| **Platform:** LeetCode | **Status:** Solved |
| :--- | :--- |

[Link to Problem on LeetCode](https://leetcode.com/problems/number-of-laser-beams-in-a-bank/)

## Problem Description

Anti-theft security devices are activated inside a bank. You are given a 0-indexed binary string array `bank` representing the floor plan of the bank, which is an `m x n` 2D matrix. `bank[i]` represents the `i`th row, consisting of `'0'`s and `'1'`s. `'0'` means the cell is empty, while `'1'` means the cell has a security device.

There is one laser beam between any two security devices if both conditions are met:

1.  The two devices are located on two different rows: `r1` and `r2`, where `r1 < r2`.
2.  For each row `i` where `r1 < i < r2`, there are **no security devices** in the `i`th row.

Return the *total number of laser beams* in the bank.

### Example 1:

**Input:** bank = ["011001","000000","010100","001000"]
**Output:** 8
**Explanation:** Beams are formed between row 0 (3 devices) and row 2 (2 devices), and row 2 (2 devices) and row 3 (1 device).
- Row 0 to Row 2: `3 * 2 = 6` beams. (Row 1 is empty, so this is valid).
- Row 2 to Row 3: `2 * 1 = 2` beams.
- Total = `6 + 2 = 8`.
Note: No beams between row 0 and 3 because row 2 is *not* empty.

### Example 2:

**Input:** bank = ["000","111","000"]
**Output:** 0
**Explanation:** There are no two *different* rows with devices to connect.

## Solution Analysis

The solutions provided use a **single-pass** approach with **constant space complexity (`O(1)`)**.

* [Solution.java](./Solution.java)
* [Solution.cs](./Solution.cs)
* [Solution.py](./Solution.py)

### Key Concepts
* **Single-Pass Iteration:** The algorithm iterates through the `bank` array row by row only once.
* **Constant Space `O(1)`:** Instead of storing all row counts in a new array (which would be `O(m)` space), we only store the count of the *previous* row that contained devices (`prevDeviceCount`).
* **Counting Devices:** The number of devices in the `currentDeviceCount` is calculated efficiently using string manipulation:
    ```java
    // Java
    int currentDeviceCount = row.length() - row.replace("1", "").length();
    ```
    ```csharp
    // C#
    int currentDeviceCount = row.Length - row.Replace("1", "").Length;
    ```
    ```python
    # Python (or more simply: row.count('1'))
    current_device_count = len(row) - len(row.replace("1", ""))
    ```
* **Core Logic:**
    1.  Initialize `totalBeams = 0` and `prevDeviceCount = 0`.
    2.  For each `row`, calculate its `currentDeviceCount`.
    3.  If `currentDeviceCount > 0` (this row has devices):
        * `totalBeams += (prevDeviceCount * currentDeviceCount)`. This adds the beams connecting the current row to the last-seen device row.
        * `prevDeviceCount = currentDeviceCount`. Update the "previous" count for the next iteration.
    4.  If `currentDeviceCount == 0` (this row is empty), `prevDeviceCount` is *not* updated. This cleverly handles the 2nd rule of the problem (no devices in between), as `prevDeviceCount` will hold its value until the next non-empty row is found.
* **Performance:**
    * **Time Complexity:** `O(m * n)`, where `m` is the number of rows and `n` is the number of columns (length of each string). This is because we visit `m` rows, and for each row, `replace()` (or `count()`) takes `O(n)` time.
    * **Space Complexity:** `O(1)`. We only use a few integer variables.