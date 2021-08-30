using System.Collections.Generic;
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Domain.Interfaces;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;

namespace Project0.StoreApplication.Storage.Repositories
{
  public class StoreRepository : IRepository<Store>
  {

    private const string _path = @"/Users/Contemplative/Documents/Revature/simran_code/data/stores.xml";

    private static readonly FileAdapter _fileAdapter = new FileAdapter();

    public StoreRepository()
    {
      if (_fileAdapter.ReadFromFile<Store>(_path) == null)
      {
        _fileAdapter.WriteToFile<Store>(_path, new List<Store>()
        {
          new Store(){Location = "Hoston, TX"},
          new Store(){Location = "Dallas, TX"},
          new Store(){Location = "Austin, TX"}
        });
      }
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    public bool Insert(Store entry)
    {
      _fileAdapter.WriteToFile<Store>(_path, new List<Store> { entry });
      return true;
    }

    public List<Store> Select()
    {
      return _fileAdapter.ReadFromFile<Store>(_path);
    }

    public Store Update()
    {
      throw new System.NotImplementedException();
    }
  }
}