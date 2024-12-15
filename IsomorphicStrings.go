func isIsomorphic(s string, t string) bool {
    if len(s) != len(t) {
        return false
    }
    m1 := map[rune]rune{}
    m2 := map[rune]rune{}
    for i := 0; i < len(s); i++ {
        ca := rune(s[i])
        cb := rune(t[i])
        if t, ok := m1[ca]; ok {
            if t != cb {
                return false
            }
        } else if _, ok := m2[cb]; ok{
            return false
        } else {
            m1[ca] = cb
            m2[cb] = ca
        }
    }
    return true
}