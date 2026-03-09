from collections import Counter

class Solution:
    def closeStrings(self, word1: str, word2: str) -> bool:
        freq1 = Counter(word1)
        freq2 = Counter(word2)
        
        # Check if they have the same unique characters
        if set(freq1.keys()) != set(freq2.keys()):
            return False
        
        # Check if frequency distributions are the same
        return sorted(freq1.values()) == sorted(freq2.values())