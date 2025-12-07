class Solution:
    def isSubsequence(self, s: str, t: str) -> bool:
        if not s:
            return True
            
        s_index = 0
        
        for char in t:
            if char == s[s_index]:
                s_index += 1
            
            if s_index == len(s):
                return True
                
        return False