public class TheNextBiggerElement {
    /*
    * 解题思路: 求下一个排列
    */
    
    // 直接搜出来下一个排列
    public static long dfs(string nNumString, int nNumStringIndex, long currentNum, int target, List<char> numSortedList, List<bool> numVisitedList) {
        if (nNumStringIndex == nNumString.Length) {
            return currentNum > target ? currentNum : -1;
        }
        for (int i = 0; i < numSortedList.Count; i++) {
            char num = numSortedList[i];
            if (num < nNumString[nNumStringIndex] || numVisitedList[i] == true) {
                continue;
            } else if (num == nNumString[nNumStringIndex]) {
                numVisitedList[i] = true;
                long res = dfs(nNumString, nNumStringIndex + 1, currentNum * 10 + (num - '0'), target, numSortedList, numVisitedList);
                numVisitedList[i] = false;
                if (res != -1) {
                    return res;
                }
            } else {
                long resNum = currentNum * 10 + (num - '0');
                numVisitedList[i] = true;
                for (int j = 0; j < numSortedList.Count; j++) {
                    if (numVisitedList[j] == true) {
                        continue;
                    }
                    resNum = resNum * 10 + (uint)(numSortedList[j] - '0');
                }
                return resNum;
            }
        }
        return -1;
    }
    
    public static int NextGreaterElement(int n) {
        // 初始化辅助数组
        List<char> numSortedList = new List<char>();        // 记录当前所有出现过的数字
        List<bool> numVisitedList = new List<bool>();       // 标记数组
        string nString = n.ToString();
        for (int i = 0; i < nString.Length; i++) {
            numSortedList.Add(nString[i]);
            numVisitedList.Add(false);
        }
        numSortedList.Sort();
        // 搜索结果
        long res = dfs(n.ToString(), 0, 0, n, numSortedList, numVisitedList);
        // 判断32位整数有没有超出范围
        res = (res > ((long)MathF.Pow(2, 31) - 1)) ? -1 : res;
        return (int)res;
    }

    public static void Run() {
        NextGreaterElement(230241);
        // NextGreaterElement(12222333);
    }
}