package main

func isPrefixString(s string, words []string) bool {
	newW := ""
	for _, item := range words {
		newW += item
		if newW == s {
			return true
		}
	}
return false
}
