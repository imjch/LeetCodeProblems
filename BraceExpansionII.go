/*
Under the grammar given below, strings can represent a set of lowercase words. Let R(expr) denote the set of words the expression represents.

The grammar can best be understood through simple examples:

Single letters represent a singleton set containing that word.
R("a") = {"a"}
R("w") = {"w"}
When we take a comma-delimited list of two or more expressions, we take the union of possibilities.
R("{a,b,c}") = {"a","b","c"}
R("{{a,b},{b,c}}") = {"a","b","c"} (notice the final set only contains each word at most once)
When we concatenate two expressions, we take the set of possible concatenations between two words where the first word comes from the first expression and the second word comes from the second expression.
R("{a,b}{c,d}") = {"ac","ad","bc","bd"}
R("a{b,c}{d,e}f{g,h}") = {"abdfg", "abdfh", "abefg", "abefh", "acdfg", "acdfh", "acefg", "acefh"}
Formally, the three rules for our grammar:

For every lowercase letter x, we have R(x) = {x}.
For expressions e1, e2, ... , ek with k >= 2, we have R({e1, e2, ...}) = R(e1) ∪ R(e2) ∪ ...
For expressions e1 and e2, we have R(e1 + e2) = {a + b for (a, b) in R(e1) × R(e2)}, where + denotes concatenation, and × denotes the cartesian product.
Given an expression representing a set of words under the given grammar, return the sorted list of words that the expression represents.



Example 1:

Input: expression = "{a,b}{c,{d,e}}"
Output: ["ac","ad","ae","bc","bd","be"]
Example 2:

Input: expression = "{{a,z},a{b,c},{ab,z}}"
Output: ["a","ab","ac","z"]
Explanation: Each distinct word is written only once in the final answer.


Constraints:

1 <= expression.length <= 60
expression[i] consists of '{', '}', ','or lowercase English letters.
The given expression represents a set of words based on the grammar given in the description.
*/

package main

import (
	"fmt"
	"sort"
)

func braceExpansionII(expression string) []string {
	group := [][][]string{{}}
	level := 0
	start := 0
	for i, c := range expression {
		if c == '{' {
			level += 1
			if level == 1 {
				start = i + 1
			}
		} else if c == ',' && level == 0 {
			group = append(group, [][]string{})
		} else if c == '}' {
			level -= 1
			if level == 0 {
				group[len(group)-1] = append(group[len(group)-1], braceExpansionII(expression[start:i]))
			}
		} else if level == 0 {
			group[len(group)-1] = append(group[len(group)-1], []string{string(c)})
		}
	}
	return expand(group)
}

func expand(arr [][][]string) []string {
	res := make([]string, 0)
	for _, item1 := range arr {
		strArr := []string{""}
		for _, item2 := range item1 {
			strArr = expandTwo(strArr, item2)
		}
		res = append(res, strArr...)
	}
	res = removeDuplicateAndSort(res)
	return res
}

func removeDuplicateAndSort(arr []string) []string {
	m := make(map[string]struct{})
	newArr := make([]string, 0, len(arr))
	for _, item := range arr {
		if _, ok := m[item]; !ok {
			m[item] = struct{}{}
			newArr = append(newArr, item)
		}
	}
	sort.Strings(newArr)
	return newArr
}

func expandTwo(arr1 []string, arr2 []string) []string {
	res := make([]string, 0)
	for _, item1 := range arr1 {
		for _, item2 := range arr2 {
			res = append(res, item1+item2)
		}
	}
	return res
}

func main() {
	// res := expand([][][]string{
	// 	{
	// 		{
	// 			"a",
	// 		},
	// 		{
	// 			"a",
	// 			"b",
	// 		},
	// 	},
	// 	{
	// 		{"c"},
	// 		{
	// 			"d",
	// 			"d",
	// 		},
	// 	},
	// })
	fmt.Print(braceExpansionII("{{a,z},a{b,c},{ab,z}}"))
}
