using System;
using System.Collections.Generic;

public partial class Ingredient
{
    public Ingredient(int metricId, string nameIngredient, decimal? caloricIngredient, int countIngredient)
    {
        MetricId = metricId;
        NameIngredient = nameIngredient;
        CaloricIngredient = caloricIngredient;
        CountIngredient = countIngredient;
    }

    public Ingredient(int recipeId, int metricId, string nameIngredient, decimal? caloricIngredient, int countIngredient)
    {
        RecipeId = recipeId;
        MetricId = metricId;
        NameIngredient = nameIngredient;
        CaloricIngredient = caloricIngredient;
        CountIngredient = countIngredient;
    }

    public int RecipeId { get; set; }

    public int MetricId { get; set; }

    public string NameIngredient { get; set; }

    public decimal? CaloricIngredient { get; set; }

    public int CountIngredient { get; set; }
}
