using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicalPrograms
{
  /// <summary>
  /// https://www.hackerearth.com/problem/algorithm/binary-to-decimal-8/?utm_source=header&utm_medium=search&utm_campaign=he-search
  /// </summary>

  public static class TrapWater
  {

    public static int Trap(int[] height)
    {
      //find all previous buildings height 
      //find all next build heights
      // minimum height ammong next and previous is quantity of water with building height
      // delete height of the building from difference
      // sum the final array
      int[] leftHeight = new int[height.Length];
      int[] rightHeight = new int[height.Length];
      int waterQuantity = 0;
      int lastMaxHeight=0;

                            ////0  1  2  3  4  5  6  7  8  9  10 11
      //var input = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };

      for (int i = 1; i < height.Length; i++)
      {
        if (lastMaxHeight > height[i])
        {
          leftHeight[i] = lastMaxHeight;
        }
        else
        {
          lastMaxHeight = height[i];
          leftHeight[i] = lastMaxHeight;
          
        }
      }


       lastMaxHeight=0;
      for (int i = height.Length - 1; i >= 0; i--)
      {

        if (lastMaxHeight > height[i])
        {
          rightHeight[i] = lastMaxHeight;
        }
        else
        {
          lastMaxHeight = height[i];
          rightHeight[i] = lastMaxHeight;
          
        }
      }


      for (int i = 0; i < height.Length; i++)
      {

        waterQuantity += (leftHeight[i] < rightHeight[i] ? leftHeight[i] : rightHeight[i]) - height[i];

      }
      return waterQuantity;
    }
  }
}
