using System;
using System.Collections.Generic;
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
            Array.Sort(nums);
            int[] answerList = new int[2];
            int firstIndex = 0;
            int lastIndex = nums.Length-1;
            int sum = nums[firstIndex] + nums[lastIndex];
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
                sum = nums[firstIndex] + nums[lastIndex];
            }

            answerList[0] = firstIndex;
            answerList[1] = lastIndex;
            
            return answerList;
        }
    }
}
