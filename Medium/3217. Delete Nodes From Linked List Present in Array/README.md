# 3217. Delete Nodes From Linked List Present in Array

**Difficulty:** Medium
| **Platform:** LeetCode | **Status:** Solved |
| :--- | :--- |

[Link to Problem on LeetCode](https://leetcode.com/problems/delete-nodes-from-linked-list-present-in-array/)

## Problem Description

You are given an array of integers `nums` and the `head` of a linked list. Return the `head` of the modified linked list after removing all nodes from the linked list that have a value that exists in `nums`.

### Example 1:

**Input:** nums = [1,2,3], head = [1,2,3,4,5]
**Output:** [4,5]
**Explanation:** Remove the nodes with values 1, 2, and 3.

### Example 2:

**Input:** nums = [1], head = [1,2,1,2,1,2]
**Output:** [2,2,2]
**Explanation:** Remove the nodes with value 1.

## Solution Analysis (Java & C#)

The solution provided solves this problem in optimal `O(N + M)` time by using a boolean array as a lookup table and the "Dummy Head" pattern for safe node deletion.

* [Solution.java](./Solution.java)
* [Solution.cs](./Solution.cs)

### Key Concepts
* **Time Complexity Problem:** A naive (brute-force) solution would be `O(N*M)`, where for each of the `N` nodes in the list, we search the `M` elements in the `nums` array. Given constraints (`N, M <= 10^5`), this would time out.
* **Optimization (Lookup Table):** To achieve an `O(N+M)` solution, we need an `O(1)` way to check if a node's value exists in `nums`.
    * The constraints (`nums[i] <= 10^5`, `Node.val <= 10^5`) are perfect for a **boolean array** (or frequency array) of size `100001`.
    * **Pass 1 (O(M)):** We iterate through the `nums` array and mark `toDelete[num] = true` for every number to be deleted.
* **Linked List Deletion (Dummy Head Pattern):** Deleting nodes from a linked list, especially the `head` node, can be complex.
    * **Pass 2 (O(N)):** We use the **"dummy head"** pattern to simplify this.
    1.  A `dummy` node is created and pointed to the real `head` (`dummy.next = head`).
    2.  Two pointers are used: `prev` (starts at `dummy`) and `current` (starts at `head`).
    3.  We iterate `while (current != null)`.
    4.  If `toDelete[current.val]` is `true`, we "bypass" the current node by setting `prev.next = current.next`. Note that `prev` does *not* move forward in this case.
    5.  If it's `false`, the node should be kept, so we advance `prev` to `current` (`prev = current`).
    6.  `current` always advances (`current = current.next`).
    7.  The new head of the list is returned as `dummy.next`.
* **Performance:**
    * **Time Complexity:** `O(M + N)`, where `M` is `nums.length` (to build the `toDelete` array) and `N` is the list length (to traverse the list).
    * **Space Complexity:** `O(K)`, where `K` is the maximum value in `nums` (in this case, `100001`). This is constant space relative to `N` or `M`.