using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public class Array
    {
        public static bool containsDuplicate(int[] nums)
        {
            if (nums == null || nums.Length == 0) return false;

            for (int i=0;i<nums.Length;i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j]) 
                    { 
                        return true; 
                    }
                    
                }
            }
            return false;  
        }
    }
}
