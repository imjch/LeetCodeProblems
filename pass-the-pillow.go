package main

import "fmt"

func passThePillow(n int, time int) int {
	remain := time % (n - 1)
	if (time/(n-1))%2 == 0 {
		return remain + 1
	} else {
		return n - remain
	}
}

func main() {
	fmt.Println(passThePillow(2, 3))
}
