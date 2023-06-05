using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSumProblem
{
    public class Solution
    {
            public int[] TwoSum(int[] nums, int target)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int x = i+1; x < nums.Length; x++)
                    {
                    if ((nums[i] + nums[x]) == target)
                        {
                        int[] output = { i, x };
                        return output;
                        }
                        
                    }
                }
                return new int[0];
            }   
    }
}
