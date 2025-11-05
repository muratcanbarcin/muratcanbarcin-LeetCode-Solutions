public class Solution {
    public int Compress(char[] chars) {
        
        int writeIndex = 0;
        int readIndex = 0;
        
        while (readIndex < chars.Length) {
            char currentChar = chars[readIndex];
            int count = 0;
            
            while (readIndex < chars.Length && chars[readIndex] == currentChar) {
                readIndex++;
                count++;
            }
            
            chars[writeIndex] = currentChar;
            writeIndex++;
            
            if (count > 1) {
                String countStr = count.ToString();
                foreach (char c in countStr) {
                    chars[writeIndex] = c;
                    writeIndex++;
                }
            }
        }
        
        return writeIndex;
    }
}