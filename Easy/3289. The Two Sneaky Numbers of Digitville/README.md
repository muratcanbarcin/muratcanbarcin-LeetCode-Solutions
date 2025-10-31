# 3289. The Two Sneaky Numbers of Digitville

**Difficulty:** Easy
| **Platform:** LeetCode | **Status:** Solved |
| :--- | :--- |

[Link to Problem on LeetCode](https://leetcode.com/problems/the-two-sneaky-numbers-of-digitville/)

## Problem Description

In the town of Digitville, there was a list of numbers called `nums` containing integers from `0` to `n - 1`. Each number was supposed to appear exactly once in the list, however, two mischievous numbers sneaked in an additional time, making the list longer than usual.

As the town detective, your task is to find these two sneaky numbers. Return an array of size two containing the two numbers (in any order).

### Example 1:

**Input:** nums = [0,1,1,0]
**Output:** [0,1]
**Explanation:** The numbers 0 and 1 each appear twice in the array.

### Example 2:

**Input:** nums = [0,3,2,1,3,2]
**Output:** [2,3]
**Explanation:** The numbers 2 and 3 each appear twice in the array.

### Example 3:

**Input:** nums = [7,1,5,4,3,4,6,0,9,5,8,2]
**Output:** [4,5]
**Explanation:** The numbers 4 and 5 each appear twice in the array.

## Solution Analysis (C#)

This C# solution uses a **Frequency Array** (also known as a counting sort or hash map approach) to solve the problem in optimal linear time, `O(N)`.

* [Solution.cs](./Solution.cs)

### Key Concepts
* **Frequency Array (Counting):** The problem constraints are key: `1 <= n <= 100` and `0 <= nums[i] < n`. This small, non-negative range is perfect for a frequency array. An array `freq` of size `n` is created to count the occurrences of each number.
* **Using Values as Indices:** The algorithm iterates through the `nums` array *once*. For each `num` encountered, it uses that number as an index into the `freq` array and increments the count: `freq[num]++;`.
* **Single-Pass Detection:** As opposed to an `O(N log N)` sorting approach, this method finds the duplicates in a single pass. When `freq[num]` is incremented and its new value becomes `2`, we know `num` is one of the "sneaky numbers".
* **Early Exit:** The algorithm adds the found duplicate to the `sneakyArr` and increments a `count`. As soon as `count` reaches `2`, the loop breaks, as both duplicates have been found.
* **Performance:**
    * **Time Complexity:** `O(N)`, where `N` is `nums.length`. We iterate through the `nums` array exactly once. Accessing an array index (`freq[num]`) is an `O(1)` operation.
    * **Space Complexity:** `O(n)`, where `n` is the number of unique elements (`nums.length - 2`). We allocate an extra array `freq` of size `n` to store the counts.