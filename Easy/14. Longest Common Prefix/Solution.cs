public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs == null || strs.Length == 0) {
            return "";
        }
        
        string prefix = strs[0];
        
        for (int i = 1; i < strs.Length; i++) {
            
            // While the current string 'strs[i]' does NOT start with 'prefix'...
            while (!strs[i].StartsWith(prefix)) {
                
                // ...shrink the prefix.
                prefix = prefix.Substring(0, prefix.Length - 1);
                
                // If the prefix becomes empty, no common prefix exists.
                if (string.IsNullOrEmpty(prefix)) {
                    return "";
                }
            }
        }
        
        return prefix;
    }
}