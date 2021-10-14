using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LogicalPrograms.Sorting
{
  public static class MergeSort
  {

    public static int[] Merge(int[] left, int[] right, int start, int mid, int end)
    {
      int i= 0,j=0;
      int[] resultArray=new int[left.Length + right.Length];
      int index=0;

      while(i!= left.Length && j!=right.Length)
      {

        if (left[i]>right[j])
        {
          resultArray[index]= right[j];
          j++;
        }
        else
        {
            resultArray[index]=left[i];
          i++;
        }
        index++;
      }

      while (i<left.Length)
      {
        resultArray[index]=left[i];
        i++;
        index++;

      }

      while (j < right.Length)
      {
        resultArray[index] = right[j];
        index++;
        j++;
      }
      return resultArray;
      //for (i = 0; i < resultArray.Length; i++)
      //{
      //  Console.Write(resultArray[i] + ", ");
      //}
      //Console.WriteLine();

    }

    public static int[] Divide(int[] arr, int start, int end)
    {  
      //[12,5,3,8,7,9]   len=6     mid=3     
      if (start>=end)
      {
        return arr;
      }

      int mid= end/2;

      int[] leftArray=new int[mid+1];  //store 3
      int[] rightArray= new int[end-mid]; //store 2
      int i=0;
      for (; i <= mid; i++)
      {
        leftArray[i]=arr[i];
      }

      for (i=0; i < end - mid; i++)
      {
        rightArray[i] = arr[i+ mid+1];
      }
      // var leftArray= arr.[leftStart, leftEnd]
       leftArray=Divide(leftArray, start, leftArray.Length-1);
      rightArray=Divide(rightArray, start, rightArray.Length-1);
      return Merge(leftArray,rightArray, start,mid, end);
    }

  }

  public static class OptimizedMergeSort
  {

    public static void Sort(int[] arr, int start, int end)
    {
      //[12,5,3,8,7,9]   len=6     mid=3     
      if (start < end)
      {
      //to avoid over flow find mid by =start + (End-start)/2   = 0+(5-0)/2= 2, recursion 2  (0,2)  (3,5)   = 3+ (5-3)/2 =3+1=4
      int mid =start+  (end-start) / 2;


// Pass array reference for memory optimization, only send future start and end index for calculation
      Sort(arr, start, mid);
      Sort(arr, mid+1, end);
      Merge(arr, start, mid, end);
      }
    }


    public static void Merge(int[] arr, int start, int mid, int end)
    {
      int leftArraySize= mid - start + 1;
      int rightArraySize= end - mid;
      int[] leftTemp = new int[leftArraySize];
      int[] rightTemp = new int[rightArraySize];

      for (int k = 0; k <= mid - start; k++)
      {
        leftTemp[k]=arr[start+k];
      }

      for (int l = 0; l < end - mid; l++)
      {
        rightTemp[l] = arr[(mid + 1)+l];
      }


      int i = 0, j = 0;
      int index = start;

      while (i != leftArraySize && j !=rightArraySize)
      {

        if (leftTemp[i] > rightTemp[j])
        {
          arr[index] = rightTemp[j];
          j++;
        }
        else
        {
          arr[index] = leftTemp[i];
          i++;
        }
        index++;
      }

      while (i < leftArraySize)
      {
        arr[index] = leftTemp[i];
        i++;
        index++;

      }

      while (j < rightArraySize)
      {
        arr[index] = rightTemp[j];
        index++;
        j++;
      }
    }





    public static bool SearchMatrix(int[][] matrix, int target)
    {

      int rowLength = matrix.Length;
      int i = 0;
      int j = matrix.GetLength(0);
      while (i < rowLength && j >= 0)
      {
        if (matrix[i][j] < target)
        {
          j--;
        }
        else if (matrix[i][j] < target)
        {
          i++;
        }
      }
      return false;

    }
  }
}
