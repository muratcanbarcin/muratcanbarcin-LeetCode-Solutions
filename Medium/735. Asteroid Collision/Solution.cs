using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        var stack = new Stack<int>();

        foreach (int ast in asteroids) {
            bool yasiyorMu = true;

            while (stack.Count > 0 && stack.Peek() > 0 && ast < 0) {
                if (stack.Peek() < Math.Abs(ast)) {
                    stack.Pop();
                    continue;
                } else if (stack.Peek() == Math.Abs(ast)) {
                    stack.Pop();
                }

                yasiyorMu = false;
                break;
            }

            if (yasiyorMu) {
                stack.Push(ast);
            }
        }

        int[] result = new int[stack.Count];
        for (int i = result.Length - 1; i >= 0; i--) {
            result[i] = stack.Pop();
        }

        return result;
    }
}