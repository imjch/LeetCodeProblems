package main

import (
	"fmt"
	"sort"
)

func coinChange(coins []int, amount int) int {
	w := make([][]int, len(coins)+1, len(coins)+1)

	for i := range coins {
		w[i+1] = make([]int, amount+1, amount+1)
	}
	sort.Slice(coins, func(x, y int) bool { return coins[x] < coins[y] })
	max := 9999999999
	for i := 1; i < len(coins)+1; i++ {
		for j := 1; j < amount+1; j++ {
			if i == 1 {
				if j%coins[i-1] == 0 {
					w[i][j] = j / coins[i-1]
				} else {
					w[i][j] = max
				}
			} else {
				curCoinNum := 0
				tmpAmount := j
				minCoinNum := max
				for tmpAmount >= 0 {
					tmpCoinNum := w[i-1][tmpAmount] + curCoinNum
					if tmpCoinNum < minCoinNum {
						minCoinNum = tmpCoinNum
					}
					curCoinNum++
					tmpAmount -= coins[i-1]
					w[i][j] = minCoinNum
				}
			}
		}
	}
	min := max
	for idx := range coins {
		if w[idx+1][amount] < min {
			min = w[idx+1][amount]
		}
	}
	if min == max {
		return -1
	}
	return min
}

func main() {
	fmt.Println(coinChange([]int{1, 2, 5}, 11))
	fmt.Println(coinChange([]int{2}, 3))
	fmt.Println(coinChange([]int{186, 419, 83, 408}, 6249))
	fmt.Println(coinChange([]int{1}, 0))
}
