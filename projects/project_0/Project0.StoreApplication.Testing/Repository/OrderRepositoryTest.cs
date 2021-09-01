using Xunit;
using Project0.StoreApplication.Storage.Repositories;

namespace Project0.StoreApplication.Testing.Repository
{
  public class OrderRepositoryTests
  {
    [Fact]
    public void Test_OrderCollection()
    {
      //arrange = instance of the entity to test
      var sut = new OrderRepository();

      //act = execute sut for data
      var actual = sut.Select();

      //assert
      Assert.NotNull(actual);

    }
  }
}