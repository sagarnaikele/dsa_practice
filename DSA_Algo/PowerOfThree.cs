using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{


  public static class PowerOfThree
  {

    public static void Print3PowerTableTill(uint range)
    {
      for (int i = 0; i < range; i++)
      {
        Console.WriteLine(Math.Pow(3,i));
        if (Math.Pow(3, i)== 1162261467)
        {
          Console.Write( "----------------------");
        } 
      }

    }


  }
}
