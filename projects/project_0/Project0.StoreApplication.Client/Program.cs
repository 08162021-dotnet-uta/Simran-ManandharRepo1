using System;
using Project0.StoreApplication.Domain.Abstracts;
using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Repositories;
using Serilog;

namespace Project0.StoreApplication.Client
{
  /// <summary>
  /// Program Class: Defines the program class
  /// </summary>
  class Program
  {

    private StoreRepository _storeRepository = new StoreRepository();
    static void Main(string[] args)
    {
      Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
      var program = new Program();

      program.CaptureOutput();
    }

    private List<Store> AllTheStores()
    {
      var stores = new List<Store>();

      return stores;
    }

    private void OutputStores()
    {
      Log.Information("in output stores");

      foreach (var store in _storeRepository.Stores)
      {
        Console.WriteLine(store);
      }
    }

    private int CaptureInput()
    {

      Log.Information("in input");
      OutputStores();

      Console.WriteLine("Pick a Store:");

      int input = int.Parse(Console.ReadLine());

      return input-1;
    }

    private void CaptureOutput()
    {
      Console.WriteLine("You have selected: " + _storeRepository.Stores[CaptureInput()]);
    }
  }
}

