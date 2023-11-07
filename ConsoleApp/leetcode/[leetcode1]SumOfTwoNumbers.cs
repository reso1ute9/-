public class SumOfTwoNumbers {
    public static void Run() {
        // 测试样例
        // int[] nums = new[] { 2, 7, 11, 5 };
        // int target = 9;
        
        int[] nums = new[] {3, 3};
        int target = 6;

        int[] res = TwoSum(nums, target);
        Console.WriteLine(string.Join(",", res));
    }
    
    public static int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> table = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            if (table.ContainsKey(nums[i])) {
                table[nums[i]] = i;
            } else {
                table.Add(nums[i], i);
            }
        }
        for (int i = 0; i < nums.Length; i++) {
            if (table.ContainsKey(target - nums[i]) && (table[target - nums[i]] != i)) {
                int[] res = new []{i, table[target - nums[i]]};
                return res;
            }
        }
        return new int[2];
    }
}