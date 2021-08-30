using System.Xml.Serialization;
using Project0.StoreApplication.Domain.Models;

namespace Project0.StoreApplication.Domain.Abstracts
{

  public class Store
  {
    public string Location { get; set; }

    public override string ToString()
    {
      return $"Apple Store - " + Location;
    }
  }
}