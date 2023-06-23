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
            for (int p1 = 0; p1 < nums.Length; p1++)
            {
                int numberToFind = target - nums[p1];
                for (int p2 = p1 + 1; p2 < nums.Length; p2++)
                {
                    if (nums[p2] == numberToFind)
                    {
                        return [p1, p2];
                    }
                }
            }
            return null;
        }

    }
}