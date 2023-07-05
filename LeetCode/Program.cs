using System.Collections.Generic;
using System.Text.RegularExpressions;

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

        public int _0003_LengthOfLongestSubstring(string s)
        {
            if (s.Length <= 1) return s.Length;

            var seen = new Dictionary<char, int>();
            int left = 0, longest = 0;

            for (int right = 0; right < s.Length; right++)
            {
                char currentChar = s[right];
                int previouslySeenChar;
                if (seen.TryGetValue(currentChar, out previouslySeenChar) && previouslySeenChar >= left)
                {
                    left = previouslySeenChar + 1;
                }

                seen[currentChar] = right;

                longest = Math.Max(longest, right - left + 1);
            }

            return longest;
        }

        public bool _0020_IsValid(string s)
        {
            if (s.Length == 0) return true;

            Dictionary<char, char> parens = new Dictionary<char, char>
            {
                {'(', ')'},
                {'{', '}'},
                {'[', ']'}
            };

            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (parens.ContainsKey(s[i]))
                {
                    stack.Push(s[i]);
                }
                else
                {
                    if (stack.Count == 0) return false;

                    char leftBracket = stack.Pop();
                    char correctBracket = parens[leftBracket];

                    if (s[i] != correctBracket) return false;
                }
            }

            return stack.Count == 0;
        }

        public bool _0125_IsPalindrome(string s)
        {
            s = Regex.Replace(s, "[^A-Za-z0-9]", "").ToLower();

            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                if (s[left] != s[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }

        public bool _0680_ValidPalindrome(string s)
        {
            int start = 0;
            int end = s.Length - 1;

            while (start < end)
            {
                if (s[start] != s[end])
                {
                    return ValidSubPalindrome(s, start + 1, end) || ValidSubPalindrome(s, start, end - 1);
                }

                start++;
                end--;
            }

            return true;
        }

        public bool ValidSubPalindrome(string s, int start, int end)
        {
            while (start < end)
            {
                if (s[start] != s[end])
                {
                    return false;
                }

                start++;
                end--;
            }

            return true;
        }

    }
}