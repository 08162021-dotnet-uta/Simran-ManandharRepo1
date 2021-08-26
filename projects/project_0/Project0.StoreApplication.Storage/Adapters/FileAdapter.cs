using System.Collections.Generic;
using System.Xml.Serialization;
using Project0.StoreApplication.Domain.Abstracts;
using System.IO;

namespace Project0.StoreApplication.Storage.Adapters
{
  public class FileAdapter
    {
    public List<Store> ReadFromFile()
    {
      var path = @"/Users/Contemplative/Documents/Revature/simran_code/data/project_0.xml";

      var file = new StreamReader(path);

      var xml = new XmlSerializer(typeof(List<Store>));

      var stores = xml.Deserialize(file) as List<Store>;

      file.Close();

      return stores;
    }

    public void WriteToFile(List<Store> stores)
    {
      var path = @"/Users/Contemplative/Documents/Revature/simran_code/data/project_0.xml";

      var file = new StreamWriter(path);

      var xml = new XmlSerializer(typeof(List<Store>));

      xml.Serialize(file, stores);

      file.Close();

    }
  }
}