using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using Project0.StoreApplication.Domain.Models;

namespace Project0.StoreApplication.Storage.Adapters
{
  public class FileAdapter
  {
    public List<T> ReadFromFile<T>(string path) where T : class
    {
      // var path = @"/Users/Contemplative/Documents/Revature/simran_code/data/project_0.xml";

      if (!File.Exists(path))
      {
        return null;
      }

      var file = new StreamReader(path);

      var xml = new XmlSerializer(typeof(List<T>));

      var result = xml.Deserialize(file) as List<T>;

      return result;
    }

    public void WriteToFile<T>(string path, List<T> data) where T : class
    {
      var file = new StreamWriter(path);

      var xml = new XmlSerializer(typeof(List<T>));

      xml.Serialize(file, data);
    }

    public void UseReadFile()
    {

      ReadFromFile<Store>("path");
    }
  }
}