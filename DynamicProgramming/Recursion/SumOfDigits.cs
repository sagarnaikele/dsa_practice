using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicalPrograms.Recursion
{

  public static class SumOfDigits
  {
    public static int SumByRecursion(int num)
    {
      if(num==0) return 0;

      return (num%10)+ SumByRecursion(num/10);
    }
  }
}
