using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LogicalPrograms.BitManipulation
{
  public static class AddTwoNumbers
  {

    public static int AddByBitManipulation(int num1, int num2)
    {
      int temp;
      int result = num1 ^ num2;    // xor for addition
      int carry = num1 & num2;  // find carry which will be used in next iteration
      while (carry > 0)
      {
        carry = carry << 1;  // move carry left by 1 to use it at right place
        temp=result;  // store old result to find carry
        result = result ^ carry; // override new result
        carry = temp & carry;  // find carry for next loop
      }
      return result;
    }

  }
}