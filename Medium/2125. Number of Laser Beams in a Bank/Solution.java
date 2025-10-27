class Solution {
    public int numberOfBeams(String[] bank) {
        int totalBeams = 0;
        int prevDeviceCount = 0; // Stores the device count of the last row that had devices

        for (String row : bank) {
            // Count devices in the current row
            int currentDeviceCount = row.length() - row.replace("1", "").length();

            // If this row has devices...
            if (currentDeviceCount > 0) {
                // Add beams connecting this row to the previous device-row
                totalBeams += (prevDeviceCount * currentDeviceCount);
                // Update the 'previous' count for the next iteration
                prevDeviceCount = currentDeviceCount;
            }
            // If currentDeviceCount is 0 (empty row), we do nothing.
            // prevDeviceCount stays the same, waiting for the next row with devices.
        }

        return totalBeams;
    }
}