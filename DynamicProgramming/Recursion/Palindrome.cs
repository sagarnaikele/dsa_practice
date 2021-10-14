using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms.Recursion
{
  public static class Palindrome
  {

    public static bool IsPalindromeRecusrsion(string str, int start, int end)
    {
      if (start > end) return true;

      return (str[start] == str[end] && IsPalindromeRecusrsion(str, start + 1, end - 1));
    }

    public static void IsPalindrome(string str)
    {
      Console.WriteLine(IsPalindromeRecusrsion(str, 0, str.Length-1));
    }
  }
}
