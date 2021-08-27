using System;
using System.Collections.Generic;
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;

namespace Project0.StoreApplication.Storage.Repositories
{
  public class StoreRepository
  {
    private const string _path = @"/Users/Contemplative/Documents/Revature/simran_code/data/stores.xml"
    public List<Store> Stores { get; }

    public StoreRepository()
    {

      var fileAdapter = new FileAdapter();

      // if(fileAdapter.ReadFromFile<Store>(_path) == null)
      // {
      //   fileAdapter.WriteToFile(new List<Store>()
      // {
      //   new AppleStore(), //sores.Add(new Store());
      //   new SamsungStore(),
      // });
      // }
      
      Stores = fileAdapter.ReadFromFile<_path>();
    }

  }
}