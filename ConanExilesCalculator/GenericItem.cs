using ConanExilesCalculator;

public abstract record GenericItem(string Name)
{
    public abstract Recipe Recipe { get; }
    public abstract Recipe CalculatePrice();

    public static Recipe operator +(GenericItem left, GenericItem right) =>
        left.Recipe + right.Recipe;
    public static Recipe operator +(Recipe leftRecipe, GenericItem right) =>
        leftRecipe + right.Recipe;
    public static Recipe operator +(GenericItem left, Recipe rightRecipe) =>
        left.Recipe + rightRecipe;
}