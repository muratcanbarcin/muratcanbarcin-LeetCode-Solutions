# 1456. Maximum Number of Vowels in a Substring of Given Length

**Difficulty:** Medium
| **Platform:** LeetCode | **Status:** Solved |
| :--- | :--- |

[Link to Problem on LeetCode](https://leetcode.com/problems/maximum-number-of-vowels-in-a-substring-of-given-length/)

## Problem Description

Given a string `s` and an integer `k`, return the maximum number of vowel letters in any substring of `s` with length `k`.

Vowel letters in English are `'a'`, `'e'`, `'i'`, `'o'`, and `'u'`.

### Example 1:

**Input:** s = "abciiidef", k = 3
**Output:** 3
**Explanation:** The substring "iii" contains 3 vowel letters.

### Example 2:

**Input:** s = "aeiou", k = 2
**Output:** 2
**Explanation:** Any substring of length 2 contains 2 vowels.

### Example 3:

**Input:** s = "leetcode", k = 3
**Output:** 2
**Explanation:** "lee", "eet" and "ode" contain 2 vowels.

## Solution Analysis (Java / C# / Python)

This problem is solved efficiently using the **Sliding Window** technique. Instead of checking every substring from scratch (which would be $O(N \cdot k)$), we maintain a running count of vowels as the window slides.

- [Solution.java](./Solution.java)
- [Solution.cs](./Solution.cs)
- [Solution.py](./Solution.py)

### Key Concepts

- **Sliding Window:**

  1.  **Initialize:** We count the number of vowels in the first `k` characters (the first window).
  2.  **Slide:** We iterate through the rest of the string from index `k` to `s.length() - 1`.
  3.  **Update:** For each step, we consider the new character entering the window (`s[i]`) and the character leaving the window (`s[i-k]`).
      - If the entering character is a vowel, we increment the count.
      - If the leaving character is a vowel, we decrement the count.
  4.  **Maximize:** We keep track of the maximum vowel count seen so far.

- **Optimization (Early Exit):**

  - If at any point `maxVowels` equals `k` (the window size), we know it's impossible to find a substring with _more_ vowels than the window size itself. We can immediately return `k` to save time.

- **Vowel Lookup:**

  - A `HashSet` (or `set` in Python) is used for $O(1)$ lookups to check if a character is a vowel. Alternatively, a boolean array or a direct check (`c == 'a' || c == 'e' ...`) can be used for potentially faster execution.

- **Performance:**
  - **Time Complexity:** $O(N)$, where $N$ is the length of `s`. We traverse the string exactly once.
  - **Space Complexity:** $O(1)$. The set of vowels has a constant size (5), and we only use a few integer variables.
