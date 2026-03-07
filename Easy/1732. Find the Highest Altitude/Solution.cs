using System;
using System.Linq;

public class Solution {
    public int LargestAltitude(int[] gain) {
        int max = 0;
        int current = 0;
        foreach (int g in gain) {
            current += g;
            max = Math.Max(max, current);
        }
        return max;
    }
}
