using System;
using System.Numerics;

public static class WhosNumberNine {
    /*
     * 题目描述: 100个小朋友围城一圈, 设定编号1~100，依次按照1,2,3,4,5,6,7,8,9的顺序循环报数, 报到9的出圈, 直至所有小朋友出圈
     * 编写代码打印出各个小朋友的出圈顺序
     * 
     * 解题思路: 模拟喊号过程
     */
    public static void Run() {
        // 当前所有数字列表, 如果访问过则设置为-1
        List<int> numList = new List<int>(105);
        int numListIndex = 1;
        int visListCount = 0;
        int callNumber = 1;

        for (int i = 0; i <= 101; i++) {
            numList.Add(i);
        }

        while (true) {
            // 仅当前没有被标记才查看是否是9的倍数 
            if (numList[numListIndex] != -1) {
                if (callNumber % 9 == 0) {
                    Console.WriteLine("currentNum:" + numListIndex);
                    numList[numListIndex] = -1;
                    visListCount += 1;
                    callNumber = 0;
                }
                callNumber += 1;
            }
            numListIndex += 1;
            if (numListIndex > 100) {
                numListIndex = 1;
            }
            if (visListCount >= 100) {
                break;
            }
        }
    }
}