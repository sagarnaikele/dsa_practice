using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
  public static class RepeatedStringHRSolution
  {
    //abc length 10
    //[abcabcabca]bc  ans- 4 for a

    public static long RepeatedString(string str, long tillLength)
    {
      //length of original string
      //length of a in original string
      // find quocent for exact repeatation
      // find occurance of letter in remaining string

      var len= str.Length;
      var quotient= tillLength / len;
      var substrLen = tillLength% len;
      long partialStrLen= substrLen == 0?0: substrLen;

      long numberOfOccurance= (quotient * CountOfLetter(str, len)) + CountOfLetter(str, partialStrLen);
     // var numberOfOccurance = (3 * CountOfLetter("abc", 3)) + CountOfLetter(abc, 1);
     return numberOfOccurance;

    }

    private static long CountOfLetter(string str, long tillLength)
    {
      long count=0;
      for (int i = 0; i < tillLength; i++)
      {
        if (str[i].Equals('a'))
        {
          count++;
        }
      }
       return count;
    }
  }
}
