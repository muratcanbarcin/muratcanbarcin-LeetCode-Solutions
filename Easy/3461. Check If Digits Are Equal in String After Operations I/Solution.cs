using System.Text;

public class Solution {
    public bool HasSameDigits(string s) {
        
        while (s.Length > 2) {
            // Use StringBuilder for performance
            StringBuilder newS = new StringBuilder();
            
            for (int i = 0; i < s.Length - 1; i++) {
                // Convert char to int
                int num1 = s[i] - '0';
                int num2 = s[i+1] - '0';
                
                int newNum = (num1 + num2) % 10;
                newS.Append(newNum);
            }
            // Update 's' for the next loop
            s = newS.ToString();
        }
        
        // Final check
        return s[0] == s[1];
    }
}