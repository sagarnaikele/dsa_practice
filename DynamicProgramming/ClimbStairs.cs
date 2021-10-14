using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicalPrograms
{

  public static class ClimbStairs
  {

    /// <summary>
    /// with Hint decision tree
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public static int FindCombinationByRecursion(int target, Dictionary<int,int> memo=null)
    {
      if (memo==null)
      {
        memo=new Dictionary<int, int>();

      }
      if (target==1|| target == 2|| target == 3)
      {
        return target;
      }
      if (memo.ContainsKey(target))
      {
        return memo[target];
      }

      memo.Add(target, FindCombinationByRecursion(target - 1, memo) + FindCombinationByRecursion(target - 2, memo));
      return memo[target];
    }


    public static int PossibleCombinations(int n)
    {

      int ones = n;  //3
      int two = 0;
      int totalCombinations = 0;

      while (ones >= 0)   //3>0
      {
        if (ones == 0 || two == 0)   //(3 or 0)
        {
          totalCombinations++;  //1
        }

        else //if(((ones+ (two*2))==n) &&!(ones==0 || two==0))  // 2
        {
          totalCombinations += (ones + two);
        }

        ones -= 2;
        two++;


      }
      return totalCombinations;
      //return n % 2 == 0 ? totalCombinations : totalCombinations - 1;
    }
  }
}