# 2043. Simple Bank System

**Difficulty:** Medium
| **Platform:** LeetCode | **Status:** Solved |
| :--- | :--- |

[Link to Problem on LeetCode](https://leetcode.com/problems/simple-bank-system/)

## Problem Description

You have been tasked with writing a program for a popular bank that will automate all its incoming transactions (transfer, deposit, and withdraw). The bank has `n` accounts numbered from `1` to `n`. The initial balance of each account is stored in a 0-indexed integer array `balance`, with the `(i + 1)`th account having an initial balance of `balance[i]`.

Execute all the valid transactions. A transaction is valid if:
* The given account number(s) are between `1` and `n`.
* The amount of money withdrawn or transferred from is less than or equal to the balance of the account.

Implement the `Bank` class:
* `Bank(long[] balance)`: Initializes the object with the 0-indexed integer array `balance`.
* `boolean transfer(int account1, int account2, long money)`: Transfers `money` dollars from `account1` to `account2`. Returns `true` if the transaction was successful, `false` otherwise.
* `boolean deposit(int account, long money)`: Deposits `money` dollars into the `account`. Returns `true` if the transaction was successful, `false` otherwise.
* `boolean withdraw(int account, long money)`: Withdraws `money` dollars from the `account`. Returns `true` if the transaction was successful, `false` otherwise.

### Example 1:

**Input**
`["Bank", "withdraw", "transfer", "deposit", "transfer", "withdraw"]`
`[[[10, 100, 20, 50, 30]], [3, 10], [5, 1, 20], [5, 20], [3, 4, 15], [10, 50]]`
**Output**
`[null, true, true, true, false, false]`

**Explanation**

Bank bank = new Bank([10, 100, 20, 50, 30]);
bank.withdraw(3, 10);    // return true, account 3 has a balance of $20, so it is valid to withdraw $10.
                         // Account 3 has $20 - $10 = $10.
bank.transfer(5, 1, 20); // return true, account 5 has a balance of $30, so it is valid to transfer $20.
                         // Account 5 has $30 - $20 = $10, and account 1 has $10 + $20 = $30.
bank.deposit(5, 20);     // return true, it is valid to deposit $20 to account 5.
                         // Account 5 has $10 + $20 = $30.
bank.transfer(3, 4, 15); // return false, the current balance of account 3 is $10,
                         // so it is invalid to transfer $15 from it.
bank.withdraw(10, 50);   // return false, it is invalid because account 10 does not exist.

## Solutions

Optimized solutions for this problem are available in this folder:

* [Bank.java](./Bank.java)
* [Bank.cs](./Bank.cs)

### Key Concepts
* **Object-Oriented Design (OOD):** The problem is a direct implementation of a class, its constructor, and its methods.
* **Data Encapsulation:** The `balance` array is (or should be) `private` to the `Bank` class. Using an *instance variable* (non-static) is critical so that multiple `Bank` instances don't share the same `balance` array.
* **Time Complexity:** All operations (`transfer`, `deposit`, `withdraw`) are `O(1)` because they involve direct array lookups and updates, which do not depend on the number of accounts `n`.
* **1-based vs. 0-based Indexing:** A core part of the problem is translating the 1-based account numbers (e.g., `account1`) to 0-based array indices (`account1 - 1`).
* **DRY Principle:** A private helper method (e.g., `isValidAccount`) can be used to centralize the validation logic (`account >= 1 && account <= n`) and avoid repeating it in all three public methods.