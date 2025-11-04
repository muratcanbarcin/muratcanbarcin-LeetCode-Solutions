class Solution {
    public int countUnguarded(int m, int n, int[][] guards, int[][] walls) {
        
        int[][] grid = new int[m][n];
        int count = 0;
        
        int EMPTY = 0;
        int GUARD = 1;
        int WALL = 2;
        int GUARDED = 3;

        for (int[] wall : walls) {
            grid[wall[0]][wall[1]] = WALL;
        }
        
        for (int[] guard : guards) {
            grid[guard[0]][guard[1]] = GUARD;
        }
        
        for (int r = 0; r < m; r++) {
            boolean isGuarded = false;
            
            for (int c = 0; c < n; c++) {
                if (grid[r][c] == GUARD) {
                    isGuarded = true;
                } else if (grid[r][c] == WALL) {
                    isGuarded = false;
                } else if (grid[r][c] == EMPTY && isGuarded) {
                    grid[r][c] = GUARDED;
                }
            }
            
            isGuarded = false;
            
            for (int c = n - 1; c >= 0; c--) {
                if (grid[r][c] == GUARD) {
                    isGuarded = true;
                } else if (grid[r][c] == WALL) {
                    isGuarded = false;
                } else if (grid[r][c] == EMPTY && isGuarded) {
                    grid[r][c] = GUARDED;
                }
            }
        }
        
        for (int c = 0; c < n; c++) {
            boolean isGuarded = false;
            
            for (int r = 0; r < m; r++) {
                if (grid[r][c] == GUARD) {
                    isGuarded = true;
                } else if (grid[r][c] == WALL) {
                    isGuarded = false;
                } else if (grid[r][c] == EMPTY && isGuarded) {
                    grid[r][c] = GUARDED;
                }
            }
            
            isGuarded = false;
            
            for (int r = m - 1; r >= 0; r--) {
                if (grid[r][c] == GUARD) {
                    isGuarded = true;
                } else if (grid[r][c] == WALL) {
                    isGuarded = false;
                } else if (grid[r][c] == EMPTY && isGuarded) {
                    grid[r][c] = GUARDED;
                }
            }
        }
        
        for (int r = 0; r < m; r++) {
            for (int c = 0; c < n; c++) {
                if (grid[r][c] == EMPTY) {
                    count++;
                }
            }
        }
        
        return count;
    }
}