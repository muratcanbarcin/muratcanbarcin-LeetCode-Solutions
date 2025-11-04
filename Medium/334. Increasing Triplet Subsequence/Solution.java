class Solution {
    public boolean increasingTriplet(int[] nums) {
        int first_min = Integer.MAX_VALUE;
        int second_min = Integer.MAX_VALUE;
        
        for (int num : nums) {
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