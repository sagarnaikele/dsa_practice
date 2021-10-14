using System;


namespace LogicalPrograms.Sorting
{
  public static class IsNumberPowerOfTwo
  {

    public static bool IsPowerOfTwo(int num)
    { 
      // if number is power of 2 it will have only 1 set bit
      // negative numbers can not be power of 2
      // if i make the only 1 set bit to zero output will be zero hence it will be power of 2 otherwise false;

      return num<=0?false:(num & (num-1))==0;       // 32 &  31 =0
      }
  }
}