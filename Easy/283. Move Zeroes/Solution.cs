public class Solution {
    public void MoveZeroes(int[] nums) {
        int slow = 0;
        
        for (int fast = 0; fast < nums.Length; fast++) {
            if (nums[fast] != 0) {
                // Swap logic using a temp variable
                int temp = nums[slow];
                nums[slow] = nums[fast];
                nums[fast] = temp;
                
                slow++;
            }
        }
    }
}