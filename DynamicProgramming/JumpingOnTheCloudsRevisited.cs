using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{

  /// <summary>
  /// https://www.hackerrank.com/challenges/jumping-on-the-clouds-revisited/problem
  /// 7
  /// 0 0 1 0 0 1 0
  /// out = 4
  /// </summary>
  public static class JumpingOnTheCloudsRevisited
  {
    public static int JumpingOnClouds(int[] clouds, int stepSize)
    {
      // check if 2 steps are possible if yes move by 2 steps if no then move by 1 step
      // check for last index
      //output= 80
      int energy = 100;
      int i = 0;

      while (true)
      {
        if (clouds[i] == 1)
          energy -= stepSize;
        energy--;
        i = (i + stepSize) % clouds.Length;
        if (i % clouds.Length == 0) break;
      }


      return energy;

    }
  }
}
