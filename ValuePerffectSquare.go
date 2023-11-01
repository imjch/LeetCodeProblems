package main

func isPerfectSquare(num int) bool {
	start := 1
	end := num
	for start <= end {
		if end - start == 1 {
			return false
		}
		mid := (end + start) / 2
		prod := mid * mid
		if prod == num {
			return true
		} else if prod > num {
			end = mid
		} else {
			start = mid
		}
	}
	return false
}
