# 735. Asteroid Collision

**Difficulty:** Medium
| **Platform:** LeetCode | **Status:** Solved |
| :--- | :--- | 

[Link to Problem on LeetCode](https://leetcode.com/problems/asteroid-collision/)

## Problem Description

We are given an array `asteroids` of integers representing asteroids in a row.

For each asteroid, the absolute value represents its size, and the sign represents its direction (positive = right, negative = left). Each asteroid moves at the same speed.

Find out the state of the asteroids after all collisions. If two asteroids meet, the smaller one will explode. If both are the same size, both will explode. Two asteroids moving in the same direction will never meet.

### Example 1:

**Input:** asteroids = [5,10,-5]  
**Output:** [5,10]  
**Explanation:** The 10 and -5 collide exploding each other. The 5 and 10 never collide.

### Example 2:

**Input:** asteroids = [8,-8]  
**Output:** []  
**Explanation:** The 8 and -8 collide exploding each other.

### Example 3:

**Input:** asteroids = [10,2,-5]  
**Output:** [10]  
**Explanation:** The 2 and -5 collide resulting in -5. The 10 and -5 collide resulting in 10.

## Solution Analysis

The solution uses a **Stack** to simulate the asteroid collisions. As we iterate through each asteroid:
- If the current asteroid is moving right (positive), we push it onto the stack.
- If the current asteroid is moving left (negative), we check for collisions with right-moving asteroids on top of the stack.
- We simulate collisions by comparing sizes and updating the stack accordingly.

The key insight is that only right-moving asteroids (positive) can collide with left-moving asteroids (negative), and these collisions are handled before any new asteroid is added.

* [Solution.java](./Solution.java)
* [Solution.cs](./Solution.cs)
* [Solution.py](./Solution.py)

### Key Concepts
* **Stack Data Structure:** Efficient for managing collision scenarios where we need to compare the last added element with the current one.
* **Collision Simulation:** Right-moving asteroids on the stack can only collide with left-moving asteroids entering from the right.
* **Size Comparison:** Determine survival based on asteroid sizes during collisions.
* **Time Complexity:** O(n) where n is the number of asteroids, as each asteroid is processed once.
* **Space Complexity:** O(n) in the worst case when all asteroids survive.

### Performance
- **Time:** O(n)
- **Space:** O(n)
- **Runtime:** Efficient single-pass solution for typical input sizes.