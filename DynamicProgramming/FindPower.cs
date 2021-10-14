using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicalPrograms
{

  public static class FindPower
  {

    //public static int ByLoop(int num)
    //{
    //  int count=0;
    //  while (num!=0) {num/=10; count++;}
    //  return count;
    //}
    public static int ByRecursion(int numBase,int power)
    {
      if(power == 0) return 1;

      int temp= ByRecursion(numBase, power / 2);

      temp*=temp;
       var output=power%2==0? temp: (temp* numBase);
      return output;
    }

    //public static int ByLog(int num)
    //{
    //  return (int)Math.Floor(Math.Log10(num)+1);
    //}

  }
}
