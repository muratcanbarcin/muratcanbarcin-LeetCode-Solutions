import java.util.List;
import java.util.ArrayList;
import java.util.Map;
import java.util.HashMap;

class Solution {
    
    private List<String> results;
    private Map<Character, String> digitToLetters;

    public List<String> letterCombinations(String digits) {
        results = new ArrayList<>();
        
        if (digits == null || digits.length() == 0) {
            return results;
        }
        
        digitToLetters = Map.of(
            '2', "abc", '3', "def", '4', "ghi",
            '5', "jkl", '6', "mno", '7', "pqrs",
            '8', "tuv", '9', "wxyz"
        );
        
        backtrack(0, digits, new StringBuilder());
        
        return results;
    }
    
    private void backtrack(int index, String digits, StringBuilder currentCombination) {
        
        if (index == digits.length()) {
            results.add(currentCombination.toString());
            return;
        }
        
        char currentDigit = digits.charAt(index);
        String letters = digitToLetters.get(currentDigit);
        
        for (char letter : letters.toCharArray()) {
            currentCombination.append(letter);
            backtrack(index + 1, digits, currentCombination);
            currentCombination.deleteCharAt(currentCombination.length() - 1);
        }
    }
}