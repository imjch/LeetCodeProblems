class Solution(object):
    def solveNQueens(self, n):
        """
        :type n: int
        :rtype: List[List[str]]
        """
        loclist = []
        resMap = []
        self.__nqueens(n, loclist, n, resMap)

        return resMap

    def __nqueens(self, n, loclist, locY, resMap):
        if (locY + n) == n:
            self.print_locs(n, loclist, resMap)
            return

        for locX in range(1, n + 1):
            if self.__is_collision(locX, locY, loclist):
                continue
            loclist.append((locX, locY))
            self.__nqueens(n, loclist, locY - 1, resMap)
            loclist.pop()

    def __is_collision(self, eleX, eleY, locList):
        for (x, y) in locList:
            if (eleY == y
                    or x == eleX
                    or (abs(eleX - x) == abs(eleY - y))):
                return True
        return False

    def print_locs(self, n, locList, resMap):
        locMap = []
        for i in range(0, n):
            locL = ''.join(['.' for _ in range(0, n)])
            locMap.append(locL)
        for loc in locList:
            x, y = loc
            str = locMap[n - y]
            str = list(str)
            str[x - 1] = 'Q'
            str = "".join(str)
            locMap[n - y] = str
        resMap.append(locMap)

solution = Solution()
solution.solveNQueens(5)
