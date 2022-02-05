# ConanExilesCraftingCalculator

This application helps calculate how much resources are needed to craft in-game items.

## Program

```csharp
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
```

## Output

```
My purchase:
  66 HardenedLeather
  93 LayeredFur
   5 PerfectedMediumPadding

Price in primitive ingredients:
 598 AlchemicalBase
 186 Fur
1030 Leather
1030 Oil
  70 RhinoHide
 412 ThickLeather
  35 Twine
```
