/*
Given an n x n grid containing only values 0 and 1, where 0 represents water and 1 represents land, find a water cell such that its distance to the nearest land cell is maximized, and return the distance. If no land or water exists in the grid, return -1.

The distance used in this problem is the Manhattan distance: the distance between two cells (x0, y0) and (x1, y1) is |x0 - x1| + |y0 - y1|.

Example 1:

Input: grid = [[1,0,1],[0,0,0],[1,0,1]]
Output: 2
Explanation: The cell (1, 1) is as far as possible from all the land with distance 2.
Example 2:

Input: grid = [[1,0,0],[0,0,0],[0,0,0]]
Output: 4
Explanation: The cell (2, 2) is as far as possible from all the land with distance 4.

Constraints:

n == grid.length
n == grid[i].length
1 <= n <= 100
grid[i][j] is 0 or 1
*/
package main

import (
	"fmt"
	"math"
)

func distance(x0, y0, x1, y1 int) int {
	return int(math.Abs(float64(x0-x1)) + math.Abs(float64(y0-y1)))
}

// BFE解决方案，该方案依赖的核心细节：每一个1开始，都往外扩散一层，那么离1最近的0一定会在某一轮被最近的1染色，不会存在距离不对的情况
func maxDistance(grid [][]int) int {
	landQ := make([][]int, 0)
	for i := 0; i < len(grid); i++ {
		for j := 0; j < len(grid[i]); j++ {
			if grid[i][j] == 1 {
				landQ = append(landQ, []int{i - 1, j})
				landQ = append(landQ, []int{i + 1, j})
				landQ = append(landQ, []int{i, j + 1})
				landQ = append(landQ, []int{i, j - 1})
			}
		}
	}

	steps := 0
	for len(landQ) > 0 {
		steps++
		landLen := len(landQ)
		for i := 0; i < landLen; i++ {
			landI := landQ[0][0]
			landJ := landQ[0][1]
			landQ = landQ[1:]

			if landI >= 0 && landI < len(grid) && landJ >= 0 && landJ < len(grid[0]) && grid[landI][landJ] == 0 {
				grid[landI][landJ] = steps
				landQ = append(landQ, []int{landI - 1, landJ}, []int{landI + 1, landJ}, []int{landI, landJ + 1}, []int{landI, landJ - 1})
			}
		}
	}
	if steps == 0 || steps == 1 {
		return -1
	}
	return steps - 1
}

func main() {
	d := maxDistance([][]int{
		{0, 0, 0},
		{0, 0, 0},
		{0, 0, 0},
	})
	fmt.Printf("distance:%d", d)
}
