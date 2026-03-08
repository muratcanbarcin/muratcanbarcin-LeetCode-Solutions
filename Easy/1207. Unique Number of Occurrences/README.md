# 1207. Unique Number of Occurrences

**Difficulty:** Easy
| **Platform:** LeetCode | **Status:** Solved |
| :--- | :--- | 

[Link to Problem on LeetCode](https://leetcode.com/problems/unique-number-of-occurrences/)

## Problem Description

Given an array of integers `arr`, return `true` if the number of occurrences of each value in the array is **unique**, or `false` otherwise.

### Example 1:

**Input:** arr = [1,2,2,1,1,3]  
**Output:** true  
**Explanation:** The value 1 has 3 occurrences, 2 has 2 and 3 has 1. No two values have the same number of occurrences.

### Example 2:

**Input:** arr = [1,2]  
**Output:** false  
**Explanation:** 1 has 1 occurrence and 2 has 1 occurrence. Both have the same number of occurrences.

### Example 3:

**Input:** arr = [-3,0,1,-3,1,1,1,-3,10,0]  
**Output:** true  

## Solution Analysis

The solution uses a dictionary/map to count the frequency of each number in the array. Then, it collects all the frequencies into a list and checks if the length of the list is equal to the length of the set of frequencies. If they are equal, all frequencies are unique; otherwise, there are duplicates.

* [Solution.java](./Solution.java)
* [Solution.cs](./Solution.cs)
* [Solution.py](./Solution.py)

### Key Concepts
* **Frequency Counting:** Using a map/dictionary to count occurrences of each element.
* **Uniqueness Check:** Comparing the number of unique frequencies to the total number of frequencies.
* **Time Complexity:** O(n) where n is the length of the array, due to single pass for counting and set operations.
* **Space Complexity:** O(n) for storing the frequency map and the set of frequencies.

### Performance
- **Time:** O(n)
- **Space:** O(n)
- **Runtime:** Efficient for large arrays as it processes each element a constant number of times.