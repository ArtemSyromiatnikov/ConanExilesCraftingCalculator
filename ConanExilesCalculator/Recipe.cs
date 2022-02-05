using System.Collections.Immutable;

namespace ConanExilesCalculator;

public record Recipe
{
    private ImmutableDictionary<GenericItem, int> Ingredients { get; }

    public Recipe()
    {
        Ingredients = ImmutableDictionary<GenericItem, int>.Empty;
    }
    public Recipe(IDictionary<GenericItem, int> ingredientDictionary)
    {
        Ingredients = ingredientDictionary.ToImmutableDictionary();
    }

    public IDictionary<GenericItem, int> AsDictionary() => 
        Ingredients.ToDictionary(pair => pair.Key, pair => pair.Value);
    
    public IList<(GenericItem, int)> AsSortedList() => Ingredients
        .Select(pair => (Item: pair.Key, Count: pair.Value))
        .OrderBy(pair => pair.Item.Name)
        .ToList();


    public static Recipe operator *(Recipe originalRecipe, int factor)
    {
        var dictionary = originalRecipe.AsDictionary();
        foreach (var item in dictionary.Keys)
        {
            dictionary[item] *= factor;
        }
        
        return new Recipe(dictionary);
    }

    public static Recipe operator +(Recipe leftRecipe, Recipe rightRecipe)
    {
        var sum = leftRecipe.AsDictionary();
        foreach ((GenericItem key, int count) in rightRecipe.AsDictionary())
        {
            if (sum.ContainsKey(key))
                sum[key] += count;
            else
                sum[key] = count;
        }

        return new Recipe(sum);
    }
    
    /// <summary>
    /// Returns a Recipe consisting of primitive ingredients only
    /// </summary>
    /// <returns></returns>
    public Recipe CalculatePrice()
    {
        Recipe price = new();
        foreach ((var item, int count) in Ingredients)
        {
            var ingredientPrice = item.CalculatePrice() * count;
            price += ingredientPrice;
        }

        return price;
    }
    
    public void Print()
    {
        foreach ((var item, int count) in this.AsSortedList())
        {
            Console.WriteLine($"{count,4} {item.Name}");
        }
    }
}