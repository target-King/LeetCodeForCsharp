using System;

namespace LeetCodeForCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { -1, -2, -3, -4, -5 };
            DateTime dateNow = DateTime.Now;
            var result = LeetCodeArrayProblem.TwoSum(nums, -8);
            var test_TimeSpan = DateTime.Now - dateNow;
            Console.WriteLine("运行时间：" + test_TimeSpan.TotalMilliseconds);
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
