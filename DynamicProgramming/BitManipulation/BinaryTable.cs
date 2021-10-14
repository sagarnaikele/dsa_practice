using System;


namespace LogicalPrograms.Sorting
{
  public static class BinaryTable
  {

    public static void Print(int tillRange)
    {
      for (int i = 0; i <= tillRange; i++)
      {
        Console.WriteLine($"{i} ------------ {Convert.ToString(i, 2)}");
      }
    }
  }
}