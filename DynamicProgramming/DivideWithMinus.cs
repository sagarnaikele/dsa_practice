using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace LogicalPrograms
{
  public static class DivideWithMinus
  {
    public static int Divide(int dividend = -2147483648, int divisor = 1)
    {

      Console.WriteLine(3 << 4 << 1);

      if (dividend == int.MinValue && divisor == -1)
      {
        return int.MaxValue;
      }

      int quotient = 0;
      if (dividend == int.MinValue && divisor == 1)
      {
        dividend += 1;
        quotient = 1;
      }

      bool isNegativeSign = (dividend < 0) ^ (divisor < 0);

      dividend = Math.Abs(dividend);
      divisor = Math.Abs(divisor);


      while (dividend > 0)
      {
        dividend -= divisor;
        quotient = dividend >= 0 ? ++quotient : quotient;
      }

      return isNegativeSign ? -quotient : quotient;

    }

    public static int DivideUsingBitWise(int dividend, int divisor)
    {
      //boundry cases
      if (dividend == divisor)
      {
        return 1;
      }
      if (divisor == 1)
      {
        return dividend;
      }
      if (divisor == int.MinValue)
      {
        return 0;
      }
      if (dividend != int.MinValue && divisor == -1)
      {
        return -dividend;
      }
      if (dividend == int.MinValue && divisor == -1)
      {
        return int.MaxValue;
      }

      int quotient = 0;
      bool isNegative = (dividend < 0) ^ (divisor < 0);
      divisor = Math.Abs(divisor);

      if (dividend == int.MinValue)
      {
        dividend += divisor;
        quotient = 1;

      }
      dividend = Math.Abs(dividend);

      while (dividend - divisor >= 0)
      {
        int powerOf2 = 0; // atleast divided by divisor one time
        while ((dividend - (divisor << 1 << powerOf2)) >= 0)
        {
          powerOf2++;
        }
        quotient += 1 << powerOf2;
        dividend -= divisor << powerOf2;
      }
      return isNegative ? -quotient : quotient;
    }
  }
}
