using Project0.StoreApplication.Client.Singletons;
using Xunit;

namespace Project0.StoreApplication.Testing.SingletonTests
{
  public class SingletonTests
  {
    /// <summary>
    /// Testing Customer Singleton
    /// </summary>
    [Fact]
    public void CustomerSingletonTest()
    {
      CustomerSingleton sut = CustomerSingleton.Instance;

      Assert.NotNull(sut);
    }

    /// <summary>
    /// Testing Store Singleton
    /// </summary>
    [Fact]
    public void StoreSingleton_Test()
    {
      StoreSingleton sut = StoreSingleton.Instance;

      Assert.NotNull(sut);
    }

    /// <summary>
    /// Testing Product Singleton
    /// </summary>
    [Fact]
    public void ProductSingleton_Test()
    {
      ProductSingleton sut = ProductSingleton.Instance;

      Assert.NotNull(sut);
    }

    /// <summary>
    /// Testing Order Singleton
    /// </summary>
    [Fact]
    public void OrderSingleto_Test()
    {
      OrderSingleton sut = OrderSingleton.Instance;

      Assert.NotNull(sut);
    }
  }
}