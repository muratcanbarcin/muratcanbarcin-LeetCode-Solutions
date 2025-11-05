class Solution {
    public int compress(char[] chars) {
        
        int writeIndex = 0;
        int readIndex = 0;
        
        while (readIndex < chars.length) {
            char currentChar = chars[readIndex];
            int count = 0;
            
            while (readIndex < chars.length && chars[readIndex] == currentChar) {
                readIndex++;
                count++;
            }
            
            chars[writeIndex] = currentChar;
            writeIndex++;
            
            if (count > 1) {
                String countStr = String.valueOf(count);
                for (char c : countStr.toCharArray()) {
                    chars[writeIndex] = c;
                    writeIndex++;
                }
            }
        }
        
        return writeIndex;
    }
}