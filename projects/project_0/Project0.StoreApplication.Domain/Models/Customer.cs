using System.Collections.Generic;

namespace Project0.StoreApplication.Domain.Models
{
  public class Customer
  {
    public int CustomerId { get; set; }

    public string Name { get; set; }

    public List<Order> Orders { get; set; }

    public override string ToString()
    {
      return $"{Name}";
    }

    public Customer()
    {
    }

  }
}