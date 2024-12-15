package main

func thirdMax(nums []int) int {
	max1, max2, max3 := -2147483649, -2147483649, -2147483649
	for _, item := range nums {
		if item == max1 || item == max2 || item == max3 {
			continue
		}
		if max1 < item {
			max3 = max2
			max2 = max1
			max1 = item
		} else if max2 < item {
			max3 = max2
			max2 = item
		} else if max3 < item {
			max3 = item
		}
	}
	if max3 == -2147483649 {
		return max1
	}
	return max3
}
