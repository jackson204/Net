using System;
using FluentAssertions;
using Xunit;

namespace LeetCodeDemo
{
    public class Tests
    {
        [Fact]
        public void Test1()
        {
            int[] nums =
            {
                1, 2, 3, 4,
            };
            var runningSum = new Solution().RunningSum(nums);

            runningSum.Should().BeEquivalentTo(new int[]
            {
                1,3,6,10
            });
        }
        [Fact]
        public void Test2()
        {
            int[] nums =
            {
                1,1,1,1,1
            };
            var runningSum = new Solution().RunningSum(nums);

            runningSum.Should().BeEquivalentTo(new int[]
            {
                1,2,3,4,5
            });
        }
        [Fact]
        public void Test3()
        {
            int[] nums =
            {
                3,1,2,10,1
            };
            var runningSum = new Solution().RunningSum(nums);

            runningSum.Should().BeEquivalentTo(new int[]
            {
                3,4,6,16,17
            });
        }
    }

    public class Solution
    {
        public int[] RunningSum(int[] nums)
        {
            // index : 0 不變
            var newIntArray = new int[nums.Length];
            newIntArray[0] = nums[0];
            for(var i = 1; i < nums.Length; i++){
                newIntArray[i] = newIntArray[i-1] + nums[i];
            }
            return newIntArray;
            
        }
    }
}