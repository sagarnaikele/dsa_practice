using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{


  public static class FindOddOccuranceofTwoNumberInArray
  {

    /// <summary>
    /// input  2, 4, 5, 4, 1, 5, 3, 2, 3, 7
    /// </summary>
    /// <param name="arr"> sample input  2, 4, 5, 4, 1, 5, 3, 2, 3,7</param>
    /// <returns>odd occurance of number in above example 1,7</returns>
    public static string OddOccurance(int[] arr)
    {
      int XOR = 0;

      int res1 = 0;
      int res2 = 0;

      for (int i = 0; i < arr.Length; i++)
      {
        XOR ^= arr[i];
      }
      int getLastSetBit= XOR & ~(XOR-1);

      for (int i = 0; i < arr.Length; i++)
      {
        if ((arr[i] & getLastSetBit)!=0)
        {
          Console.WriteLine($"Group 1 Last Bit 0  {arr[i]}");
          res1^=arr[i];
        }
        else
        {
          Console.WriteLine($"Group 2 Last Bit 1  {arr[i]}");
          res2 ^= arr[i];
        }
      }

      return res1 +" "+ res2;
    }
  }
}
