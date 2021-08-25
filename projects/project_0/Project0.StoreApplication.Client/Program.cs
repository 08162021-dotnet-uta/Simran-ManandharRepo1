using System;
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Repositories;

namespace Project0.StoreApplication.Client
{
  /// <summary>
  /// Program Class: Defines the program class
  /// </summary>
  class Program
  {
    static void Main(string[] args)
    {
      var program = new Program();

      program.CaptureOutput();
    }

    private List<Store> AllTheStores()
    {
      var stores = new List<string>();

      return stores;
    }

    private void OutputStores()
    {
      foreach (var store in AllTheStores())
      {
        Console.WriteLine(store);
      }
    }

    private int CaptureInput()
    {
      OutputStores();

      Console.WriteLine("Pick a Store:");

      int input = int.Parse(Console.ReadLine());

      return input;
    }

    private void CaptureOutput()
    {
      Console.WriteLine("You have selected: " + AllTheStores()[CaptureInput()]);
    }
  }
}


