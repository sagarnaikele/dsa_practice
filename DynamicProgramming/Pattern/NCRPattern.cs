using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms.Pattern
{
  public static class NCRPattern
  {
    /// <summary>
    /// 1
    /// 1 1
    /// 1 2 1
    /// 1 3 3 1
    /// 1 4 6 4 1
    /// 1 5 10 10 5 1
    /// </summary>
    /// <param name="forRange">input range</param>
    public static void PrintNCRPattern(int forRange)
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
      PrintNCRPattern(5);
    }
  }
}