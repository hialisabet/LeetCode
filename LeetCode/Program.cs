using System.Collections.Generic;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int[] _0001_TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                    return new int[] { dic[nums[i]], i };
                else
                    dic[target - nums[i]] = i;
            }

            return new int[] { };
        }

        public int _0011_MaxArea(int[] height)
        {
            int left = 0, right = height.Length - 1;
            int result = 0;

            while (left < right)
            {
                var h = Math.Min(height[left], height[right]);
                var w = right - left;
                var area = h * w;
                result = Math.Max(result, area);

                if (height[left] <= height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return result;
        }

    }
}