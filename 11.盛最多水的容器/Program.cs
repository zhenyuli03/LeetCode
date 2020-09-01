using System;

namespace _11.盛最多水的容器
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 6, 2, 5, 4, 8, 3, 7 };
            Console.WriteLine("Hello World!");
            //Console.WriteLine(Solution.MaxArea(array));
            Console.WriteLine($"输入的数组位{array},最多的容量{Solution.MaxArea(array)}");
        }
    }
    public static class Solution
    {
        public static int MaxArea(int[] height)
        {
            if (height.Length == 0 || height.Length == 1)
                return 0;
            int LeftIndex = 0;//左边界
            int RightIndex = height.Length - 1; //右边界
            int ResultData = 0;
            int ResultDataChche = 0;
            for (int i=0; i<height.Length; i++)
            {
                ResultDataChche = Math.Min(height[LeftIndex], height[RightIndex]) * Math.Abs(RightIndex - LeftIndex);
                if(ResultDataChche > ResultData)
                    ResultData = ResultDataChche;
                if (RightIndex == LeftIndex)
                    break;
                if (Math.Min(height[LeftIndex], height[RightIndex]) == height[LeftIndex])
                    LeftIndex++;
                else if (Math.Min(height[LeftIndex], height[RightIndex]) == height[RightIndex])
                    RightIndex--;
            }
            return ResultData;
        }
    }
}
