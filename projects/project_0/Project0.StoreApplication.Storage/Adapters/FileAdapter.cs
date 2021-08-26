namespace Project0.StoreApplication.Storage.Adapters
{
  public class Adapters
  {
    public void ReadFromFile()
    {
      var path = @"~/revature/simran_code/data/project_0.xml";

      var file = new StreamReader(path);

      var xml = new XmlSerializer(typeof(List<Store>));

      var stores = xml.Deserialize(file) as List<Store>;

      file.Close();

      return stores;
    }

    public void WriteToFile(List<Store> stores)
    {
      var path = @"~/revature/simran_code/data/project_0.xml";

      var file = new StreamWriter(path);

      var xml = new XmlSerializer(typeof(List<Store>));

      xml.Serialize(file, stores);

      file.Close();

    }
  }
}