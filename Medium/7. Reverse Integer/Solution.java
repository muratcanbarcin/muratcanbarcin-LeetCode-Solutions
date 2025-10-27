class Solution {
    public int reverse(int x) {
        int reversed = 0;
        
        while (x != 0) {
            // Get the last digit
            int pop = x % 10;
            // Remove the last digit
            x /= 10;
            
            // --- CRITICAL OVERFLOW CHECK ---
            // Check for positive overflow
            if (reversed > Integer.MAX_VALUE / 10 || (reversed == Integer.MAX_VALUE / 10 && pop > 7)) {
                return 0;
            }
            // Check for negative overflow
            if (reversed < Integer.MIN_VALUE / 10 || (reversed == Integer.MIN_VALUE / 10 && pop < -8)) {
                return 0;
            }
            // --- END OF CHECK ---
            
            // Push the digit to the reversed number
            reversed = reversed * 10 + pop;
        }
        
        return reversed;
    }
}