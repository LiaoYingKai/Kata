using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class TwoSum
    {
        static void Main(string[] args)
        {
        }

        public static int[] addTwoSum(int[] nums, int target)
        {
            int[] sortNums = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                sortNums[i] = nums[i];
            }
            Array.Sort(sortNums);int[] answerList = new int[2];
            int firstIndex = 0;
            int lastIndex = nums.Length-1;
            int sum = sortNums[firstIndex] + sortNums[lastIndex];
            while (sum != target)
            {
                if (sum > target)
                {
                    lastIndex--;
                }
                else
                {
                    firstIndex++;
                }
                sum = sortNums[firstIndex] + sortNums[lastIndex];
            }

            answerList[0] = Array.IndexOf(nums, sortNums[firstIndex]);
            answerList[1] = Array.IndexOf(nums, sortNums[lastIndex]);
            if (answerList[0] > answerList[1])
            {
                int switchNum;
                switchNum = answerList[0];
                answerList[0] = answerList[1];
                answerList[1] = switchNum;
            }
            
            return answerList;
        }
    }
}
