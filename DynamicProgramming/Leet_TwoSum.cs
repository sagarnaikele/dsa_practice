using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicalPrograms
{

  public static class Leet_TwoSum
  {

    public static int[] TwoSum(int[] nums, int target)
    {
      int value = -1;
      int[] output = new int[]{-1,-1 };
      Dictionary<int, int> prevDict = new Dictionary<int, int>();
      for (int i = 0; i <= nums.Length - 1; i++)
      {
        value = target - nums[i];

        if (prevDict.ContainsValue(value))
        {
          return new int[] { i, prevDict.FirstOrDefault(x => x.Value == value).Key };
        }
        else
        {
          prevDict.Add(i, nums[i]);
        }
      }
        return output;
    }
  }
}
