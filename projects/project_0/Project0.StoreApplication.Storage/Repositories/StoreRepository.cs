using System;
using System.Collections.Generic;
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;

namespace Project0.StoreApplication.Storage.Repositories
{
  public class StoreRepository
  {
    public List<Store> Stores { get; }

    public StoreRepository()
    {

      var fileAdapter = new FileAdapter();

      if(fileAdapter.ReadFromFile() == null)
      {
        fileAdapter.WriteToFile(new List<Store>()
      {
        new Makeup(), //sores.Add(new Store());
        new Makeup(),
        new Makeup()
      });
      }
      
      Stores = fileAdapter.ReadFromFile();
    }

  }
}