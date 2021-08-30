using System.Collections.Generic;
using Project0.StoreApplication.Domain.Interfaces;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;

namespace Project0.StoreApplication.Storage.Repositories
{
  public class ProductRepository : IRepository<Product>
  {

    private const string _path = @"/Users/Contemplative/Documents/Revature/simran_code/data/products.xml";

    private static readonly FileAdapter _fileAdapter = new FileAdapter();

    public ProductRepository()
    {
      if (_fileAdapter.ReadFromFile<Product>(_path) == null)
      {
        _fileAdapter.WriteToFile<Product>(_path, new List<Product>()
        {
          new Product(){Name = "Mac", Price = 1500},
          new Product(){Name = "iPhoneX", Price = 1099},
          new Product(){Name = "ipad", Price = 399}
        });
      }
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    public bool Insert(Product entry)
    {
      _fileAdapter.WriteToFile<Product>(_path, new List<Product> { entry });
      return true;
    }

    public List<Product> Select()
    {
      return _fileAdapter.ReadFromFile<Product>(_path);
    }

    public Product Update()
    {
      throw new System.NotImplementedException();
    }
  }
}