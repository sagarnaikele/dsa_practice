using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicalPrograms
{

  public static class FindDigitCount
  {

    public static int ByLoop(int num)
    {
      int count=0;
      while (num!=0) {num/=10; count++;}
      return count;
    }
    public static int ByRecursion(int num)
    {
      if(num==0) return 0;
      return 1+ ByRecursion(num/10);
    }

    public static int ByLog(int num)
    {
      return (int)Math.Floor(Math.Log10(num)+1);
    }

  }
}
