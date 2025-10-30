class Solution(object):
    def smallestNumber(self, n):
        """
        :type n: int
        :rtype: int
        """
        result = 0
        bit_position = 0

        while n > result:
            result += 2 ** bit_position
            bit_position += 1

        return result