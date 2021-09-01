using Xunit;
using Project0.StoreApplication.Storage;

namespace Project0.StoreApplication.Testing.DB
{
  public class ProductDB
  {
    [Fact]
    public void Test_ProductDB()
    {

      var sut = new DemoEF();


      var actual = sut.GetProducts();


      Assert.NotNull(actual);
    }
  }
}