public class Solution {
    public int[] GetSneakyNumbers(int[] nums) {
        int n = nums.Length - 2;
        int[] freq = new int[n];
        
        int[] sneakyArr = new int[2];
        int count = 0;

        foreach (int num in nums) {
            freq[num]++;
            
            if (freq[num] == 2) {
                sneakyArr[count] = num;
                count++;
                
                if (count == 2) {
                    break;
                }
            }
        }
        
        return sneakyArr;
    }
}