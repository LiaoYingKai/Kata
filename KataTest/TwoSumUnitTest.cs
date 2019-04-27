using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata;

namespace KataTest
{
    [TestClass]
    public class TwoSumUnitTest
    {
        public static void testing(int[] nums, int tergetSum , int[] answerNums)
        {
            int[] actual = TwoSum.addTwoSum(nums, tergetSum);
            CollectionAssert.AreEqual(answerNums, actual);
        }
        [TestMethod]
        public void input_2_7_11_15_target_is_9_shouldReturn_0_1()
        {
            var nums = new int[] { 2, 7, 11, 15 };
            var targetSum = 9;
            var target = new int[] { 0, 1 };
            testing(nums, targetSum, target);
        }

        [TestMethod]
        public void input_2_7_11_15_target_is_18_shouldReturn_1_2()
        {
            var nums = new int[] { 2, 7, 11, 15 };
            var targetSum = 18;
            var target = new int[] { 1, 2 };
            testing(nums, targetSum, target);
        }
        [TestMethod]
        public void input_1_2_7_11_15_18_target_is_19_shouldReturn_0_5()
        {
            var nums = new int[] { 1, 2, 7, 11, 15, 18};
            var targetSum = 19;
            var target = new int[] { 0, 5 };
            testing(nums, targetSum, target);
        }
        
    }
}
