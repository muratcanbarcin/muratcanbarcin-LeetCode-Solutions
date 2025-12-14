using System;

public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int left = 0;
        int right = 0;
        int maxCounter = 0;
        int zeros = 0;

        while (right < nums.Length) {
            if (nums[right] == 0) {
                zeros++;
            }

            while (zeros > k) {
                if (nums[left] == 0) {
                    zeros--;
                }
                left++;
            }

            maxCounter = Math.Max(maxCounter, right - left + 1);
            
            right++;
        }
        
        return maxCounter;
    }
}