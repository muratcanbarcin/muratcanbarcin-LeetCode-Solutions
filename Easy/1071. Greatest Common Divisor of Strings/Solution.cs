using System;

public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        if (str1 + str2 != str2 + str1) {
            return "";
        }
        
        int gCD = FindGCDByEuclidean(str1.Length, str2.Length);
        
        return str1.Substring(0, gCD);
    }

    private static int FindGCDByEuclidean(int a, int b) {
        if (b == 0) {
            return a;
        }
        return FindGCDByEuclidean(b, a % b);
    }
}