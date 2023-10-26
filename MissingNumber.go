func missingNumber(nums []int) int {
	sum2 := 0
	for _, item := range nums {
		sum2 += item
	}
	sum1 := (0 + len(nums)) * (len(nums) + 1) / 2

	return sum1 - sum2
}