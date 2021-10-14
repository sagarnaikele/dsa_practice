using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
  // 3rd largest number from array
  //Brother or sibling string


  public static class Factset_Find3rdLargestNum
  {

    public static int Find3rdLargestNum(int[] arr)
    {
      if (arr.Length<3)
      {
        return -1;
      }

      int first= arr[0];
      int second=int.MinValue;
      int third= int.MinValue;
      int temp1=0;
      int temp2=0;

      for (int i = 1; i < arr.Length; i++)
      {
        if (first<arr[i])
        {
          temp1= first;
          first=arr[i];

          temp2=second;
          second= temp1;

          third=temp2;

        }
        else if(second< arr[i])
        {
          temp2 = second;
          second = arr[i];
          third = temp2;
        }



      }

      return 0;
    }


  }
}
