using System;
using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;
using Serilog;
using Project0.StoreApplication.Client.Singletons;
using Project0.StoreApplication.Storage;

namespace Project0.StoreApplication.Client
{
  /// <summary>
  /// Program Class: Defines the program class
  /// </summary>
  class Program
  {
    private static readonly CustomerSingleton _customerSingleton = CustomerSingleton.Instance;
    private static readonly StoreSingleton _storeSingleton = StoreSingleton.Instance;
    private static readonly ProductSingleton _productSingleton = ProductSingleton.Instance;
    private static OrderSingleton _orderSingleton = OrderSingleton.Instance;

    private const string _logFilePath = @"/Users/Contemplative/Documents/Revature/simran_code/data/logs.txt";

    private static void Main(string[] args)
    {
      Log.Logger = new LoggerConfiguration().WriteTo.File(_logFilePath).CreateLogger();

      Run();
    }

    private static void Run()
    {
      Console.Clear();
      Log.Information("Method: Run");
      Console.WriteLine("\n\n---Welcome to the Apple Store---");
      var currentCustomer = PickCustomer();
      Console.Clear();
      Console.WriteLine($"\n\nHello, {currentCustomer.Name}!\n");
      SelectOptions();
    }

    public static void SelectOptions()
    {
      Console.WriteLine("\nSelect an option:\n");
      Console.WriteLine("1. Go to the store locations\n2. Go to your order history\n3. Exit\n");
      int option = int.Parse(Console.ReadLine());
      if (option == 1)
      {
        var currentStore = PickStore();
        var currentProduct = PickProduct();
        Console.Clear();
        Console.WriteLine("\nYou have selected " + currentProduct + "from " + currentStore + ".\n");
        Console.Write("\nPlease press y to confirm your purchase or any key to go Home: ");
        var input = Console.ReadLine();
        if (input == "y")
        {
          Console.Clear();
          Log.Information("Product Order Confirmed");
          _orderSingleton.AddToOrderRepo(currentStore, currentProduct);
        }
        else
        {
          Console.Clear();
          SelectOptions();
        }
        Console.Clear();
        Console.WriteLine("\nCongratulations! You have purchased the item!\n");
        Console.Write("Press y to go Home or any other key to exit: ");
        string key = Console.ReadLine();
        keyOptions(key);
      }
      else if (option == 2)
      {
        Console.Clear();
        ViewOrders();
        Console.Write("\nDo you want to go back? if yes, press y or any other key to exit: ");
        string key = Console.ReadLine();
        keyOptions(key);
        SelectOptions();
      }
      else if (option == 3)
      {
        Exit();
      }
      else
      {
        Log.Information("Invalid input");
        Console.WriteLine("***You have entered wrong value***\n");
        Console.Clear();
        SelectOptions();
      }
    }

    private static void keyOptions(string key)
    {
      if (key == "y")
      {
        Console.Clear();
        SelectOptions();
      }
      else
      {
        Exit();
      }
    }

    private static void Exit()
    {
      Console.Clear();
      Console.WriteLine("\nThank you and come back soon!\n");
      System.Environment.Exit(0);
    }

    private static void ViewOrders()
    {
      Console.Clear();
      int count = 0;
      foreach (var order in _orderSingleton.getOrderRepository().GetOrders())
      {
        Console.WriteLine("\n{0} - {1}", ++count, order);
      }
    }

    private static void Output<T>(List<T> data) where T : class
    {
      Log.Information($"method: Output<{typeof(T)}>");

      var index = 0;

      foreach (var item in data)
      {
        Console.WriteLine($"\n{++index}. {item}");
      }
    }
    static Customer PickCustomer()
    {
      var customerSing = _customerSingleton.Customers;
      Output(customerSing);
      Console.Write("\nPlease select your customer ID: ");
      int input = int.Parse(Console.ReadLine());
      return customerSing[input - 1];
    }

    static Store PickStore()
    {
      Console.Clear();
      var storeSing = _storeSingleton.Stores;
      Output(storeSing);
      Console.Write("\nPlease select the location number: ");
      int input = int.Parse(Console.ReadLine());
      return storeSing[input - 1];
    }

    static Product PickProduct()
    {
      Console.Clear();
      var def = new DemoEF();
      int index = 0;
      foreach (var item in def.GetProducts())
      {
        Console.WriteLine("\n" + ++index + ". " + item.Name + ", Price: $" + item.Price);
      }

      Console.Write("\nPlease select a product number to purchase: ");
      int input = int.Parse(Console.ReadLine());
      var product = def.GetProducts()[input - 1];
      return product;
    }
  }
}

