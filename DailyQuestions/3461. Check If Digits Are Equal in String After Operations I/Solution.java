import java.lang.StringBuilder;

class Solution {
    public boolean hasSameDigits(String s) {

        while (s.length() > 2) {
            // Create temp new string
            StringBuilder newS = new StringBuilder();

            for (int i = 0; i < s.length() - 1; i++) {
                // Convert char to int
                int num1 = s.charAt(i) - '0';
                int num2 = s.charAt(i+1) - '0';

                int newNum = (num1 + num2) % 10;
                newS.append(newNum);
            }
            // Update 's' for the next loop
            s = newS.toString();
        }

        // Final check
        return s.charAt(0) == s.charAt(1);
    }
}