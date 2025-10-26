class Solution {
    public String longestCommonPrefix(String[] strs) {
        // If the array is empty, there's no prefix.
        if (strs == null || strs.length == 0) {
            return "";
        }
        
        // Start by assuming the first string is the prefix.
        String prefix = strs[0];
        
        // Compare this prefix against all other strings (starting from the second one).
        for (int i = 1; i < strs.length; i++) {
            
            // While the current string 'strs[i]' does NOT start with our 'prefix'...
            // Java's indexOf() returns 0 if the string starts with the prefix.
            while (strs[i].indexOf(prefix) != 0) {
                
                // ...shrink the prefix by removing the last character.
                prefix = prefix.substring(0, prefix.length() - 1);
                
                // If the prefix becomes empty, no common prefix exists.
                if (prefix.isEmpty()) {
                    return "";
                }
            }
        }
        
        // Return the prefix that survived all comparisons.
        return prefix;
    }
}