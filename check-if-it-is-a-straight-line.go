package main

import (
	"fmt"
)

func checkStraightLine(coordinates [][]int) bool {
	if len(coordinates) == 2 {
		return true
	}
	initY := (coordinates[1][1] - coordinates[0][1])
	initX := (coordinates[1][0] - coordinates[0][0])

	for i := 1; i < len(coordinates)-1; i++ {
		y := (coordinates[i+1][1] - coordinates[i][1])
		x := (coordinates[i+1][0] - coordinates[i][0])
		if initX*y != initY*x {
			return false
		}
	}
	return true
}

func main() {
	fmt.Println(checkStraightLine([][]int{
		{0, 0},
		{0, 1},
		{0, -1},
	}))
}
