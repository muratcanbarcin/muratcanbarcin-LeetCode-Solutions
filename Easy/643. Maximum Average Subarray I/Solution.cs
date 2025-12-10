using System;

public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        int currentSum = 0;
        
        for (int i = 0; i < k; i++) {
            currentSum += nums[i];
        }
        
        int maxSum = currentSum;
        
        for (int i = k; i < nums.Length; i++) {
            currentSum += nums[i] - nums[i - k];
            maxSum = Math.Max(maxSum, currentSum);
        }
        
        return (double) maxSum / k;
    }
}