# 151. Reverse Words in a String

**Difficulty:** Medium
| **Platform:** LeetCode | **Status:** Solved |
| :--- | :--- |

[Link to Problem on LeetCode](https://leetcode.com/problems/reverse-words-in-a-string/)

## Problem Description

Given an input string `s`, reverse the order of the **words**.

A word is defined as a sequence of non-space characters. The words in `s` will be separated by at least one space.

Return *a string of the words in reverse order concatenated by a single space.*

Note that `s` may contain leading or trailing spaces or multiple spaces between two words. The returned string should only have a single space separating the words. Do not include any extra spaces.

### Example 1:

**Input:** s = "the sky is blue"
**Output:** "blue is sky the"

### Example 2:

**Input:** s = "  hello world  "
**Output:** "world hello"
**Explanation:** Your reversed string should not contain leading or trailing spaces.

### Example 3:

**Input:** s = "a good   example"
**Output:** "example good a"
**Explanation:** You need to reduce multiple spaces between two words to a single space in the reversed string.

## Solution Analysis (Java)

The provided Java solution uses a clean, high-level approach by leveraging built-in Java utilities to handle all the problem's constraints (trimming, splitting by multiple spaces, and rejoining with single spaces).

* [Solution.java](./Solution.java)

### Key Concepts
* **Built-in Functions:** This solution is a concise implementation that chains several built-in methods.
* **`s.trim()`:** The first step is to call `trim()` on the input string. This effectively removes all leading and trailing whitespace, satisfying one of the core requirements.
* **`s.split("\\s+")`:** This is the most critical part.
    * `split()` is used to break the string into an array of words.
    * The argument `"\\s+"` is a **regular expression (regex)**. `\s` means "any whitespace character" (like space, tab, etc.), and `+` means "one or more".
    * This regex cleverly handles the requirement to treat "a good   example" (multiple spaces) as just two words, "good" and "example".
* **`Collections.reverse(Arrays.asList(words))`:**
    * `Arrays.asList(words)` converts the `String[]` array into a `List` view.
    * `Collections.reverse()` is then called on this list, which reverses the elements (the words) in-place.
* **`String.join(" ", words)`:** Finally, `String.join()` is used to stitch the reversed array of words back together.
    * The first argument, `" "`, specifies the delimiter. This ensures that every word in the final output is separated by exactly one space.

* **Performance:**
    * **Time Complexity:** `O(N)`, where `N` is the length of the string `s`. This is dominated by the `split()`, `reverse()`, and `join()` operations, all of which are linear in time.
    * **Space Complexity:** `O(N)`. Space is required to store the `words` array and the final `String` (or `StringBuilder`) used by `String.join()`.