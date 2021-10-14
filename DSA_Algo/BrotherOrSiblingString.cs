using System.Collections.Generic;

namespace LogicalPrograms
{

  public static class BrotherOrSiblingString
  {
    public static string IsBrotherOrSiblingString(string str1, string str2)
    {
      if (str1.Length != str2.Length)
      {
        return "No Bother";
      }

      Dictionary<char, int> memo = new Dictionary<char, int>();
      for (int i = 0; i < str1.Length; i++)
      {
        if (memo.ContainsKey(str1[i]))
        {

          memo[str1[i]] = memo[str1[i]] + 1;
        }
        else
        {
          memo.Add(str1[i], 1);
        }
      }

      Dictionary<char, int> memo2 = new Dictionary<char, int>();
      for (int i = 0; i < str2.Length; i++)
      {
        if (memo2.ContainsKey(str2[i]))
        {
          memo2[str2[i]] = memo2[str2[i]] + 1;
        }
        else
        {
          memo2.Add(str2[i], 1);
        }
      }

      for (int i = 0; i < str2.Length; i++)
      {
        if (memo.ContainsKey(str2[i]))
        {
          if (memo[str2[i]] != memo2[str2[i]])
          {
            return "No Brother";
          }

        }
        else
        {
          return "No Brother";
        }

      }
      return "Brother";
    }

    public static string IsBrotherOrSiblingStringBySwapAndSort(string str1, string str2)
    {
      if (str1.Length != str2.Length)
      {
        return "No Bother";
      }

      for (int i = 0; i < str1.Length; i++)
      {
        for (int positition = i; positition < str2.Length; positition++)
        {
          if (str1[i] == str2[positition])
          {
            char temp = str2[i];
            char tem2 = str2[positition];
            str2 = str2.Remove(i, 1);
            str2 = str2.Insert(i, tem2.ToString());
            str2 = str2.Remove(positition, 1);
            str2 = str2.Insert(positition, temp.ToString());
            break;
          }
        }
      }
      return str1 == str2 ? "Bother" : "No Bother";
    }
  }
}