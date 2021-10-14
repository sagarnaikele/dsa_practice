using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{

  /// <summary>
  /// Find the height of Utopian Tree after n cycle
  /// each year has two cycle winter and summmer
  /// in winter tree height is double
  /// in each summer tree height increases by 1
  /// 
  /// 0    1 2     3 4     5 6     7 8    9 10  ----- Number of cycle n
  ///    { 1st } { 2nd } { 3rd } { 4th } { 5th }  -------years
  /// 1    2 3     6 7    14 15   30 31   62 63  ----- Height of tree at each cycle
  /// 2     4       8       16     32      64     128 256 512
  /// 1     2       3       4       5       6
  /// </summary>
  public static class UtopianTree
  {
    public static int FindHeight(int cycle)
    {
      // find pattern
      // find lenghth for year
      // find length for cycle


      int year= cycle/2;
      //int yearForOddCycle= (cycle+1)/2;
      var evenCycleHeight= (1 << year + 1) - 1;


      //int height= cycle%2 ==0?(1 << year +1)-1:((1 << yearForOddCycle + 1) - 2);
       int height= cycle%2 ==0? evenCycleHeight : evenCycleHeight* 2;

      return height;
    }
  }
}
