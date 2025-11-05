# 443. String Compression

**Difficulty:** Medium
| **Platform:** LeetCode | **Status:** Solved |
| :--- | :--- |

[Link to Problem on LeetCode](https://leetcode.com/problems/string-compression/)

## Problem Description

Given an array of characters `chars`, compress it using the following algorithm:

Begin with an empty string `s`. For each group of consecutive repeating characters in `chars`:

* If the group's length is 1, append the character to `s`.
* Otherwise, append the character followed by the group's length.

The compressed string `s` should not be returned separately, but instead, be stored **in the input character array `chars`**. Note that group lengths that are 10 or longer will be split into multiple characters in `chars`.

After you are done modifying the input array, return the **new length** of the array.

You must write an algorithm that uses only **constant extra space (`O(1)`)**.

### Example 1:

**Input:** chars = ["a","a","b","b","c","c","c"]
**Output:** Return 6, and the first 6 characters of the input array should be: ["a","2","b","2","c","3"]
**Explanation:** The groups are "aa", "bb", and "ccc". This compresses to "a2b2c3".

### Example 2:

**Input:** chars = ["a"]
**Output:** Return 1, and the first character of the input array should be: ["a"]

### Example 3:

**Input:** chars = ["a","b","b","b","b","b","b","b","b","b","b","b","b"]
**Output:** Return 4, and the first 4 characters of the input array should be: ["a","b","1","2"].
**Explanation:** The groups are "a" and "bbbbbbbbbbbb". This compresses to "ab12".

## Solution Analysis (Java / C#)

This problem is a classic **"in-place" modification** problem that must be solved with `O(1)` extra space, meaning we cannot use `ArrayList`, `StringBuilder`, or other data structures that grow with the input size.

The solution uses a **"Read/Write Pointers" (İki İşaretçi)** approach.

* [Solution.java](./Solution.java)
* [Solution.cs](./Solution.cs)

### Key Concepts
* **Two Pointers:** We use two integer indices:
    1.  **`readIndex` (Okuma İşaretçisi):** Iterates through the original `chars` array from beginning to end to "read" the data.
    2.  **`writeIndex` (Yazma İşaretçisi):** Tracks the position where the next compressed character should be *written* back into the `chars` array. This index also serves as the final length of the compressed array.
* **Iterating Groups:** The main `while (readIndex < chars.length)` loop iterates through the *groups* of characters.
* **Counting Groups:** Inside the main loop, a nested `while` loop is used to find the length of the current consecutive group.
    * It finds `currentChar = chars[readIndex]`.
    * It increments `count` and `readIndex` as long as the characters match `currentChar`.
    * When this inner loop finishes, `readIndex` is at the *start* of the next group, and `count` holds the length of the group we just passed.
* **In-Place Writing:**
    1.  We write the `currentChar` to the `writeIndex` position: `chars[writeIndex++] = currentChar;`.
    2.  We check `if (count > 1)`.
    3.  If it is, we convert the `count` to a string (e.g., `12` -> `"12"`).
    4.  We loop through each digit `char` in that string (e.g., `'1'`, then `'2'`) and write them to the `chars` array: `chars[writeIndex++] = digit;`.
* **Return Value:** The main loop continues until `readIndex` has scanned the entire array. The final value of `writeIndex` is the new length of the compressed array, which is returned.

* **Performance:**
    * **Time Complexity:** `O(N)`, where `N` is the length of `chars`. Although there are nested loops, `readIndex` only ever moves forward, so every character is visited at most twice (once by the `readIndex` and once by the inner `while` loop).
    * **Space Complexity:** `O(1)`. We only use a few integer variables. The space for `String.valueOf(count)` is `O(log10(count))`, which is at most `O(log10(2000))`, a constant (max 4 digits).