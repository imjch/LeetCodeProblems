package main

import "fmt"

// DP implementation
// func maxProfit(prices []int) int {
// 	n := len(prices)

// 	res := make([][]int, n, n)
// 	for i := 0; i < n; i++ {
// 		if res[i] == nil {
// 			res[i] = make([]int, n, n)
// 		}
// 		for j := i; j < n; j++ {
// 			if i == j {
// 				if i > 0 {
// 					res[i][j] = res[i-1][j]
// 				} else {
// 					res[i][j] = 0
// 				}
// 			} else if i > j {
// 				res[i][j] = 0
// 			} else {
// 				res[i][j] = res[i][i] + minus(prices[j], prices[i])
// 			}
// 		}
// 	}
// 	return res[n-1][n-1]
// }

// func minus(v1, v2 int) int {
// 	res := v1 - v2
// 	if res >= 0 {
// 		return res
// 	}
// 	return 0
// }

// interation implementation
func maxProfit(prices []int) int {
	profit := 0
	start := prices[0]
	for i := 1; i < len(prices); i++ {
		if prices[i] > start {
			profit += prices[i] - start
		}
		start = prices[i]
	}
	return profit
}

func main() {
	fmt.Print(maxProfit([]int{7, 1, 5, 3, 6, 4}))
}
