package main

import "fmt"

func maxProfit(prices []int) int {
	profit := 0
	minV := prices[0]
	for i := 1; i < len(prices); i++ {
		if prices[i] < minV {
			minV = prices[i]
		} else if prices[i]-minV > profit {
			profit = prices[i] - minV
		}
	}
	return profit
}

func main() {
	fmt.Print(maxProfit([]int{7, 1, 5, 3, 6, 4}))
}
