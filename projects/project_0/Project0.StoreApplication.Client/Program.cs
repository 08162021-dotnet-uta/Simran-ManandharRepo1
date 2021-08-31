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
      Log.Information("Method: Run");
      Console.WriteLine("\n\nWelcome to the Apple Store");
      var currentCustomer = PickCustomer();
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
        Console.WriteLine("\nYou have selected " + currentProduct + "from " + currentStore + ".");
        Console.WriteLine("\nPlease press y to confirm your purchase");
        var input = Console.ReadLine();
        if (input == "y")
        {
          _orderSingleton.AddToOrderRepo(currentStore, currentProduct);
        }
        Console.WriteLine("\nYou have purshased the item!\n");
        Console.WriteLine("Press y to goto Home or any other key to exit");
        string key = Console.ReadLine();
        keyOptions(key);
      }
      else if (option == 2)
      {
        ViewOrders();
        Console.WriteLine("Do you want to go back? if yes, press y or any other key to exit.");
        string key = Console.ReadLine();
        keyOptions(key);
        SelectOptions();
      }
      else
      {
        Exit();
      }
    }

    private static void keyOptions(string key)
    {
      if (key == "y")
      {
        SelectOptions();
      }
      else
      {
        Exit();
      }
    }

    private static void Exit()
    {
      Console.WriteLine("\nThank you and come back soon!\n");
      System.Environment.Exit(0);
    }

    private static void ViewOrders()
    {
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
      Console.WriteLine("\nPlease select your customer ID \n");
      var customerSing = _customerSingleton.Customers;
      Output(customerSing);
      int input = int.Parse(Console.ReadLine());
      return customerSing[input - 1];
    }

    static Store PickStore()
    {
      var storeSing = _storeSingleton.Stores;
      Output(storeSing);
      Console.WriteLine("\nPlease select the location number\n");
      int input = int.Parse(Console.ReadLine());
      return storeSing[input - 1];
    }

    static Product PickProduct()
    {
      var def = new DemoEF();
      int index = 0;
      foreach (var item in def.GetProducts())
      {
        Console.WriteLine("\n" + ++index + ". " + item.Name + ", Price: $" + item.Price);
      }

      Console.WriteLine("\nPlease select a product number to purchase\n");
      int input = int.Parse(Console.ReadLine());
      var product = def.GetProducts()[input - 1];
      return product;
    }
  }
}

