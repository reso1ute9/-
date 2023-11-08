using System;
using System.Numerics;

public static class GameGuoTest1 {
    /*
     * 100个小朋友围城一圈, 设定编号1~100，依次按照1,2,3,4,5,6,7,8,9的顺序循环报数,
     * 报到9的出圈, 直至所有小朋友出圈, 编写代码打印出各个小朋友的出圈顺序
     * 思路: 似乎无法用数学方法解决, 没观察到特定顺序, 只能模拟叫号过程
     */
    private static void Solution(int childrenNum, int cyclicNum) {
        // 标记数字是否已经被叫出, 如果访问过则设置为-1
        List<int> numList = new List<int>(childrenNum + 5);
        int numListIndex = 1;   // 数字数组下标, 如果遇到被标记即之前被喊出则跳过标记下标
        int visListCount = 0;   // 当前总共有多少人被叫出
        int callNumber = 1;     // 模拟当前被叫号码

        for (int i = 0; i <= childrenNum + 1; i++) {
            numList.Add(i);
        }

        while (true) {
            // 仅当前没有被标记才查看是否是9的倍数 
            if (numList[numListIndex] != -1) {
                if (callNumber % cyclicNum == 0) {
                    Console.WriteLine("callNumber:" + numListIndex);
                    numList[numListIndex] = -1;
                    visListCount += 1;
                    // 重新叫号
                    callNumber = 0;
                }
                callNumber += 1;
            }
            numListIndex += 1;
            // 注意重置下标, 即喊到100后需要从1开始再喊
            if (numListIndex > childrenNum) {
                numListIndex = 1;
            }
            // 全部标记则代表所有小朋友喊完
            if (visListCount >= childrenNum) {
                break;
            }
        }
    }

    public static void Run() {
        // 小样例:
        // Solution(3, 9);
        // Solution(10, 9);
        // Solution(20, 9);
        
        // 样本样例:
        Solution(100, 9);
    }
}