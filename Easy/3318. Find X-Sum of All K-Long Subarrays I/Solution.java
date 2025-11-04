import java.util.HashMap;
import java.util.Map;
import java.util.ArrayList;
import java.util.List;
import java.util.Collections;

class Solution {
    public int[] findXSum(int[] nums, int k, int x) {
        int answerSize = nums.length - k + 1;
        int[] answer = new int[answerSize];

        for (int i = 0; i < answerSize; i++) {
            
            int[] subArray = new int[k];
            for (int j = 0; j < k; j++) {
                subArray[j] = nums[i + j];
            }
            
            int xSum = xSumCalc(subArray, x);
            answer[i] = xSum;
        }
        return answer;
    }

    public int xSumCalc(int[] arr, int x) {
        Map<Integer, Integer> freq = new HashMap<>();

        for (int num : arr) {
            freq.put(num, freq.getOrDefault(num, 0) + 1);
        }
        
        List<Map.Entry<Integer, Integer>> sortedEntries = new ArrayList<>(freq.entrySet());
        
        Collections.sort(sortedEntries, (a, b) -> {
            if (a.getValue() != b.getValue()) {
                return b.getValue().compareTo(a.getValue());
            } else {
                return b.getKey().compareTo(a.getKey());
            }
        });
        
        int totalSum = 0;
        
        for (int i = 0; i < x && i < sortedEntries.size(); i++) {
            Map.Entry<Integer, Integer> entry = sortedEntries.get(i);
            totalSum += entry.getKey() * entry.getValue();
        }
        
        return totalSum;
    }
}