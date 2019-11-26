using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace LeetCodeForCsharp
{
    /// <summary>
    /// 问题来源网址：https://leetcode-cn.com/explore/interview/card/top-interview-questions-easy/
    /// 作者：king
    /// 时间：2019-11-20
    /// </summary>
    public class LeetCodeArrayProblem
    {
        #region 从排序数组中删除重复项------力扣测试结果280ms-----已完成

        /**********************说明**************************
         * -------------------------------------------------------
         * 题目：
         * 给定一个排序数组，你需要在原地删除重复出现的元素，
         * 使得每个元素只出现一次，返回移除后数组的新长度。
         * 不要使用额外的数组空间，你必须在原地修改输入数组并
         * 在使用 O(1) 额外空间的条件下完成。
         * --------------------------------------------------------
         * 
         * --------------------------------------------------------
         * 说明：
         * 为什么返回数值是整数，但输出的答案是数组呢? 请注意，
         * 输入数组是以“引用”方式传递的，这意味着在函数里修改
         * 输入数组对于调用者是可见的
         * --------------------------------------------------------
         * 
         * ---------------------------------------------------------
         * url：
         * https://leetcode-cn.com/explore/interview/card/top-interview-questions-easy/1/array/21/
         * ---------------------------------------------------------
         * 
         *****************************************************/

        /// <summary>
        /// 数组对应下标
        /// </summary>
        private static int Duplicates_Index = 0;

        /// <summary>
        /// 从排序数组中删除重复项
        /// </summary>
        /// <param name="nums">给定数组 [1,1,2]</param>
        /// <returns>数组的新长度</returns>
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[j] != nums[Duplicates_Index])
                {
                    Duplicates_Index++;
                    nums[Duplicates_Index] = nums[j];
                }
            }
            Duplicates_Index++;
            return Duplicates_Index;
        }

        /// <summary>
        /// 从排序数组中删除重复项 
        /// </summary>
        /// <param name="nums">给定数组 [1,1,2]</param>
        /// <returns>数组的新长度</returns>
        public static int RemoveDuplicates2(int[] nums)
        {
            int result = 0;
            if (nums.Length <= 1)
                return nums.Length;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[result])
                {
                    result++;
                    nums[++result] = nums[i];
                }
            }
            result++;
            return ++result;
        }

        /**************注意点************************
         * 
         * 1、在.net core  中 数组几乎没有操作空间
         * 
         * 2、使用数组时，根据下标修改值
         * 
         ********************************************/

        #endregion

        #region 买卖股票的最佳时机 II

        /**********************说明**************************
         * -------------------------------------------------------
         * 题目：
         * 给定一个数组，它的第 i 个元素是一支给定股票第 i 天的价格。
         * 设计一个算法来计算你所能获取的最大利润。你可以尽可能地完
         * 成更多的交易（多次买卖一支股票）。
         * 
         * 注意：你不能同时参与多笔交易（你必须在再次购买前出售掉之前的股票）
         * --------------------------------------------------------
         * 
         * --------------------------------------------------------
         * 
         * 输入: [7,1,5,3,6,4]
         * 输出: 7
         * 解释: 在第 2 天（股票价格 = 1）的时候买入，在第 3 天
         * （股票价格 = 5）的时候卖出, 这笔交易所能获得利润 = 5-1 = 4 。
         * 随后，在第 4 天（股票价格 = 3）的时候买入，在第 5 天
         * （股票价格 = 6）的时候卖出, 这笔交易所能获得利润 = 6-3 = 3 。
         * 
         * --------------------------------------------------------
         * 
         * ---------------------------------------------------------
         * url：
         * https://leetcode-cn.com/explore/interview/card/top-interview-questions-easy/1/array/22/
         * ---------------------------------------------------------
         * 
         *****************************************************/

        /// <summary>
        /// 买卖股票的最佳时机
        /// </summary>
        /// <param name="prices">给定的股票数组</param>
        /// <returns>最大利润</returns>
        public int MaxProfit(int[] prices)
        {
            var result = 0;
            if (prices.Length <= 1)
                return result;
            for (int i = 1; i < prices.Length; i++)
            {

            }


            return result;
        }

        /**************注意点************************
         * 
         * 1、
         * 
         ********************************************/

        #endregion

        #region 旋转数组----------力扣测试结果平均284ms------已完成

        /**********************说明**************************
         * -------------------------------------------------------
         * 题目：
         * 给定一个数组，将数组中的元素向右移动 k 个位置，其中 k 是非负数。
         * 
         * --------------------------------------------------------
         * 
         * --------------------------------------------------------
         * 
         * 输入: [1,2,3,4,5,6,7] 和 k = 3
         * 输出: [5,6,7,1,2,3,4]
         * 解释:
         * 向右旋转 1 步: [7,1,2,3,4,5,6]
         * 向右旋转 2 步: [6,7,1,2,3,4,5]
         * 向右旋转 3 步: [5,6,7,1,2,3,4]
         * 
         * --------------------------------------------------------
         * 
         * ---------------------------------------------------------
         * url：
         * https://leetcode-cn.com/explore/interview/card/top-interview-questions-easy/1/array/23/
         * ---------------------------------------------------------
         * 
         *****************************************************/

        /// <summary>
        /// 旋转数组
        /// </summary>
        /// <param name="nums">数组</param>
        /// <param name="k">移动位置数量</param>
        public static void Rotate(int[] nums, int k)
        {
            var numsList = nums.ToList();
            numsList.InsertRange(0, new int[k]);
            for (int i = k - 1; i >= 0; i--)
            {
                numsList[i] = numsList[i + nums.Length];
                numsList.RemoveAt(numsList.Count - 1);
            }
            for (int i = 0; i < numsList.Count; i++)
            {
                nums[i] = numsList[i];
            }
        }

        /// <summary>
        /// 旋转数组 (暴力破解) 力扣审核未通过（时间上不通过）
        /// </summary>
        /// <param name="nums">数组</param>
        /// <param name="k">移动位置数量</param>
        public static void Rotate2(int[] nums, int k)
        {
            int numsSelectValue = 0, numsSelectIndex = 0, numsLength = nums.Length;
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < numsLength; j++)
                {
                    if (j + 1 >= numsLength)
                        numsSelectIndex = numsLength - j - 1;
                    numsSelectValue = nums[j];
                    nums[j] = nums[numsSelectIndex];
                    nums[numsSelectIndex] = numsSelectValue;
                }
            }
        }

        /// <summary>
        /// 旋转数组 使用额外的数组
        /// </summary>
        /// <param name="nums">数组</param>
        /// <param name="k">移动位置数量</param>
        public static void Rotate3(int[] nums, int k)
        {
            if (nums.Length <= 1)
                return;
            int numsLength = nums.Length, numsSelectIndex = 0;
            int[] numsResult = new int[numsLength];
            for (int i = 0; i < numsLength; i++)
            {
                numsSelectIndex = i + k;
                if (numsSelectIndex >= numsLength)
                    numsSelectIndex = numsSelectIndex - numsLength;
                numsResult[i] = nums[numsSelectIndex];
            }
            for (int i = 0; i < numsLength; i++)
            {
                nums[i] = numsResult[i];
            }

        }

        #endregion

        #region 存在重复--------力扣测试结果132ms------已完成

        /**********************说明**************************
         * -------------------------------------------------------
         * 题目：
         * 给定一个整数数组，判断是否存在重复元素。
         * 如果任何值在数组中出现至少两次，函数返回 true。
         * 如果数组中每个元素都不相同，则返回 false。
         * 
         * --------------------------------------------------------
         * 
         * --------------------------------------------------------
         * 
         * 输入: [1,2,3,1]
         * 输出: true
         * 
         * --------------------------------------------------------
         * 
         * ---------------------------------------------------------
         * url：
         * https://leetcode-cn.com/explore/interview/card/top-interview-questions-easy/1/array/24/
         * ---------------------------------------------------------
         * 
         *****************************************************/

        /// <summary>
        /// 存在重复
        /// </summary>
        /// <param name="nums">需要判断的数组</param>
        /// <returns></returns>
        public static bool ContainsDuplicate(int[] nums)
        {
            nums = nums.OrderBy(e => e).ToArray();
            var numsLength = nums.Length;
            for (int i = 0; i < numsLength - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                    return true;
            }
            return false;
        }

        /// <summary>
        /// 存在重复
        /// </summary>
        /// <param name="nums">需要判断的数组</param>
        /// <returns></returns>
        public static bool ContainsDuplicate2(int[] nums)
        {
            HashSet<int> map = new HashSet<int>();
            for (var i = 0; i < nums.Length; i++)
            {
                if (map.TryGetValue(nums[i], out int target))
                {
                    return true;
                }
                else
                {
                    map.Add(nums[i]);
                }
            }
            return false;
        }

        #endregion

        #region 只出现一次的数字--------力扣测试结果124ms-----已完成

        /**********************说明**************************
         * -------------------------------------------------------
         * 题目：给定一个非空整数数组，除了某个元素只出现一次以外，
         * 其余每个元素均出现两次。找出那个只出现了一次的元素。
         * 
         * 说明：你的算法应该具有线性时间复杂度。 
         * 你可以不使用额外空间来实现吗？
         * 
         * --------------------------------------------------------
         * 
         * --------------------------------------------------------
         * 
         * 输入: [2,2,1]
         * 输出: 1
         * 
         * --------------------------------------------------------
         * 
         * ---------------------------------------------------------
         * url：
         * https://leetcode-cn.com/explore/interview/card/top-interview-questions-easy/1/array/25/
         * ---------------------------------------------------------
         * 
         *****************************************************/


        /// <summary>
        /// 只出现一次的数字
        /// </summary>
        /// <param name="nums">数组</param>
        /// <returns></returns>
        public static int SingleNumber(int[] nums)
        {
            int numsLength = nums.Length, temp = 0;
            bool isSingleNumber = false;
            for (int i = 0; i < numsLength; i++)
            {
                isSingleNumber = true;
                for (int j = i + 1; j < numsLength; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        temp = nums[i + 1];
                        nums[i + 1] = nums[j];
                        nums[j] = temp;
                        isSingleNumber = false;
                        i += 1;
                        break;
                    }
                }
                if (isSingleNumber)
                {
                    temp = nums[i];
                    break;
                }
            }
            return temp;
        }

        /// <summary>
        /// 只出现一次的数字
        /// </summary>
        /// <param name="nums">数组</param>
        /// <returns></returns>
        public static int SingleNumber2(int[] nums)
        {

            int num = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                num ^= nums[i];
            }
            return num;
        }

        #endregion

        #region  加一 ----------力扣测试结果270ms------已完成

        /**********************说明**************************
         * -------------------------------------------------------
         * 题目：给定一个由整数组成的非空数组所表示的非负整数，
         * 在该数的基础上加一。最高位数字存放在数组的首位， 
         * 数组中每个元素只存储单个数字。你可以假设除了整数 0 
         * 之外，这个整数不会以零开头。
         * 
         * --------------------------------------------------------
         * 
         * --------------------------------------------------------
         * 输入: [1,2,3]
         * 输出: [1,2,4]
         * 解释: 输入数组表示数字 123。
         * 
         * --------------------------------------------------------
         * 
         * ---------------------------------------------------------
         * url：
         * https://leetcode-cn.com/explore/interview/card/top-interview-questions-easy/1/array/27/
         * ---------------------------------------------------------
         * 
         *****************************************************/

        public static int[] PlusOne(int[] digits)
        {
            var digitsStartIndex = digits.Length - 1;
            if (digits[digitsStartIndex] < 9)
            {
                digits[digitsStartIndex] = digits[digitsStartIndex] + 1;
                return digits;
            }
            var digitsList = digits.ToList();
            bool isPlus = true;
            for (int i = digitsStartIndex; i >= 0; i--)
            {
                if (digitsList[i] + 1 == 10)
                    digitsList[i] = 0;
                else
                {
                    digitsList[i] = digitsList[i] + 1;
                    isPlus = false;
                    break;
                }
            }
            if (isPlus)
                digitsList.Insert(0, 1);
            return digitsList.ToArray();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public static int[] PlusOne2(int[] digits)
        {
            int len = digits.Length;
            for (int i = len - 1; i >= 0; i--)
            {
                digits[i]++;
                digits[i] %= 10;
                if (digits[i] != 0)
                    return digits;
            }
            digits = new int[len + 1];
            digits[0] = 1;
            return digits;
        }

        #endregion

        #region 移动零----------力扣测试结果300ms -----已完成

        /*
         * 
         * 给定一个数组 nums，编写一个函数将
         * 所有 0 移动到数组的末尾，同时保持
         * 非零元素的相对顺序。
         * 
         */

        /// <summary>
        /// 给定一个数组 nums，编写一个函数将所有 0 移动到数组的末尾，
        /// 同时保持非零元素的相对顺序
        /// </summary>
        /// <param name="nums"></param>
        public void MoveZeroes(int[] nums)
        {
            if (nums.Length == 1)
                return;
            int zeroLength = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                    zeroLength++;
                else if (zeroLength > 0)
                {
                    nums[i - zeroLength] = nums[i];
                    nums[i] = 0;
                }
            }
        }

        #endregion

        #region 两数之和 已完成

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i], i);
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                var anoNum = target - nums[i];
                if (dic.ContainsKey(anoNum))
                {
                    if (dic[anoNum] != i) return new int[] { i, dic[anoNum] };
                }
            }
            return new int[2];
        }

        #endregion

        #region 有效的数独

        public static bool IsValidSudoku(char[][] board)
        {
            List<char> resultList = new List<char>();
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {

                }
            }
            return true;
        }

        #endregion
    }
}
