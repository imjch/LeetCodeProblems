/*
Given an array of strings strs, group the
anagrams
 together. You can return the answer in any order.



Example 1:

Input: strs = ["eat","tea","tan","ate","nat","bat"]

Output: [["bat"],["nat","tan"],["ate","eat","tea"]]

Explanation:

There is no string in strs that can be rearranged to form "bat".
The strings "nat" and "tan" are anagrams as they can be rearranged to form each other.
The strings "ate", "eat", and "tea" are anagrams as they can be rearranged to form each other.
Example 2:

Input: strs = [""]

Output: [[""]]

Example 3:

Input: strs = ["a"]

Output: [["a"]]



Constraints:

1 <= strs.length <= 104
0 <= strs[i].length <= 100
strs[i] consists of lowercase English letters.
*/

package main

import (
	"fmt"
	"sort"
)

func groupAnagrams(strs []string) [][]string {
	sortedStrList := []string{}
	for _, s := range strs {
		runes := []rune(s)
		sort.Slice(runes, func(i, j int) bool {
			return runes[i] < runes[j]
		})
		sortedStrList = append(sortedStrList, string(runes))
	}

	m := map[string][]string{}
	for i, s := range strs {
		sstr := sortedStrList[i]
		if _, ok := m[sstr]; !ok {
			m[sstr] = []string{s}
		} else {
			m[sstr] = append(m[sstr], s)
		}
	}
	res := [][]string{}
	for _, v := range m {
		res = append(res, v)
	}
	return res
}

func main() {
	fmt.Print(groupAnagrams([]string{"asd", "dffg", "vwdfqwdf", "dffg", "dffg"}))
}
