using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
  /// <summary>
  /// https://www.hackerearth.com/problem/algorithm/binary-to-decimal-8/?utm_source=header&utm_medium=search&utm_campaign=he-search
  /// </summary>

  public static class BinaryToDecimal
  {

    public static double ConvertToDecimal(string binaryString)
    {
      double decNum=0;
      int power = 0;
      for (int i = binaryString.Length - 1; i >= 0; i--)
      {
        decNum = binaryString[i].Equals('1') ? (decNum + (1 << power)) : decNum;
        power++;
      }
     return decNum;

    }

    public static double SumOfAllPair(string binaryString)
    {
      double sumOfPair = 0;
      for (int row = 0; row < binaryString.Length; row++)
      {
        string subStr = string.Empty;
        for (int col = row; col < binaryString.Length; col++)
        {

          if (row == col)
          {
            subStr = binaryString[row].ToString();
            
          }
          else
          {
            subStr += binaryString[col];
          }
          sumOfPair += ConvertToDecimal(subStr);
        }

      }
      return sumOfPair;
    }

  }
}
