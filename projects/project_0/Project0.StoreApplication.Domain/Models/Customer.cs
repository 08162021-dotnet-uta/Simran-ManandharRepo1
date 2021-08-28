using System.Collections.Generic;

namespace Project0.StoreApplication.Domain.Models
{
  public class Customer
  {
    public string Name { get; set; }

    public List<Order> Orders { get; set; }

    public override string ToString()
    {
      return $"{Name} with {Orders.Count} orders so far";
    }

    public Customer()
    {
      Name = "Simran";
    }

  }
}