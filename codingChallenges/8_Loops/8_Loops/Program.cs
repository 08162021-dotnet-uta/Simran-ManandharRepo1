﻿using System;
using System.Collections.Generic;

namespace _8_LoopsChallenge
{
  public class Program
  {
    public static void Main(string[] args)
    {
      /* Your code here */

    }

    /// <summary>
    /// Return the number of elements in the List<int> that are odd.
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    public static int UseFor(List<int> x)
    {
      // throw new NotImplementedException("UseFor() is not implemented yet.");
      int count = 0;
      foreach (int c in x)
      {
        if (c % 2 == 1)
        {
          count++;
        }
      }
      return count;
    }

    /// <summary>
    /// This method counts the even entries from the provided List<object> 
    /// and returns the total number found.
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    public static int UseForEach(List<object> x)
    {
      // throw new NotImplementedException("UseForEach() is not implemented yet.");
      int count = 0;
      // check each object to see it it's an int.
      foreach (object y in x)
      {
        if (y is double || y is float || y is sbyte || y is byte || y is short ||
        y is ushort || y is long)
        {
          if ((long)y % 2 == 0) count++;
        }
        else if (y is int)
        {
          if ((int)y % 2 == 0) count++;
        }
        else if (y is uint)
        {
          if ((uint)y % 2 == 0) count++;
        }
        else if (y is ulong)
        {
          if ((ulong)y % 2 == 0) count++;
        }
      }
      return count;

    }

    /// <summary>
    /// This method counts the multiples of 4 from the provided List<int>. 
    /// Exit the loop when the integer 1234 is found.
    /// Return the total number of multiples of 4.
    /// </summary>
    /// <param name="x"></param>
    public static int UseWhile(List<int> x)
    {
      // throw new NotImplementedException("UseFor() is not implemented yet.");
      int iterator = 0;
      int totMults = 0;

      while (x[iterator] != 1234)
      {
        if (x[iterator] % 4 == 0)
        {
          totMults++;
        }
        iterator++;
      }
      return totMults;
    }

    /// <summary>
    /// This method will evaluate the Int Array provided and return how many of its 
    /// values are multiples of 3 and 4.
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    public static int UseForThreeFour(int[] x)
    {
      // throw new NotImplementedException("UseForThreeFour() is not implemented yet.");
      int total = 0;
      for (int i = 0; i < x.Length; i++)
      {
        if (i % 3 == 0 && i % 4 == 0)
        {
          total++;
        }
      }
      return total;
    }

    /// <summary>
    /// This method takes an array of List<string>'s. 
    /// It concatenates all the strings, with a space between each, in the Lists and returns the resulting string.
    /// </summary>
    /// <param name="stringListArray"></param>
    /// <returns></returns>
    public static string LoopdyLoop(List<string>[] stringListArray)
    {
      // throw new NotImplementedException("LoopdyLoop() is not implemented yet.");
      string str = "";
      for (int i = 0; i < stringListArray.Length; i++)
      {
        foreach (string x in stringListArray[i])
        {
          str += (x + " ");
        }
      }
      return str;
    }
  }
}