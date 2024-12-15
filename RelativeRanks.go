package main

import (
	"sort"
	"strconv"
)

type Info struct {
	Val int
	Idx int
}

func findRelativeRanks(score []int) []string {
	infoL := make([]Info, 0, len(score))
	for i, item := range score {
		infoL = append(infoL, Info{
			Val: item,
			Idx: i,
		})

	}
	sort.Slice(infoL, func(i int, j int) bool {
		return infoL[i].Val > infoL[j].Val
	})
	res := make([]string, len(score))
	for i, item := range infoL {
		if i == 0 {
			res[item.Idx] = "Gold Medal"
		} else if i == 1 {
			res[item.Idx] = "Silver Medal"
		} else if i == 2 {
			res[item.Idx] = "Bronze Medal"
		} else {
			res[item.Idx] = strconv.Itoa(i + 1)
		}
	}
	return res
}
