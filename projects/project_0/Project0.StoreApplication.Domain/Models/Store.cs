using System.Collections.Generic;

namespace Project0.StoreApplication.Domain.Models
{

  public class Store
  {
    public string Location { get; set; }
    private List<Order> Orders = new List<Order>();

    public override string ToString()
    {
      return $"Apple Store - " + Location;
    }
  }
}