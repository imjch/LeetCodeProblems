func convertToBase7(num int) string {
	res := []string{}
	abs := false
	if num < 0 {
		abs = true
		num = -num
	}
	for num > 0 {
		res = append([]string{strconv.Itoa(num % 7)}, res...)
		num = num / 7
	}
	if abs {
		return "-" + strings.Join(res, "")
	}
	return strings.Join(res, "")
}