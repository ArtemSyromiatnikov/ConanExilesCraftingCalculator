using ConanExilesCalculator;

public record SimpleItem(string Name) : GenericItem(Name)
{
    public override Recipe Recipe => new Recipe(new Dictionary<GenericItem, int> { { this, 1 } });
    
    public override Recipe CalculatePrice() => Recipe;
}