namespace ConanExilesCalculator;

public static class Items
{
    public static SimpleItem Fur = new(nameof(Fur));
    public static SimpleItem AlchemicalBase = new(nameof(AlchemicalBase));
    public static SimpleItem Oil = new(nameof(Oil));
    public static SimpleItem RhinoHide = new(nameof(RhinoHide));
    public static SimpleItem Twine = new(nameof(Twine));
    public static SimpleItem Leather = new(nameof(Leather));
    public static SimpleItem ThickLeather = new(nameof(ThickLeather));
    
    public static CompositeItem HardenedLeather = new(nameof(HardenedLeather), new()
    {
        { Leather, 5 },
        { ThickLeather, 2 },
        { AlchemicalBase, 2 },
        { Oil, 5 },
    });

    public static CompositeItem LayeredFur = new(nameof(LayeredFur), new()
    {
        { Fur, 2 },
        { AlchemicalBase, 2 },
    });
    public static CompositeItem PerfectedMediumPadding = new(nameof(PerfectedMediumPadding), new()
    {
        { HardenedLeather, 28 },
        { RhinoHide, 14 },
        { Twine, 7 },
    });
    
    // Armor [Medium] [+Vitality]
    public static CompositeItem CimmerianFurHelmet = new(nameof(CimmerianFurHelmet), new()
    {
        { PerfectedMediumPadding, 1 },
        { HardenedLeather, 10 },
        { LayeredFur, 16 },
    });
    public static CompositeItem CimmerianFurHarness = new(nameof(CimmerianFurHarness), new()
    {
        { PerfectedMediumPadding, 1 },
        { HardenedLeather, 20 },
        { LayeredFur, 25 },
    });
    public static CompositeItem CimmerianFurGauntlets = new(nameof(CimmerianFurGauntlets), new()
    {
        { PerfectedMediumPadding, 1 },
        { HardenedLeather, 10 },
        { LayeredFur, 16 },
    });
    public static CompositeItem CimmerianFurTasset = new(nameof(CimmerianFurTasset), new()
    {
        { PerfectedMediumPadding, 1 },
        { HardenedLeather, 16 },
        { LayeredFur, 20 },
    });
    public static CompositeItem CimmerianFurBoots = new(nameof(CimmerianFurBoots), new()
    {
        { PerfectedMediumPadding, 1 },
        { HardenedLeather, 10 },
        { LayeredFur, 16 },
    });
}