# 1431. Kids With the Greatest Number of Candies

**Difficulty:** Easy
| **Platform:** LeetCode | **Status:** Solved |
| :--- | :--- |

[Link to Problem on LeetCode](https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/)

## Problem Description

There are `n` kids with candies. You are given an integer array `candies`, where each `candies[i]` represents the number of candies the `i`th kid has, and an integer `extraCandies`, denoting the number of extra candies that you have.

Return a boolean array `result` of length `n`, where `result[i]` is `true` if, after giving the `i`th kid all the `extraCandies`, they will have the greatest number of candies among all the kids, or `false` otherwise.

Note that multiple kids can have the greatest number of candies.

### Example 1:

**Input:** candies = [2,3,5,1,3], extraCandies = 3
**Output:** [true,true,true,false,true] 
**Explanation:** - Kid 1: 2 + 3 = 5 (Greatest)
- Kid 2: 3 + 3 = 6 (Greatest)
- Kid 3: 5 + 3 = 8 (Greatest)
- Kid 4: 1 + 3 = 4 (Not Greatest)
- Kid 5: 3 + 3 = 6 (Greatest)

### Example 2:

**Input:** candies = [4,2,1,1,2], extraCandies = 1
**Output:** [true,false,false,false,false] 

## Solution Analysis

The solutions provided use an optimal **two-pass `O(N)`** approach.

* [Solution.java](./Solution.java)
* [Solution.cs](./Solution.cs)
* [Solution.py](./Solution.py)

### Key Concepts
* **Two-Pass Algorithm:** This is the most efficient way to solve the problem.
    1.  **Pass 1 (Find Max):** First, the algorithm iterates through the `candies` array *once* to find the maximum number of candies any kid currently has (`maxCandies`).
        * (Java: `Arrays.stream(candies).max()`, C#: `candies.Max()`, Python: `max(candies)`)
    2.  **Pass 2 (Compare):** Second, the algorithm iterates through the `candies` array *again*. For each `candy`, it checks if `candy + extraCandies >= maxCandies` and adds the resulting boolean to the `results` list.
* **Python List Comprehension:** The Python solution condenses Pass 2 into a highly efficient and readable single line of code known as a "list comprehension".
* **Performance:**
    * **Time Complexity:** `O(N) + O(N) = O(2N)`, which simplifies to **`O(N)`**. We must look at every element at least once, so this is optimal.
    * **Space Complexity:** `O(N)`. This is required to store the `result` list of booleans, as requested by the problem.