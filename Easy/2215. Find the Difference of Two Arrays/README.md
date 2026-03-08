# 2215. Find the Difference of Two Arrays

**Difficulty:** Easy
| **Platform:** LeetCode | **Status:** Solved |
| :--- | :--- | 

[Link to Problem on LeetCode](https://leetcode.com/problems/find-the-difference-of-two-arrays/)

## Problem Description

Given two 0-indexed integer arrays `nums1` and `nums2`, return a list `answer` of size 2 where:

- `answer[0]` is a list of all **distinct** integers in `nums1` which are **not present** in `nums2`.
- `answer[1]` is a list of all **distinct** integers in `nums2` which are **not present** in `nums1`.

Note that the integers in the lists may be returned in **any order**.

### Example 1:

**Input:** nums1 = [1,2,3], nums2 = [2,4,6]  
**Output:** [[1,3],[4,6]]  
**Explanation:**  
For nums1, nums1[1] = 2 is present at index 0 of nums2, whereas nums1[0] = 1 and nums1[2] = 3 are not present in nums2. Therefore, answer[0] = [1,3].  
For nums2, nums2[0] = 2 is present at index 1 of nums1, whereas nums2[1] = 4 and nums2[2] = 6 are not present in nums2. Therefore, answer[1] = [4,6].

### Example 2:

**Input:** nums1 = [1,2,3,3], nums2 = [1,1,2,2]  
**Output:** [[3],[]]  
**Explanation:**  
For nums1, nums1[2] = 3 is not present in nums2. All other elements are present in nums2. Therefore, answer[0] = [3].  
For nums2, all elements are present in nums1. Therefore, answer[1] = [].

## Solution Analysis

The solution uses HashSet (or set in Python) to efficiently find the differences between the two arrays. By converting the arrays to sets, we remove duplicates and enable O(1) lookups for checking presence.

* [Solution.java](./Solution.java)
* [Solution.cs](./Solution.cs)
* [Solution.py](./Solution.py)

### Key Concepts
* **HashSet / Set:** A data structure that stores unique elements and provides fast lookup operations.
* **Set Difference:** Finding elements present in one set but not in another.
* **Time Complexity:** O(n + m) where n and m are the lengths of nums1 and nums2, respectively, due to set construction and iteration.
* **Space Complexity:** O(n + m) for storing the sets.

### Performance
- **Time:** O(n + m)
- **Space:** O(n + m)
- **Runtime:** Efficient for large inputs due to hash-based operations.