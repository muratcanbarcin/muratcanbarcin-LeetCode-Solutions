class Solution:
    def numberOfBeams(self, bank):
        total_beams = 0
        prev_device_count = 0  # Stores the device count of the last row that had devices

        for row in bank:
            # Count devices in the current row
            current_device_count = row.count('1')
            
            # If this row has devices...
            if current_device_count > 0:
                # Add beams connecting this row to the previous device-row
                total_beams += (prev_device_count * current_device_count)
                # Update the 'previous' count for the next iteration
                prev_device_count = current_device_count
        
        return total_beams