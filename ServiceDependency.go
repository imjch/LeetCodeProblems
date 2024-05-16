package main

import (
	"fmt"
	"strings"
)

func findDependency(data [][]string) {
	m := map[string][]string{}
	// 1、构造依赖字典
	for _, item := range data {
		s := item[0]
		d := item[1]
		if _, ok := m[s]; !ok {
			m[s] = []string{d}
		} else {
			m[s] = append(m[s], d)
		}
	}

	// 2、循环处理每个服务
	for s, d := range m {
		res := []string{s}
		// 从s触发，处理每一个依赖，且记录访问过的历史服务
		if len(d) <= 0 {
			continue
		}
		_find(m, d, res)
		res = res[:len(res)-1]
	}
}

func hasVisited(d []string, data string) string {
	for _, v := range d {
		if v == data {
			return v
		}
	}
	return ""
}

func _find(m map[string][]string, d []string, history []string) {
	for _, item := range d {
		t := hasVisited(history, item)
		if t != "" {
			// 打印history + item + hasVisited的返回值
			fmt.Println(strings.Join(history, " ") + " " + item)
			continue
		}
		history = append(history, item)
		// 从s触发，处理每一个依赖，且记录访问过的历史服务
		_find(m, m[item], history)
		history = history[:len(history)-1]
	}
}

func main() {
	data := [][]string{
		{"A", "B"},
		{"B", "C"},
		{"C", "D"},
		{"D", "A"},
		{"D", "E"},
	}
	findDependency(data)
}
