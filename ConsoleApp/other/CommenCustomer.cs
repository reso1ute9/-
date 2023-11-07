public class CommenCustomer {
    /*
     * 题目描述: 
     * 商场新进了两种商品A/B, 现在有A和B商品的购买记录, 例如A=[1, 2, 2, 3, 4, 5], B=[2, 4, 1, 2, 3], 其中1, 2, 3, 4, 5为用户编号
     * 现在需要求出购买过A/B两种商品的用户
     * 
     * 解题思路: 模拟喊号过程
     */
    public static void Run() {
        string[] A = new[] { "1", "2", "2", "3", "4", "5" };
        string[] B = new[] { "2", "4", "1", "2", "3" };
        // 取交集
        var sameCustomer = A.Intersect(B).ToArray();
        foreach (var val in sameCustomer) {
            Console.WriteLine("customer id:" +　val);
        }
    }
}