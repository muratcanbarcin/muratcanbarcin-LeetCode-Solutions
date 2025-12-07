class Solution:
    def maxArea(self, height: list[int]) -> int:
        left = 0
        right = len(height) - 1
        max_area = 0
        
        while left < right:
            # Genişlik * Kısa Olan Yükseklik
            width = right - left
            current_area = min(height[left], height[right]) * width
            max_area = max(max_area, current_area)
            
            # Kısa olan tarafı değiştir
            if height[left] < height[right]:
                left += 1
            else:
                right -= 1
                
        return max_area