# 11. Container With Most Water

**Difficulty:** Medium
| **Platform:** LeetCode | **Status:** Solved |
| :--- | :--- |

[Link to Problem on LeetCode](https://leetcode.com/problems/container-with-most-water/)

## Problem Description

You are given an integer array `height` of length `n`. There are `n` vertical lines drawn such that the two endpoints of the `i`th line are `(i, 0)` and `(i, height[i])`.

Find two lines that together with the x-axis form a container, such that the container contains the most water.

Return the _maximum amount of water_ a container can store.

Notice that you may not slant the container.

### Example 1:

**Input:** height = [1,8,6,2,5,4,8,3,7]
**Output:** 49
**Explanation:** The max area is formed between index 1 (height 8) and index 8 (height 7). The width is `8 - 1 = 7`. The height is `min(8, 7) = 7`. Area is `7 * 7 = 49`.

### Example 2:

**Input:** height = [1,1]
**Output:** 1

## Solution Analysis (Java / C# / Python)

The problem asks us to maximize the area formed by two vertical lines. A brute-force approach checking every pair would be `O(N^2)`, which is too slow. The optimal solution uses the **Two Pointers** technique to solve it in linear time `O(N)`.

- [Solution.java](./Solution.java)
- [Solution.cs](./Solution.cs)
- [Solution.py](./Solution.py)

### Key Concepts

- **Two Pointers Approach:**

  1.  We initialize two pointers: `left` at the beginning (`0`) and `right` at the end (`n-1`) of the array. This gives us the maximum possible **width**.
  2.  At each step, we calculate the area formed by the lines at `left` and `right`.
      - `Area = min(height[left], height[right]) * (right - left)`
  3.  We store the maximum area found so far.

- **Greedy Move Logic (Critical Step):**

  - To try and find a larger area, we need to move one of the pointers inward.
  - The area is limited by the **shorter** line.
  - If we move the pointer corresponding to the _taller_ line, the new line we find will either be shorter or taller. Even if it's taller, the area is still limited by the _shorter_ line we didn't move, and the width has decreased. So, the area can only decrease or stay the same.
  - Therefore, the only chance to increase the area is to move the pointer corresponding to the **shorter** line, hoping to find a much taller line that compensates for the reduction in width.

- **Performance:**
  - **Time Complexity:** `O(N)`. We touch each element at most once as the pointers converge.
  - **Space Complexity:** `O(1)`. We only use a few variables for pointers and area calculation.
