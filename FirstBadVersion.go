package main

/**
 * Forward declaration of isBadVersion API.
 * @param   version   your guess about first bad version
 * @return 	 	      true if current version is bad
 *			          false if current version is good
 * func isBadVersion(version int) bool;
 */

func firstBadVersion(n int) int {
	fst := 0
	end := n
	for fst < end {
		mid := (end + fst) / 2
		if isBadVersion(mid) {
			// 如果是bad v，则表示左边可能存在，向左找
			end = mid
		} else {
			// 如果不是，则表示在右边
			fst = mid + 1
		}
	}
	if isBadVersion(fst) {
		return fst
	}
	return 0
}
