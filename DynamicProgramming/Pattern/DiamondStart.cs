using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms.Pattern
{
  public static class DiamondStart
  {
    /// <summary>
    ///1| | |*| | |
    ///2| |*|*|*| |
    ///3|*|*|*|*|*|
    ///4| |*|*|*| |
    ///5| | |*| | |
    ///_____________
    ///  1 2 3 4 5
    /// </summary>
    /// <param name="forRange">input range</param>
    public static void Print(int forRange)
    {
      for (int i = 0; i <= forRange; i++)
      {
        int combination = 1;
        for (int j = 0; j <= i; j++)
        {
            Console.Write(combination+"\t");
combination = combination * (i- j)/ (j + 1);
        }
        Console.WriteLine();
      }
    }

    static void Main(string[] args)
    {
      Print(5);
    }
  }
}