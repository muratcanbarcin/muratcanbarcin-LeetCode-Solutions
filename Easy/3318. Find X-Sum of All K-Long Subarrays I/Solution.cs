using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] FindXSum(int[] nums, int k, int x) {
        int answerSize = nums.Length - k + 1;
        int[] answer = new int[answerSize];

        for (int i = 0; i < answerSize; i++) {
            
            int[] subArray = new int[k];
            for (int j = 0; j < k; j++) {
                subArray[j] = nums[i + j];
            }
            
            int xSum = XSumCalc(subArray, x);
            answer[i] = xSum;
        }
        return answer;
    }

    public int XSumCalc(int[] arr, int x) {
        Dictionary<int, int> freq = new Dictionary<int, int>();

        foreach (int num in arr) {
            if (freq.ContainsKey(num)) {
                freq[num]++;
            } else {
                freq[num] = 1;
            }
        }
        
        var sortedEntries = freq.OrderByDescending(pair => pair.Value)
                                .ThenByDescending(pair => pair.Key)
                                .ToList();
        
        int totalSum = 0;
        
        for (int i = 0; i < x && i < sortedEntries.Count; i++) {
            var entry = sortedEntries[i];
            totalSum += entry.Key * entry.Value;
        }
        
        return totalSum;
    }
}