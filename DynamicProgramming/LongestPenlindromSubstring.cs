using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicalPrograms
{
  /// <summary>
  /// https://leetcode.com/problems/longest-palindromic-substring/
  /// </summary>

  public static class LongestPenlindromSubstring
  {
      public static string LongestPalindrome(string s)
      {

        string output = string.Empty;
        bool isPelin;

        if (s.Length == 0)
        {
          return output;
        }
        if ((s.Length == 1) || (s.Length == 2 && s[0] == s[1]))
        {
          return s;
        }

        output += s[0];

        bool[,] pelinMat = new bool[s.Length, s.Length];


        for (int gap = 0; gap < s.Length; gap++)
        {
          for (int digStart = 0, col = gap; col < s.Length; digStart++, col++)
          {
            if (gap == 0)
            {
              pelinMat[digStart, col] = true;
            }

            else if (gap == 1)
            {
              isPelin = s[digStart] == s[col];
              pelinMat[digStart, col] = isPelin;
              output = isPelin ? s.Substring(digStart, gap + 1) : output;
            }
            else
            {
              isPelin = (s[digStart] == s[col]) && pelinMat[digStart + 1, col - 1];
              pelinMat[digStart, col] = isPelin;
              output = isPelin ? s.Substring(digStart, gap + 1) : output;
            }
          }
        }
        return output;
      }
    }
  }
