using System.Collections.Generic;
using Project0.StoreApplication.Domain.Interfaces;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;

namespace Project0.StoreApplication.Storage.Repositories
{
  public class OrderRepository : IRepository<Order>
  {

    private const string _path = @"/Users/Contemplative/Documents/Revature/simran_code/data/orders.xml";

    private static readonly FileAdapter _fileAdapter = new FileAdapter();
    public static List<Order> Orders = new List<Order>();

    public OrderRepository()
    {
      if (_fileAdapter.ReadFromFile<Order>(_path) == null)
      {
        _fileAdapter.WriteToFile<Order>(_path, new List<Order>());
      }
      else
      {
        Orders = _fileAdapter.ReadFromFile<Order>(_path);
      }
    }

    public void AddToOrder(Store store, Product product)
    {
      Orders.Add(new Order() { Store = store, Product = product });
      _fileAdapter.WriteToFile<Order>(_path, Orders);
      Orders = _fileAdapter.ReadFromFile<Order>(_path);
    }

    public List<Order> GetOrders()
    {
      return Orders;
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    public bool Insert(List<Order> entry)
    {
      _fileAdapter.WriteToFile<Order>(_path, entry);
      return true;
    }

    public List<Order> Select()
    {
      return _fileAdapter.ReadFromFile<Order>(_path);
    }

    public Order Update()
    {
      throw new System.NotImplementedException();
    }
  }
}