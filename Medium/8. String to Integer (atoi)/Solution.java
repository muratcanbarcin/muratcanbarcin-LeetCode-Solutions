class Solution {
    public int myAtoi(String s) {
        int index = 0;
        int sign = 1;
        int result = 0;
        int n = s.length();

        // Step 1: Ignore leading whitespace
        while (index < n && s.charAt(index) == ' ') {
            index++;
        }

        // Step 2: Determine signedness
        if (index < n && (s.charAt(index) == '+' || s.charAt(index) == '-')) {
            sign = (s.charAt(index) == '-') ? -1 : 1;
            index++;
        }

        // Step 3: Read the integer
        while (index < n && Character.isDigit(s.charAt(index))) {
            int digit = s.charAt(index) - '0';

            // Step 4: Handle rounding/clamping (Overflow Check)
            // Check if 'result * 10 + digit' will overflow
            if (result > Integer.MAX_VALUE / 10 || (result == Integer.MAX_VALUE / 10 && digit > 7)) {
                return (sign == 1) ? Integer.MAX_VALUE : Integer.MIN_VALUE;
            }

            result = result * 10 + digit;
            index++;
        }

        // Return the final result with the correct sign.
        return result * sign;
    }
}
