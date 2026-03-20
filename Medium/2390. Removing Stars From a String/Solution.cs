using System;
using System.Collections.Generic;
using System.Text;

public class Solution {
    public string RemoveStars(string s) {
        var stack = new Stack<char>();
        
        foreach (char c in s) {
            if (c == '*') {
                if (stack.Count > 0) {
                    stack.Pop();
                }
            } else {
                stack.Push(c);
            }
        }
        
        var sb = new StringBuilder();
        while (stack.Count > 0) {
            sb.Insert(0, stack.Pop());
        }
        
        return sb.ToString();
    }
}