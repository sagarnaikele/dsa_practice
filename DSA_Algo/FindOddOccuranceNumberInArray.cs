using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{

  //

  /// <summary>
  ///   //Geeks for geek Bitwise
  //    input  2, 4, 5, 4, 4, 5, 3, 2, 3
  ///   //x ^ 0= x
  /// </summary>
  public static class FindOddOccuranceNumberInArray
  {

    /// <summary>
    /// input  2, 4, 5, 4, 4, 5, 3, 2, 3
    /// </summary>
    /// <param name="arr"> sample input  2, 4, 5, 4, 4, 5, 3, 2, 3</param>
    /// <returns>odd occurance of number in above example 4</returns>
    public static int OddOccurance(int[] arr)
    {
      int XOR = 0;
      //1, 2, 3, 3, 4, 2, 1, 4, 4, 2, 2 
      for (int i = 0; i < arr.Length; i++)
      {
        XOR ^= arr[i];
      }

      return XOR;
    }
  }
}
