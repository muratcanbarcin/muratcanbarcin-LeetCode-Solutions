# 345. Reverse Vowels of a String

**Difficulty:** Easy
| **Platform:** LeetCode | **Status:** Solved |
| :--- | :--- |

[Link to Problem on LeetCode](https://leetcode.com/problems/reverse-vowels-of-a-string/)

## Problem Description

Given a string `s`, reverse only all the vowels in the string and return it.

The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.

### Example 1:

**Input:** s = "IceCreAm"
**Output:** "AceCreIm"
**Explanation:** The vowels in s are ['I', 'e', 'e', 'A']. On reversing the vowels, s becomes "AceCreIm".

### Example 2:

**Input:** s = "leetcode"
**Output:** "leotcede"

## Solution Analysis

The solutions provided use the **Two Pointers (İki İşaretçi)** pattern for an efficient in-place reversal.

* [Solution.java](./Solution.java)
* [Solution.cs](./Solution.cs)
* [Solution.py](./Solution.py)

### Key Concepts
* **Two Pointers:** This is the optimal pattern for this problem.
    1.  A `left` pointer starts at the beginning of the string (`index 0`).
    2.  A `right` pointer starts at the end of the string (`index n-1`).
    3.  The pointers move towards each other (`while (left < right)`).
* **Vowel Lookup:** A `HashSet` (or `set` in Python) is used to store all 10 vowel characters (`a, e, i, o, u, A, E, I, O, U`). This allows for `O(1)` (constant time) checking to see if a character is a vowel.
* **Skipping Consonants:**
    * The `left` pointer moves right (`left++`) as long as it points to a consonant.
    * The `right` pointer moves left (`right--`) as long as it points to a consonant.
* **Immutable Strings:** Strings in Java, C#, and Python are "immutable" (değiştirilemez). To swap characters, the string must first be converted to a mutable data structure:
    * **Java/C#:** `char[]` (Karakter Dizisi)
    * **Python:** `list` (Liste)
* **The Swap:** Once `left` points to a vowel and `right` points to a vowel, and `left` is still less than `right`, the two characters are swapped. The pointers are then both moved (`left++`, `right--`) to continue the search.
* **Final Conversion:** After the loop finishes, the mutable structure (`char[]` / `list`) is converted back into a `string`.

* **Performance:**
    * **Time Complexity:** `O(N)`, where `N` is the length of the string. In the worst case, each pointer travels the entire length of the string once.
    * **Space Complexity:** `O(N)`. This space is required to create the `char[]` or `list` from the input string.