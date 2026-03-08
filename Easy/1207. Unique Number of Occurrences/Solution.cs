using System;
using System.Collections.Generic;

public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        var counter = new Dictionary<int, int>();
        var checking = new HashSet<int>();
        foreach (var num in arr) {
            if (counter.ContainsKey(num)) {
                counter[num]++;
            } else {
                counter[num] = 1;
            }
        }
        
        foreach (var num1 in counter.Values) {
            if (checking.Contains(num1)) {
                return false;
            } else {
                checking.Add(num1);
            }
        }
        return true;
    }
}