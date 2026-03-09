class Solution {
    public int equalPairs(int[][] grid) {
        Map<String, Integer> rowCounts = new HashMap<>();
        int n = grid.length;

        for (int i = 0; i < n; i++) {
            StringBuilder rStr = new StringBuilder();
            for (int j = 0; j < n; j++) {
                rStr.append(grid[i][j]).append(","); 
            }
            String s = rStr.toString();
            rowCounts.put(s, rowCounts.getOrDefault(s, 0) + 1);
        }

        int counter = 0;

        for (int j = 0; j < n; j++) {
            StringBuilder cStr = new StringBuilder();
            for (int i = 0; i < n; i++) {
                cStr.append(grid[i][j]).append(",");
            }
            String s = cStr.toString();

            if (rowCounts.containsKey(s)) {
                counter += rowCounts.get(s);
            }
        }

        return counter;
    }
}

