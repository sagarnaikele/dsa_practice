using System;
using System.Threading;
using System.Threading.Tasks;

namespace DotNetCoreUnderstanding
{
  public class DebugMultiThreading
  {
    public void TestCollection()
    {

      Thread one = new Thread(DebugMethod);
      one.Name="one";
      Thread two = new Thread(DebugMethod);
      one.Name = "two";
      one.Start();
      two.Start();
      Console.ReadLine();
      Console.WriteLine("All Tasks Are done");


    }


    public virtual void DebugMethod()
    {
      for (int i = 0; i < 15; i++)
      {
        i++;
        Thread.Sleep(100);
      }
    }

  }
}
