using System;
using Project0.StoreApplication.Domain.Abstracts;
using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Repositories;
using Serilog;
using Project0.StoreApplication.Client.Singletons;

namespace Project0.StoreApplication.Client
{
  /// <summary>
  /// Program Class: Defines the program class
  /// </summary>
  class Program
  {

    private static readonly StoreRepository _storeRepository = StoreRepository.Instance;

    private static readonly CustomerSingleton _customerSingleton = CustomerSingleton.Instance;

    private const string _logFilePath = @"/Users/Contemplative/Documents/Revature/simran_code/data/logs.txt";

    private static void Main(string[] args)
    {
      Log.Logger = new LoggerConfiguration().WriteTo.File(_logFilePath).CreateLogger();

      Run();
    }

    private static void Run()
    {
      Log.Information("Method: Run");

      //customers

      if (_customerSingleton.Customers.Count == 0)
      {
        _customerSingleton.Add(new Customer());
      }
      var customer = _customerSingleton.Customers[Capture<Customer>(_customerSingleton.Customers)];

      Console.WriteLine(customer);

      //stores
      // Output<Store>(_storesSingleton.Stores);

      //products
      // Output<Product>(_productSingleton.Products);


      // CaptureOutput();
      // Console.ReadLine();
    }

    // private List<Store> AllTheStores()
    // {
    //   var stores = new List<Store>();

    //   return stores;
    // }

    private static void Output<T>(List<T> data) where T : class
    {
      Log.Information($"method: Output<{typeof(T)}>"); //string interpolation

      var index = 0;

      foreach (var item in data)
      {
        Console.WriteLine($"[{++index}] - {item}");
      }
    }

    private static int Capture<T>(List<T> data) where T : class
    {

      Log.Information("method: Captureinput");

      Output<T>(data);

      Console.WriteLine("Pick an option:");

      int input = int.Parse(Console.ReadLine());

      return input - 1;
    }

  }
}

