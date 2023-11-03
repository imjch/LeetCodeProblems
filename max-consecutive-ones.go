package main

func findMaxConsecutiveOnes(nums []int) int {
	maxCnt := 0
	curCnt := 0

	for _, item := range nums {
		if item == 1 {
			curCnt++
		} else {
			if curCnt > maxCnt {
				maxCnt = curCnt
			}
			curCnt = 0
		}
	}
	if curCnt > maxCnt {
		maxCnt = curCnt
	}
	return maxCnt
}
