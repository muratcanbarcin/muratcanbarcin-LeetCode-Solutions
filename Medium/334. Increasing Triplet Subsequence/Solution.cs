public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        int first_min = int.MaxValue;
        int second_min = int.MaxValue;
        
        foreach (int num in nums) {
            if (num <= first_min) {
                first_min = num;
            } else if (num <= second_min) {
                second_min = num;
            } else {
                return true;
            }
        }
        
        return false;
    }
}