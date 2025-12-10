using System;
using System.Collections.Generic;

public class Solution {
    public int MaxVowels(string s, int k) {
        var vowelSet = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
        
        int currentVowels = 0;
        
        // İlk pencereyi hesapla
        for (int i = 0; i < k; i++) {
            if (vowelSet.Contains(s[i])) {
                currentVowels++;
            }
        }
        
        int maxVowels = currentVowels;
        if (maxVowels == k) return k;
        
        // Pencereyi kaydır
        for (int i = k; i < s.Length; i++) {
            // Yeni giren karakter
            if (vowelSet.Contains(s[i])) {
                currentVowels++;
            }
            
            // Pencereden çıkan karakter
            if (vowelSet.Contains(s[i - k])) {
                currentVowels--;
            }
            
            maxVowels = Math.Max(maxVowels, currentVowels);
            if (maxVowels == k) return k;
        }
        
        return maxVowels;
    }
}