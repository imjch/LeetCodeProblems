/*
1130. Minimum Cost Tree From Leaf Values

Given an array arr of positive integers, consider all binary trees such that:

Each node has either 0 or 2 children;
The values of arr correspond to the values of each leaf in an 【in-order】 traversal of the tree.
The value of each 【non-leaf node】 is equal to the 【product】 of the 【largest leaf value】 in its left and right subtree, respectively.
Among all possible binary trees considered, return the smallest possible sum of the values of each non-leaf node. It is guaranteed this sum fits into a 32-bit integer.

A node is a leaf if and only if it has zero children.



Example 1:


Input: arr = [6,2,4]
Output: 32
Explanation: There are two possible trees shown.
The first has a non-leaf node sum 36, and the second has non-leaf node sum 32.
Example 2:


Input: arr = [4,11]
Output: 44


Constraints:

2 <= arr.length <= 40
1 <= arr[i] <= 15
It is guaranteed that the answer fits into a 32-bit signed integer (i.e., it is less than 231).
*/

package main

import (
	"fmt"
	"math"
)

func main() {
	fmt.Print(mctFromLeafValues([]int{1, 11, 8, 8, 13, 2, 6, 1, 7, 6, 8, 10, 14, 9, 13, 15, 11, 2, 13, 15}))
	//fmt.Print(mctFromLeafValues([]int{4, 5, 6, 7}))
}

func mctFromLeafValues(arr []int) int {
	m := map[int]map[int][]int{}
	_, prod := _mctFromLeafValues(arr, 0, len(arr), m)
	return prod
}

func _mctFromLeafValues(arr []int, curI, curJ int, memo map[int]map[int][]int) (int, int) {
	if curJ-curI == 1 {
		return arr[curI], 0
	}
	if curJ-curI == 2 {
		return int(math.Max(float64(arr[curI]), float64(arr[curJ-1]))), arr[curI] * arr[curJ-1]
	}

	prod := math.MaxInt
	maxV := 0
	for i := curI + 1; i < curJ; i++ {
		maxVL, prodL := 0, 0
		if _, ok := memo[curI][i]; ok {
			maxVL = memo[curI][i][0]
			prodL = memo[curI][i][1]
		} else {
			maxVL, prodL = _mctFromLeafValues(arr, curI, i, memo)
		}

		maxVR, prodR := 0, 0
		if _, ok := memo[i][curJ]; ok {
			maxVR = memo[i][curJ][0]
			prodR = memo[i][curJ][1]
		} else {
			maxVR, prodR = _mctFromLeafValues(arr, i, curJ, memo)
		}

		prodTmp := (maxVL * maxVR) + (prodL + prodR)
		if prodTmp < prod {
			prod = prodTmp
			maxV = int(math.Max(math.Max(float64(maxVL), float64(maxVR)), float64(maxV)))
			if _, ok := memo[curI]; !ok {
				memo[curI] = map[int][]int{
					curJ: {
						maxV, prod,
					},
				}
			} else {
				memo[curI][curJ] = []int{maxV, prod}
			}
		}
	}
	return maxV, prod
}
