using System;


namespace LogicalPrograms.Sorting
{
  public static class DivideTwoNumbersWithoutDivision
  {

    public static int DivideUsingBit(int dividend, int divisor)
    { 
      int quotient=0;
      bool isNegative= dividend<0 ^ dividend <0;

      //boundry cases to avoid overflow and extra manupulation

      if (divisor == dividend)
      {
        return 1;
      }
      if (divisor == 1)
      {
        return dividend;
      }
      else if (divisor == int.MinValue)
      {
        return quotient;
      }
      if (dividend == int.MinValue)
      {
        if (divisor == -1)
        {
          return int.MaxValue;
        }
      }

      divisor = Math.Abs(divisor);
      if (dividend == int.MinValue)
      {
        dividend+=divisor;
        quotient++;
      }
      dividend= Math.Abs(dividend);


      while(dividend- divisor >= 0)
      {
        int powerOf2=0;


        //<<1 represents can divisor divide more than 1 and if yes till what level of multiple of divisor
        // ex divident =15, divisor =3
        //powerOf2=0 represent at lest once
        // 15-(3*2*1)>0, 15-(3*2*(2))>0, 15-(
        while (dividend-(divisor<<1<<powerOf2)>0) 
        {
          powerOf2++;
        }
        dividend -= divisor << powerOf2;
        quotient += 1 << powerOf2;   // 1 represents that at least divident is divided by divisor 1 time
      }

      return isNegative? -quotient:quotient;

    }

  }
}
