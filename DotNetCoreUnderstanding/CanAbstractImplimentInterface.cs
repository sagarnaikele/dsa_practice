using System;
using System.Linq;

namespace DotNetCoreUnderstanding
{
  public abstract class CanAbstractImplimentInterface : IFruit
  {
    public abstract string GetColor();

  }


  public interface IFruit
{
  string GetColor();
}

  public class Apple : CanAbstractImplimentInterface
  {
    public override string GetColor()
    {
      return "Red";
    }
  }
  public class Orange : CanAbstractImplimentInterface
  {
    public override string GetColor()
    {
      return "Orange";
    }
  }
}