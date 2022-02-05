using ConanExilesCalculator;

public record CompositeItem : GenericItem
{
    public override Recipe Recipe { get; }

    public CompositeItem(string name, Dictionary<GenericItem, int> ingredientDictionary) : base(name)
    {
        Recipe = new Recipe(ingredientDictionary);
    }
    
    public override Recipe CalculatePrice() => Recipe.CalculatePrice();


    public void PrintRecipe()
    {
        Console.WriteLine(Name);
        Recipe.Print();
    }

    public void PrintPrice()
    {
        Console.WriteLine(Name);
        CalculatePrice().Print();
    }
}