using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{

  /// <summary>
  /// https://www.hackerrank.com/challenges/jumping-on-the-clouds/problem?h_r=internal-search
  /// 7
  /// 0 0 1 0 0 1 0
  /// out = 4
  /// </summary>
  public static class JumpingOnTheClouds
  {
    public static int JumpingOnClouds(List<int> clouds)
    {
      // check if 2 steps are possible if yes move by 2 steps if no then move by 1 step
      // check for last index

      int jumps=-1;

      for (int i = 0; i < clouds.Count; i++, jumps++)
      {
        if (clouds[i + 2] == 0)
        {
          i++;
        }
        
      }
      return jumps;
    }
  }
}
