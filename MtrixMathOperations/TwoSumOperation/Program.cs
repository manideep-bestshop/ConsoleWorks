using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSumOperation
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        Console.WriteLine("["+nums[i] + "," + nums[j]+"]"+" Result " + (nums[i] + nums[j]));
                        //  return new int[] { i, j };
                    }
                }
            }
           return new int[0];
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 2, 3 };
            Solution solution = new Solution();
           solution.TwoSum(n, 3);

        }
    }
}
