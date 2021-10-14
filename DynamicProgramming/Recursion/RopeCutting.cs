using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicalPrograms.Recursion
{

  public static class RopeCutting
  {


    public static int MaximumCuts(int rope, int a, int b, int c)
    {
      if(rope==0) return 0;
      if (rope<0) return -1;

      int cutCount_a=  MaximumCuts(rope-a,a,b,c);
      int cutCount_b = MaximumCuts(rope - b, a, b, c);
      int cutCount_c = MaximumCuts(rope - c, a, b, c);

      var maxCutCount= Math.Max(cutCount_a, Math.Max(cutCount_b, cutCount_c));
      var maxct=cutCount_a >cutCount_b?(cutCount_a>cutCount_c)? cutCount_a:cutCount_c:cutCount_b>cutCount_c?cutCount_b:cutCount_c;
      if (maxCutCount==-1)
      {
        return maxCutCount;

      }

      return maxCutCount+1;
    }


  }
}
