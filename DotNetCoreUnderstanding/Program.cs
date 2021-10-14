using System;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreUnderstanding
{
  class Program
  {
    static void Main(string[] args)
    {
      // MultipleTaskWhenAll test = new MultipleTaskWhenAll();
      //var abc= test.TestCollection();
      // abc.Wait();

      // StaticConstructor ab= new StaticConstructor();
      // Console.WriteLine(ab.SetAndGet(12));
      // StaticConstructor ab1 = new StaticConstructor();
      // var xyz=ab1.SetAndGet(55);
      //using var db = new MyWorkDbContext();

      //// Read
      //Console.WriteLine("Querying for a blog");
      //var blog = db.Employee;

      //// Update
      //Console.WriteLine("Updating the blog and adding a post");
      // dynamic d= ab;
      //d.MyMethod();   // this will give error


      DebugMultiThreading ob= new DebugMultiThreading();
      ob.DebugMethod();

    }
  }
}
