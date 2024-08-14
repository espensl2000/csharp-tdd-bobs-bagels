namespace csharp_tdd_bobs_bagels.tests;

using tdd_bobs_bagels.CSharp.Main;

public class BasketTest
{

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestAddBagel()
    {
        // Arrange
        Basket basket = new Basket();

        // Act & Assert
        // Checks that each bagel is added
        Assert.That(basket.AddBagel("Bagel1") == true);
        Assert.That(basket.AddBagel("Bagel2") == true);
        Assert.That(basket.AddBagel("Bagel3") == true);

        // Checks that first bagel is Bagel1
        Assert.That(basket.Bagels[0] == "Bagel1");

        // Checks that adding bagel4, with capacity 3 returns false
        Assert.That(basket.AddBagel("Bagel4") == false);

    }

    [Test]
    public void TestRemoveBagel()
    {
        // Arrange
        Basket basket = new Basket();

        // Act
        basket.AddBagel("Bagel1");
        basket.AddBagel("Bagel2");
        basket.RemoveBagel("Bagel1");

        // Assert
        // Checks that bagel count is 1, after adding two, and removing 1
        Assert.That(basket.Bagels.Count() == 1);

        basket.RemoveBagel("Bagel2");
        Assert.That(basket.Bagels.Count() == 0);

        Assert.That(basket.RemoveBagel("Fish & chips") == false);

    }

    [Test]
    public void TestExtendBasket()
    {
        // Arrange
        Basket basket = new Basket();
        int newCapacity = 6;

        // Act & Assert
        basket.ExtendBasket(newCapacity);
        // Checks that the capacity is == newCapacity
        Assert.That(basket.Capacity == 6);

    }


}