using System;
using System.IO;
using System.Collections.Generic;
using LogicalPrograms.Recursion;
using LogicalPrograms.Sorting;
using LogicalPrograms.BitManipulation;

namespace LogicalPrograms
{
  class Program
  {
    static void Main(string[] args)
    {
      GenerateSubsetOfString.PrintSubset("abc");

      //Console.Write(abc);//aghcdedcaabal
      var abc = LongestPenlindromSubstring.LongestPalindrome("aghcdedcaabal");
     //var abc=BrotherOrSiblingString.IsBrotherOrSiblingStringBySwapAndSort("Sagar","raSag");
      Console.Write(abc);
      //      -2147483648
      //2
      TowerOfHanoi.MoveDisk(2,"A","B","C");
      //var arr=new int[3][];
      //arr[0] = new int[4] { 1, 3, 5, 7};
      //arr[1] = new int[4] { 10, 11, 16, 20 };
      //arr[2] = new int[4] {23, 30, 34, 60};
      //OptimizedMergeSort.SearchMatrix(arr, 3);
    }



    public static void BreakString(string str)
    {
      int countChar = 0;
      string print = "";
      for (int i = 0; i < str.Length; i++)
      {
        if (str[i] != '"' && str[i] == ' ')
        {
          print += str[i];
        }
        if (str[i] == '"')
        {
          countChar++;
        }
        if ((str[i] == ' ') && (countChar == 0 || countChar == 2))
        {
          Console.WriteLine(print);
          print = "";
          countChar = 0;
        }
      }
    }
  }






  //public static string ConvertToSnakeCase(string strIn)
  //  {
 
  //    string snakeCase = string.Empty;
  //    for (int i = 0; i < strIn.Length; i++)
  //    {
  //      var abc= strIn[i];
  //      int ascII = (int)strIn[i];
  //      if (!((97 <= ascII && ascII <= 122) || (65 <= ascII && ascII <= 90)))
  //      {
  //        continue;
  //      }
  //      if (i>0 && 65 <= ascII && ascII <= 90)
  //      {
  //        strIn= strIn.Insert(i,"_");
  //        i++;
  //        snakeCase= strIn;
  //      }

  //    }
  //    return snakeCase.ToLower();
  //  }

  }
