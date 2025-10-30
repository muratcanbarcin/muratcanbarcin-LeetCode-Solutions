public class Solution {
    public int SmallestNumber(int n) {
        int result = 0;
        int bitPosition = 0;

        while (n > result) {
            result += (int) Math.Pow(2, bitPosition);
            bitPosition++;
        }
        return result;
        
    }
}