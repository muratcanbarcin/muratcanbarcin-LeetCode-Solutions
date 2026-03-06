using System;

public class Solution {
    public int LongestSubarray(int[] nums) {
        int n = nums.Length;
        
        int left = 0;
        int zeros = 0;
        int ans = 0;
        
        for (int right = 0; right < n; right++) {
            if (nums[right] == 0) {
                zeros++;
            }
            
            while (zeros > 1) {
                if (nums[left] == 0) {
                    zeros--;
                }
                left++;
            }
            
            ans = Math.Max(ans, right - left + 1 - zeros);
        }
        
        return (ans == n) ? ans - 1 : ans;
    }
}
