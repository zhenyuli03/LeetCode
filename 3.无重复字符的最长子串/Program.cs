using System;
using System.Collections.Generic;
using System.IO;

namespace _3.无重复字符的最长子串
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            int Count = 0;
            int StartPiont; //开始标
            int EndPiont;  //截止标
            string ResultString = "";
            Dictionary<int, char> keyValuePairs = new Dictionary<int, char>();
            for(int i=0; i<s.Length; i++)
            {
                if(!ResultString.Equals(s[i]))
                {
                    //ResultString=
                }
            }
            return Count;
        }
    }
    public class Program
    {
        public static Solution solution = new Solution();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(solution.LengthOfLongestSubstring("pwwkew").ToString());
        }
    }
}
