using System;
using System.Linq;

namespace DotNetCoreUnderstanding
{
  public class StaticConstructor
  {
    public static int abc;
    static StaticConstructor()
    {
      abc=50;

    }
    public StaticConstructor()
    {


    }

    public int SetAndGet(int val)
    {
      abc=val;
      return abc;
    }

  }
}
