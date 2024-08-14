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

        // Checks that basket cannot be set to negative number or 0
        Assert.That(basket.ExtendBasket(-10) == false);
        Assert.That(basket.ExtendBasket(0) == false);

        // Checks that basket cannot be set to capacity lower than bagel count
        basket.AddBagel("Bagel1");
        basket.AddBagel("Bagel2");
        basket.AddBagel("Bagel3");
        int bagelCount = basket.Bagels.Count();
        Assert.That(basket.ExtendBasket(bagelCount - 1) == false);

        // Checks that capacity cannot be set to the same as it was
        Assert.That(basket.ExtendBasket(basket.Capacity) == false);

        // Checks that new bagels can be added after extending capacity
        basket.ExtendBasket(6);
        Assert.That(basket.AddBagel("Bagel4") == true);

        

    }

}