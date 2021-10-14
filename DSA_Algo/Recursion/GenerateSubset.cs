using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicalPrograms.Recursion
{
  /// <summary>
  /// When input is "ABC"
  /// Output should be printed as "",A,B,C,AC,AB,BC,ABC
  /// </summary>
  public static class GenerateSubsetOfString
  {
    public static void PrintSubset(string originalStr, string currentSubSet="", int currentIndex=0)
    {
      if(originalStr.Length== currentIndex)
      {
        Console.WriteLine(currentSubSet);
        return;
      }

      PrintSubset(originalStr, currentSubSet,currentIndex+1);
      PrintSubset(originalStr, currentSubSet+originalStr[currentIndex], currentIndex+1);
    }
  }
}
