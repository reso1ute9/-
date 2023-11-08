public class GameGuoTest2 {
    /*
     * 商场新进了两种商品A/B, 现在有A和B商品的购买记录, 例如A=[1, 2, 2, 3, 4, 5], B=[2, 4, 1, 2, 3], 其中1, 2, 3, 4, 5为用户编号
     * 现在需要求出购买过A/B两种商品的用户
     *
     * 思路: 取顾客编号交集
     */
    private static void Solution(string[] A, string[] B) {
        // 取交集
        string[] sameCustomer = A.Intersect(B).ToArray();
        if (sameCustomer.Length == 0) {
            Console.WriteLine("没有同时购买A/B商品的相同顾客");
        }
        else {
            Console.WriteLine(string.Join(",", sameCustomer));
        }
    }
    
    public static void Run() {
        // 边界情况: 无交集
        // string[] A = new[] { "1"};
        // string[] B = new[] { "2"};
        
        // 题目样例: 
        string[] A = new[] { "1", "2", "2", "3", "4", "5" };
        string[] B = new[] { "2", "4", "1", "2", "3" };
        
        Solution(A, B);
    }
}