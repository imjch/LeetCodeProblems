# Suppose an array sorted in ascending order is rotated at some pivot unknown to you beforehand.

# (i.e.,  [0,1,2,4,5,6,7] might become  [4,5,6,7,0,1,2]).

# Find the minimum element.

# The array may contain duplicates.

# Example 1:

# Input: [1,3,5]
# Output: 1
# Example 2:

# Input: [2,2,2,0,1]
# Output: 0
# Note:

# This is a follow up problem to Find Minimum in Rotated Sorted Array.
# Would allow duplicates affect the run-time complexity? How and why?

class Solution(object):

    def getMin(self, arrEle):
        if len(arrEle) <= 1:
            return arrEle[0]
        mid = len(arrEle) / 2
        arrLeft = arrEle[:mid]
        arrRight = arrEle[mid:]
        leftMin = self.getMin(arrLeft)
        rightMin = self.getMin(arrRight)
        return min(leftMin, rightMin)

    def findMin(self, nums):
        """
        :type nums: List[int]
        :rtype: int
        """
        return self.getMin(nums)


obj = Solution()
print obj.findMin([1,3,5])