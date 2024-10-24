/*
Given an integer array nums and an integer k, return the kth largest element in the array.

Note that it is the kth largest element in the sorted order, not the kth distinct element.

Can you solve it without sorting?

Example 1:

Input: nums = [3,2,1,5,6,4], k = 2
Output: 5
Example 2:

Input: nums = [3,2,3,1,2,4,5,5,6], k = 4
Output: 4
*/
type heap struct {
	nums []int
}

// heapify 将数组转换为小顶堆，并返回新的堆对象。
// 参数：nums ([]int) - 需要转换成大顶堆的数组。
// 返回值：heap (heap) - 转换后的大顶堆对象。
func heapify(nums []int) heap {
	h := heap{nums: nums}
	// 从最后一个非叶子节点开始调整堆
	for i := len(nums)/2 - 1; i >= 0; i-- {
		h.adjustHeapDown(i)
	}
	return h
}

// adjustHeapDown 从给定的索引开始向下调整堆
func (h *heap) adjustHeapDown(index int) {
	if index < 0 || len(h.nums) == 0 {
		return
	}
	// 当前节点的值
	curr := h.nums[index]
	// 当前节点的索引
	currIndex := index

	size := len(h.nums)
	for currIndex < size/2 { // 只要当前节点不是叶子节点
		// 左子节点的索引
		leftChildIndex := 2*currIndex + 1
		var smallerChildIndex int
		// 确定较小的子节点
		if leftChildIndex+1 < size && h.nums[leftChildIndex] > h.nums[leftChildIndex+1] {
			smallerChildIndex = leftChildIndex + 1
		} else {
			smallerChildIndex = leftChildIndex
		}

		// 如果当前节点已经小于或等于它的两个子节点，则堆的性质已经满足
		if curr <= h.nums[smallerChildIndex] {
			break
		}

		// 否则，交换当前节点和较小的子节点
		h.nums[currIndex], h.nums[smallerChildIndex] = h.nums[smallerChildIndex], curr
		// 移动到交换后的子节点位置
		currIndex = smallerChildIndex
	}
}

// pop 从堆中移除并返回堆顶元素
// 此操作会移除堆顶元素，并重新调整堆结构以保持堆属性
func (h *heap) pop() int {
	// 交换堆顶和最后一个元素
	h.nums[0], h.nums[len(h.nums)-1] = h.nums[len(h.nums)-1], h.nums[0]
	// 删除并返回堆顶元素
	val := h.nums[len(h.nums)-1]
	h.nums = h.nums[:len(h.nums)-1]
	// 从根节点开始重新调整堆
	h.adjustHeapDown(0)
	return val
}

// findKthLargest 函数名: findKthLargest
// 参数:
//
//	nums []int - 整形数组，需要找到第k大的元素
//	k int - 整形，表示第几大的元素，从1开始计算
//
// 返回值:
//
//	int - 整形，返回第k大的元素值
func findKthLargest(nums []int, k int) int {
	if len(nums) == 0 {
		return 0
	}
	heap := heapify(nums)
	v := -1
	size := len(nums)
	for i := 0; i < size-k+1; i++ {
		v = heap.pop()
	}
	return v
}
