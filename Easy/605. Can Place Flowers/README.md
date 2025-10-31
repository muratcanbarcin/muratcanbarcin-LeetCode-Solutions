# 605. Can Place Flowers

**Difficulty:** Easy
| **Platform:** LeetCode | **Status:** Solved |
| :--- | :--- |

[Link to Problem on LeetCode](https://leetcode.com/problems/can-place-flowers/)

## Problem Description

You have a long flowerbed in which some of the plots are planted, and some are not. However, flowers cannot be planted in adjacent plots.

Given an integer array `flowerbed` containing 0's and 1's, where 0 means empty and 1 means not empty, and an integer `n`, return `true` if `n` new flowers can be planted in the flowerbed without violating the no-adjacent-flowers rule and `false` otherwise.

### Example 1:

**Input:** flowerbed = [1,0,0,0,1], n = 1
**Output:** true

### Example 2:

**Input:** flowerbed = [1,0,0,0,1], n = 2
**Output:** false

## Solution Analysis (Java)

The provided Java solution uses a **single-pass stateful iteration** approach to solve the problem in `O(N)` time and `O(1)` space.

* [Solution.java](./Solution.java)

### Key Concepts
* **State Flag:** The solution iterates through the array once, using a boolean flag `isPlantedNext` to keep track of the state. This flag represents whether the *previous* slot was empty (or safe), allowing a plant in the current slot.
* **Core Logic:**
    1.  The loop iterates from `i=0` to `flowerbed.length-1`.
    2.  `if(flowerbed[i] == 1)`: If the current slot is a `1`, it sets `isPlantedNext = false`, indicating that the *next* slot (`i+1`) cannot have a flower.
    3.  `else if(flowerbed[i]==0 && isPlantedNext && flowerbed[i+1] !=1)`: This is the "plant" condition. It checks if:
        * The current slot (`i`) is empty (`0`).
        * The previous slot was safe (`isPlantedNext == true`).
        * The next slot (`i+1`) is also safe (not `1`).
        * If all are true, it increments `plantableCounter` and sets `isPlantedNext = false` (because we just "planted" here, blocking `i+1`).
    4.  `else if(flowerbed[i]==0 && !isPlantedNext)`: This is the "reset" condition. If the current slot is `0` but the previous slot was blocked (e.g., `[1, 0, ...]`), this slot is safe, so we reset `isPlantedNext = true`, allowing the *next* slot (`i+1`) to be considered for planting.
* **Edge Case Handling:** The solution handles edge cases explicitly:
    * `if(flowerbed.length == 1 && flowerbed[0] == 0)`: Checks for the single-empty-plot scenario.
    * `if(flowerbed[i+1]==0 && i== flowerbed.length-2 && isPlantedNext)`: Adds a specific check for the very last plot in the array (`flowerbed.length-1`) to see if it's possible to plant there.
* **Performance:**
    * **Time Complexity:** `O(N)`, where `N` is the length of the `flowerbed` array. The array is traversed only once.
    * **Space Complexity:** `O(1)`. Only a few extra variables (`isPlantedNext`, `plantableCounter`) are used.