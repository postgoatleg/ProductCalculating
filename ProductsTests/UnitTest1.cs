using ProductsClass;
namespace ProductsTests;

public class UnitTest1
{
    [Fact]
    public void SumTest()
    {
        Product p1 = new("test", 10);
        Product p2 = new("test", 20);
        Product p3 = p1 + p2;
        Assert.Equal(30, p3.GetPrice());
    }
}
