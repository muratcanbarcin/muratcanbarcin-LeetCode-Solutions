using System;
using System.Collections.Generic;
using System.Text;

public class Solution {
    
    private List<string> results;
    private Dictionary<char, string> digitToLetters;

    public IList<string> LetterCombinations(string digits) {
        results = new List<string>();
        
        if (string.IsNullOrEmpty(digits)) {
            return results;
        }
        
        digitToLetters = new Dictionary<char, string> {
            {'2', "abc"}, {'3', "def"}, {'4', "ghi"},
            {'5', "jkl"}, {'6', "mno"}, {'7', "pqrs"},
            {'8', "tuv"}, {'9', "wxyz"}
        };
        
        Backtrack(0, digits, new StringBuilder());
        return results;
    }
    
    private void Backtrack(int index, string digits, StringBuilder currentCombination) {
        
        if (index == digits.Length) {
            results.Add(currentCombination.ToString());
            return;
        }
        
        char currentDigit = digits[index];
        string letters = digitToLetters[currentDigit];
        
        foreach (char letter in letters) {
            currentCombination.Append(letter);
            Backtrack(index + 1, digits, currentCombination);
            currentCombination.Remove(currentCombination.Length - 1, 1);
        }
    }
}