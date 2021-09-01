using Xunit;
using Project0.StoreApplication.Storage.Repositories;

namespace Project0.StoreApplication.Testing.Repository
{
  public class ProductRepositoryTests
  {
    [Fact]
    public void Test_ProductCollection()
    {
      //arrange = instance of the entity to test
      var sut = new ProductRepository();

      //act = execute sut for data
      var actual = sut.Select();

      //assert
      Assert.NotNull(actual);

    }
  }
}