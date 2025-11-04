# 3318. Find X-Sum of All K-Long Subarrays I

**Difficulty:** Easy
| **Platform:** LeetCode | **Status:** Solved |
| :--- | :--- |

[Link to Problem on LeetCode](https://leetcode.com/problems/find-x-sum-of-all-k-long-subarrays-i/)

## Problem Description

You are given an array `nums` of `n` integers and two integers `k` and `x`.

The **x-sum** of an array is calculated by the following procedure:

1.  Count the occurrences of all elements in the array.
2.  Keep only the occurrences of the **top `x` most frequent** elements. If two elements have the same number of occurrences, the element with the **bigger value** is considered more frequent.
3.  Calculate the sum of the resulting array.

Note that if an array has less than `x` distinct elements, its x-sum is the sum of the array.

Return an integer array `answer` of length `n - k + 1` where `answer[i]` is the x-sum of the subarray `nums[i..i + k - 1]`.

### Example 1:

**Input:** nums = [1,1,2,2,3,4,2,3], k = 6, x = 2
**Output:** [6,10,12]
**Explanation:**
- For subarray [1, 1, 2, 2, 3, 4], the frequencies are {1:2, 2:2, 3:1, 4:1}. The top 2 are {2:2} (higher value) and {1:2}. The sum is 2+2+1+1 = 6.
- For subarray [1, 2, 2, 3, 4, 2], the frequencies are {2:3, 1:1, 3:1, 4:1}. The top 2 are {2:3} and {4:1} (higher value than 3 and 1). The sum is 2+2+2+4 = 10.
- For subarray [2, 2, 3, 4, 2, 3], the frequencies are {2:3, 3:2, 4:1}. The top 2 are {2:3} and {3:2}. The sum is 2+2+2+3+3 = 12.

### Example 2:

**Input:** nums = [3,8,7,8,7,5], k = 2, x = 2
**Output:** [11,15,15,15,12]

## Solution Analysis (Java / C#)

This problem requires a combination of the "Sliding Window" pattern and "Frequency Sorting". Due to the small constraints (`n <= 50`), a simple (brute-force) sliding window is sufficient, where we re-calculate the x-sum for each window.

The core logic lies in the `xSumCalc` helper function, which calculates the x-sum for a given subarray.

* [Solution.java](./Solution.java)
* [Solution.cs](./Solution.cs)

### Key Concepts
* **Sliding Window:** The main function `findXSum` iterates from `i = 0` to `n - k`, creating a new `subArray` of length `k` in each iteration.
* **Frequency Counting:** Inside `xSumCalc`, a `HashMap` (Java) or `Dictionary` (C#) is used to count the frequency of each number within the `subArray`.
* **Custom Sorting:** This is the most critical part of the problem.
    1.  **Convert to List:** We cannot sort a `HashMap`. We convert its `entrySet()` (Java) or the `Dictionary` itself (C#) into a `List`.
    2.  **Sort with Custom Rules:** We sort this list using a custom comparator that follows the problem's rules:
        * **Rule 1:** Sort by frequency (value) in descending order.
        * **Rule 2 (Tie-breaker):** If frequencies are equal, sort by element (key) in descending order.
    * **Java:** `Collections.sort(list, (a, b) -> { ... })`
    * **C#:** `freq.OrderByDescending(p => p.Value).ThenByDescending(p => p.Key)`
* **Sum Top X:** After the list is sorted, we iterate through the first `x` elements (or fewer, if the list is smaller than `x`). For each of these top `x` entries, we add `entry.getKey() * entry.getValue()` to the `totalSum`.
* **Subarray Copy:** In the main loop, a new array `subArray` is created and populated from `nums` for each window. This is necessary to pass the correct data to the helper function.

* **Performance:**
    * **Time Complexity:** `O((N-k) * (k log k))`.
        * We have `N-k` windows.
        * For each window, we build a `subArray` (`O(k)`), count frequencies (`O(k)`), and sort the frequencies (`O(D log D)`, where `D` is distinct elements, at most `k`).
        * Given `N, k <= 50`, this is extremely fast.
    * **Space Complexity:** `O(k)`. For each window, we store the `subArray` and the `HashMap`/`Dictionary` of frequencies, both of which are at most size `k`.