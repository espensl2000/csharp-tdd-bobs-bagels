// See https://aka.ms/new-console-template for more information
using tdd_bobs_bagels.CSharp.Main;

Console.WriteLine("Hello, World!");

Basket basket = new Basket();

basket.AddBagel("Bagel1");
basket.AddBagel("Bagel2");

Console.WriteLine(basket.ExtendBasket(10));