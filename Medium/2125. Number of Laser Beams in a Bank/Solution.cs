using System;

public class Solution {
    public int NumberOfBeams(string[] bank) {
        int totalBeams = 0;
        int prevDeviceCount = 0; // Stores the device count of the last row that had devices

        foreach (string row in bank) {
            // Count devices in the current row
            int currentDeviceCount = row.Length - row.Replace("1", "").Length;

            // If this row has devices...
            if (currentDeviceCount > 0) {
                // Add beams connecting this row to the previous device-row
                totalBeams += (prevDeviceCount * currentDeviceCount);
                // Update the 'previous' count for the next iteration
                prevDeviceCount = currentDeviceCount;
            }
        }

        return totalBeams;
    }
}