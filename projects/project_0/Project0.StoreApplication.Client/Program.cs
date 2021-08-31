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

    // private static readonly StoreRepository _storeRepository = StoreRepository.Instance;

    private static readonly CustomerSingleton _customerSingleton = CustomerSingleton.Instance;
    private static readonly StoreSingleton _storeSingleton = StoreSingleton.Instance;
    private static readonly ProductSingleton _productSingleton = ProductSingleton.Instance;
    private static OrderSingleton _orderSingleton = OrderSingleton.Instance;

    private const string _logFilePath = @"/Users/Contemplative/Documents/Revature/simran_code/data/logs.txt";

    private static void Main(string[] args)
    {
      Log.Logger = new LoggerConfiguration().WriteTo.File(_logFilePath).CreateLogger();
      HelloSQL();
      Run();
    }

    private static void Run()
    {
      Log.Information("Method: Run");

      //customers

      // if (_customerSingleton.Customers.Count == 0)
      // {
      //   _customerSingleton.Add(new Customer());
      // }
      // var customer = _customerSingleton.Customers[Capture<Customer>(_customerSingleton.Customers)];
      // var store = _storeSingleton.Stores[Capture<Store>(_storeSingleton.Stores)];
      // var product = _productSingleton.Products[Capture<Product>(_productSingleton.Products)];

      // Console.WriteLine(customer);

      //stores
      // Output<Store>(_storesSingleton.Stores);

      //products
      // Output<Product>(_productSingleton.Products);


      // CaptureOutput();
      // Console.ReadLine();
      var currentCustomer = PickCustomer();
      var currentStore = PickStore();
      // var currentProduct = PickProduct();

      // Console.WriteLine("\nYou have selected " + currentProduct + "from " + currentStore + ".");
      Console.WriteLine("\nPlease press y to confirm your purchase or any other letter to quit.");
      var input = Console.ReadLine();
      if (input == "y")
      {
        // _orderSingleton.AddToOrderRepo(currentStore, currentProduct);
      }

      Console.WriteLine("\nPress y to view your order history");
      var key = Console.ReadLine();
      if (key == "y")
      {
        ViewOrders();
      }

    }

    private static void ViewOrders()
    {
      int count = 0;
      foreach (var order in _orderSingleton.getOrderRepository().GetOrders())
      {
        Console.WriteLine("{0} - {1}", ++count, order);
      }
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
        Console.WriteLine($"\n{++index}. {item}");
      }
    }

    // private static int Capture<T>(List<T> data) where T : class
    // {

    //   Log.Information("method: Captureinput");

    //   Output<T>(data);

    //   Console.WriteLine("Pick an option:");

    //   int input = int.Parse(Console.ReadLine());

    //   return input - 1;
    // }

    static Customer PickCustomer()
    {
      var customerSing = _customerSingleton.Customers;
      Output(customerSing);
      Console.WriteLine("\nPlease insert your customer ID \n");
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

    // static Product PickProduct()
    // {
    //   var productSing = _productSingleton.Products;
    //   Output(productSing);
    //   Console.WriteLine("\nPlease select a product number to purchase\n");
    //   int input = int.Parse(Console.ReadLine());
    //   return productSing[input - 1];
    // }
    private static void HelloSQL()
    {
      var def = new DemoEF();

      foreach (var item in def.GetProducts())
      {
        Console.WriteLine(item);
      }

    }
  }
}

