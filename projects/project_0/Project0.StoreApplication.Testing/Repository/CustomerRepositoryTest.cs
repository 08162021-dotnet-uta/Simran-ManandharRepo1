using Xunit;
using Project0.StoreApplication.Storage.Repositories;

namespace Project0.CustomerApplication.Testing.Repository
{
  public class CustomerRepositoryTests
  {
    [Fact]
    public void Test_CustomerCollection()
    {
      //arrange = instance of the entity to test
      var sut = new CustomerRepository();

      //act = execute sut for data
      var actual = sut.Select();

      //assert
      Assert.NotNull(actual);

    }
  }
}