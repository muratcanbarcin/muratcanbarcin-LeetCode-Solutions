from collections import Counter

class Solution:
    def equalPairs(self, grid: list[list[int]]) -> int:
        n = len(grid)
        row_counts = Counter()
        
        # convert each row to tuple and count
        for row in grid:
            row_counts[tuple(row)] += 1
        
        result = 0
        for j in range(n):
            col = tuple(grid[i][j] for i in range(n))
            result += row_counts[col]
        
        return result