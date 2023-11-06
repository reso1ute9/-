using System;
using System.Numerics;

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
    if (numListIndex > 10) {
        numListIndex = 1;
    }
    if (visListCount >= 10) {
        break;
    }
}
