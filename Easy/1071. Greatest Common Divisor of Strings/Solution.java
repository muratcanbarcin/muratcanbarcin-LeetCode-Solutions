class Solution {
    public String gcdOfStrings(String str1, String str2) {
        if (!((str1 + str2).equals(str2 + str1))) {return "";}
        int gCD = findGCDByEuclidean(str1.length(),str2.length());
        
        return str1.substring(0,gCD);
    }

    public static int findGCDByEuclidean(int a, int b) {
        if (b == 0) {
            return a;
        }
        return findGCDByEuclidean(b, a % b);
    }
}
