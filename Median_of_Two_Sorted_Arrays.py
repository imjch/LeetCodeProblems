# There are two sorted arrays nums1 and nums2 of size m and n respectively.

# Find the median of the two sorted arrays. The overall run time complexity should be O(log (m+n)).

# You may assume nums1 and nums2 cannot be both empty.

# Example 1:

# nums1 = [1, 3]
# nums2 = [2]

# The median is 2.0
# Example 2:

# nums1 = [1, 2]
# nums2 = [3, 4]

# The median is (2 + 3)/2 = 2.5

class Solution(object):
    def findMedianSortedArrays(self, nums1, nums2):
        """
        :type nums1: List[int]
        :type nums2: List[int]
        :rtype: float
        """
        len1 = len(nums1)
        len2 = len(nums2)
        i = j = step = 0
        resHead = 0
        resTail = 0
        mid = (len1 + len2) / 2
        while step <= mid:
            resTail = resHead
            if i < len1 and j < len2 and nums1[i] > nums2[j]:
                resHead = nums2[j]
                j += 1
            elif i < len1 and j < len2 and nums1[i] < nums2[j]:
                resHead = nums1[i]
                i += 1
            else:
                if i < len1:
                    resHead = nums1[i]
                    i += 1
                elif j < len2:
                    resHead = nums2[j]
                    j += 1
            
            step += 1
        if (len1 + len2) % 2:
            return resHead
        else:
            return (resHead + resTail) / 2.0



nums1 = [1,2]
nums2 = [1,2]

s = Solution()
print s.findMedianSortedArrays(nums1, nums2)