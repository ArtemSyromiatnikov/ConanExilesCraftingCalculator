using ConanExilesCalculator;

var myPurchase =
    Items.CimmerianFurHelmet +
    Items.CimmerianFurHarness +
    Items.CimmerianFurGauntlets +
    Items.CimmerianFurTasset +
    Items.CimmerianFurBoots;

Console.WriteLine("My purchase: ");
myPurchase.Print();

Console.WriteLine("\nPrice in primitive ingredients: ");
myPurchase.CalculatePrice().Print();