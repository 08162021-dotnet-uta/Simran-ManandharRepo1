﻿using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace _11_ArraysAndListsChallenge
{
  public class Program
  {
    public static void Main(string[] args)
    {

    }//EoM

    /// <summary>
    /// This method takes an array of integers and returns a double, the average 
    /// value of all the integers in the array
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    public static double AverageOfValues(int[] array)
    {
      // throw new NotImplementedException("AverageOfValues has not been implemented yet.");
      double leng = array.Length;
      double total = array.Sum();

      return (total / leng);
    }

    /// <summary>
    /// This method increases each array element by 2 and 
    /// returns an array with the altered values.
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    public static int[] SunIsShining(int[] x)
    {
      // throw new NotImplementedException("SunIsShining has not been implemented yet.");
      for (int i = 0; i < x.Length; i++)
      {
        x[i] += 2;
      }
      return x;
    }

    /// <summary>
    /// This method takes an ArrayList containing types of double, int, and string 
    /// and returns the average of the ints and doubles only, as a decimal.
    /// It ignores the string values and rounds the result to 3 decimal places toward the nearest even number.
    /// /// </summary>
    /// <param name="myArrayList"></param>
    /// <returns></returns>
    public static decimal ArrayListAvg(ArrayList myArrayList)
    {
      double total = 0;
      int len = myArrayList.Count;
      // throw new NotImplementedException("ArrayListAvg has not been implemented yet.");
      for (int i = 0; i < myArrayList.Count; i++)
      {
        if (myArrayList[i] is string)
        {
          len--;
          continue;
        }
        else
        {
          if (myArrayList[i] is int)
            total = total + (int)myArrayList[i];
          else
            total = total + (double)myArrayList[i];
        }
      }
      decimal avg = (decimal)(total / len);
      avg = Decimal.Round(avg, 3);
      return avg;

    }

    /// <summary>
    /// This method returns the rank (starting with 1st place) of a new 
    /// score entered into a list of randomly ordered scores.
    /// </summary>
    /// <param name="myArray1"></param>
    public static int ListAscendingOrder(List<int> scores, int yourScore)
    {
      // throw new NotImplementedException("ListAscendingOrder has not been implemented yet.");
      int place = 1;
      foreach (int item in scores)
      {
        if (item < yourScore)
        {
          place++;
        }

      }
      return place;

    }

    /// <summary>
    /// This method has with two parameters takes a List<string> and a string.
    /// The method returns true if the string parameter is found in the List, otherwise false.
    /// </summary>
    /// <param name="myArray2"></param>
    /// <param name="word"></param>
    /// <returns></returns>
    public static bool FindStringInList(List<string> myArray2, string word)
    {
      // throw new NotImplementedException("FindStringInList has not been implemented yet.");
      if (myArray2.Contains(word))
      {
        return true;
      }
      else
      {
        return false;
      }

      //return (myArray2.Contains(word))
    }
  }//EoP
}// EoN