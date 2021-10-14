using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{

  /// <summary>
  /// sample practice test to check env
  /// </summary>
  public static class FindMatchingChoices
  {
    public static void TakeInputOfChoices()
    {
      string choice1 = Console.ReadLine();
      string choice2 = Console.ReadLine();

      Console.WriteLine($"cycle fo   " + FindChoices(choice1, choice2, choice1.Length));
    }

    public static int FindChoices(string choice1, string choice2, int length)
    {
      int count = 0;

      for (int i = 0; i < length; i++)
      {
        if (choice1[i] == choice2[i]) count++;
      }
      return count;

    }
  }
}
