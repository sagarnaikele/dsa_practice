using System;
using System.Threading;
using System.Threading.Tasks;

namespace DotNetCoreUnderstanding
{
  public class ChildMultipleTaskWhenAll: MultipleTaskWhenAll
  {
    public async Task TestCollection()
    {

      var a = Task.Run(() => {int mydelay = 15000;   Thread.Sleep(mydelay); Console.WriteLine("a is done"); });
      var b = Task.Run(() => { int mydelay = 8000; Thread.Sleep(mydelay); Console.WriteLine("b is done"); });
      var c = Task.Run(() => { int mydelay = 6000; Thread.Sleep(mydelay); Console.WriteLine("c is done"); });

      await a;
      Console.WriteLine("a await is done");
      await b;
      Console.WriteLine("b await is done");
      await c;
      Console.WriteLine("c await is done");

      Task ack= Task.WhenAll(new Task[]{a,b,c });
      ack.Wait();

      Console.WriteLine("All Tasks Are done");


    }
    //complete defination should match in case of override return parameter,
    //and input parameter with method name

    public override int Sum(int a, int b)
    {
      return base.Sum(a, b);
    }
  }
}
