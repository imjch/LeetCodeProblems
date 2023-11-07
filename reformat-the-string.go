package main

import "fmt"

func reformat(s string) string {
	chList := []rune{}
	numList := []rune{}

	for _, item := range s {
		if item >= '0' && item <= '9' {
			numList = append(numList, item)
		} else {
			chList = append(chList, item)
		}
	}
	res := []rune{}

	for i := 0; len(chList) > 0 && len(numList) > 0; i++ {
		res = append(res, chList[0], numList[0])
		chList = chList[1:]
		numList = numList[1:]
	}
	if len(chList) > 1 || len(numList) > 1 {
		return ""
	}
	if len(chList) > 0 {
		res = append(res, chList[0])
	}
	if len(numList) > 0 {
		res = append([]rune{numList[0]}, res...)
	}
	return string(res)
}

func main() {
	fmt.Println(reformat("uzmlfxspduzb2621199741214"))
	// fmt.Println(reformat("ab123"))
	// fmt.Println(reformat("123"))
	// fmt.Println(reformat("asd"))
	// fmt.Println(reformat("abc012"))
}
