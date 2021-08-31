using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Repositories;

namespace Project0.StoreApplication.Client.Singletons
{
  public class OrderSingleton
  {
    private static OrderSingleton _orderSingleton;

    private static readonly OrderRepository _orderRepository = new OrderRepository();

    // public List<Order> Orders { get; private set; }

    public static OrderSingleton Instance
    {
      get
      {
        if (_orderSingleton == null)
        {
          _orderSingleton = new OrderSingleton();
        }
        return _orderSingleton;
      }
    }

    private OrderSingleton()
    {
      _orderRepository.Select();
    }

    public void AddToOrderRepo(Store store, Product product)
    {
      _orderRepository.AddToOrder(store, product);
    }
    public OrderRepository getOrderRepository()
    {
      return _orderRepository;
    }
  }
}