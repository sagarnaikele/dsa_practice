using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicalPrograms
{
  /// <summary>
  /// https://www.hackerearth.com/problem/algorithm/binary-to-decimal-8/?utm_source=header&utm_medium=search&utm_campaign=he-search
  /// </summary>

  public static class Fibonacci
  {

    public static int Fib(int n, Dictionary<int, int> memo=null)
    {
      if (memo==null)
      {
        memo= new Dictionary<int, int>();
      }

      if (n ==0 || n==1 ) 
      {
        return n;
      }
      if (n==2)
      {
        return 1;
      }

      if (memo.ContainsKey(n))
        return memo[n];

      int val = Fib(n - 1, memo) + Fib(n - 2, memo);
      memo.Add(n, val);
      return memo[n];

    }

  }
}
