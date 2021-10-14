using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms.Recursion
{//https://practice.geeksforgeeks.org/tracks/DSASP-Recursion/?batchId=154
  public static class PrintDecreasing
  {
    public static void Print(int number)
    {
      if (number<1) return;
      Console.Write(number + " ");
      Print(number-1);
    }
  }
}