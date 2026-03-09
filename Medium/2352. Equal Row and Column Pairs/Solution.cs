using System;
using System.Collections.Generic;
using System.Text;

public class Solution {
    public int EqualPairs(int[][] grid) {
        var rowCounts = new Dictionary<string, int>();
        int n = grid.Length;

        for (int i = 0; i < n; i++) {
            var sb = new StringBuilder();
            for (int j = 0; j < n; j++) {
                sb.Append(grid[i][j]).Append(',');
            }
            string s = sb.ToString();
            if (rowCounts.ContainsKey(s))
                rowCounts[s]++;
            else
                rowCounts[s] = 1;
        }

        int counter = 0;
        for (int j = 0; j < n; j++) {
            var sb = new StringBuilder();
            for (int i = 0; i < n; i++) {
                sb.Append(grid[i][j]).Append(',');
            }
            string s = sb.ToString();
            if (rowCounts.TryGetValue(s, out int count)) {
                counter += count;
            }
        }

        return counter;
    }
}