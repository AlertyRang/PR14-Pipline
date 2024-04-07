using System;
using System.Collections.Generic;

public partial class StepRecipe
{
    public StepRecipe(string numberStepRecipe, string descriptionStepRecipe)
    {
        NumberStepRecipe = numberStepRecipe;
        DescriptionStepRecipe = descriptionStepRecipe;
    }

    public StepRecipe(int idStepRecipe, int recipeId, string numberStepRecipe, string descriptionStepRecipe)
    {
        IdStepRecipe = idStepRecipe;
        RecipeId = recipeId;
        NumberStepRecipe = numberStepRecipe;
        DescriptionStepRecipe = descriptionStepRecipe;
    }

    public int IdStepRecipe { get; set; }

    public int RecipeId { get; set; }

    public string NumberStepRecipe { get; set; }

    public string DescriptionStepRecipe { get; set; }
}
