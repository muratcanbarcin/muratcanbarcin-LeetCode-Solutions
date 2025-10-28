import java.util.Arrays;

class Solution {
    public int countValidSelections(int[] nums) {
        int validSelections = 0;
        int n = nums.length;

        for (int i = 0; i < n; i++) {
            if (nums[i] == 0) {
                if (isSelectionValid(nums, i, -1)) {
                    validSelections++;
                }
                if (isSelectionValid(nums, i, 1)) {
                    validSelections++;
                }
            }
        }
        return validSelections;
    }

 
    private boolean isSelectionValid(int[] originalNums, int startCurr, int startDir) {

        int[] nums = Arrays.copyOf(originalNums, originalNums.length);
        int n = nums.length;
        
        int curr = startCurr;
        int dir = startDir; 
        

        int maxSteps = 10000000; 
        int steps = 0;

        while (curr >= 0 && curr < n && steps < maxSteps) {
            steps++; 
            
            if (nums[curr] > 0) {
                nums[curr]--;     
                dir = -dir;      
                curr += dir;     
            } else {
                curr += dir;      
            }
        }
        
        for (int num : nums) {
            if (num > 0) {
                return false; 
            }
        }
        
        return true; 
    }
}