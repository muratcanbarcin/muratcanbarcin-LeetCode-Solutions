class Solution:
    def maxVowels(self, s: str, k: int) -> int:
        vowels = {'a', 'e', 'i', 'o', 'u'}
        current_vowels = 0
        
        for i in range(k):
            if s[i] in vowels:
                current_vowels += 1
                
        max_vowels = current_vowels
        if max_vowels == k:
            return k
            
        for i in range(k, len(s)):
            if s[i] in vowels:
                current_vowels += 1
            
            if s[i - k] in vowels:
                current_vowels -= 1
                
            max_vowels = max(max_vowels, current_vowels)
            
            if max_vowels == k:
                return k
                
        return max_vowels