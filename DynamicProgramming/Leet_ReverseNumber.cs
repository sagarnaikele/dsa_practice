
namespace LogicalPrograms
{
  /// <summary>
  /// https://leetcode.com/problems/reverse-integer/submissions/
  /// </summary>
  public static class Leet_ReverseNumber
  {
    public static int Reverse(int num)
    {
      int lastMaxDigit = int.MaxValue % 10; 
      int lastMinDigit = int.MinValue % 10;
      int remainingMaxPart = int.MaxValue / 10;
      int remainingMinPart = int.MinValue / 10;
      int rev = 0;

      while (num != 0)
      {
        //return if exceeding 32 bit (+/-)
        if (rev < remainingMinPart || (rev == remainingMinPart && num <= lastMinDigit))
        {
          return 0;
        }
        else if (rev > remainingMaxPart || (rev == remainingMaxPart && num >= lastMaxDigit))
        {
          return 0;
        }

        int reminder = num % 10;
        rev = (rev * 10) + reminder;
        num /= 10;
      }
      return rev;
    }
  }
}