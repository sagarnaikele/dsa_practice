using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{


  public static class DecimalToBinary
  {
    /// <summary>
    /// 64   32   16   8 4 2 1
    /// 0000           1 1 1 1  ---15
    /// 0000           1 0 1 1  --- 11
    /// decimal base 10       --->/2 to binary
    /// binary base 2        -----> multiply by 2 power
    /// 11/2
    ///  quotient     5   2    0     5               1 1 0 1
    ///  reminder     1    1   0     (1)
    /// </summary>
    /// <param name="number">input number </param>
    public static void ConvertToBinary(int number)
    {
      var numbertodisplay = number;
      string binaryEq = "";
      while (number > 1)
      {
        int reminder = number % 2;
        binaryEq = reminder + binaryEq;
        number >>= 1;
      }
      binaryEq = number + binaryEq;
      Console.WriteLine($"number {numbertodisplay} ------ Binary {binaryEq}");
    }

    public static void ConvertToBinaryByRecursion(int number)
    {
      if (number==0) return;
      ConvertToBinaryByRecursion(number/2);
      Console.Write(number%2);

    }

  }
}
