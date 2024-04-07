using System;
using System.Collections.Generic;

public partial class Image
{
    public Image(int recipeId, string sourceImage)
    {
        RecipeId = recipeId;
        SourceImage = sourceImage;
    }

    public Image(int idImage, int stepRecipeId, int recipeId, string sourceImage)
    {
        IdImage = idImage;
        StepRecipeId = stepRecipeId;
        RecipeId = recipeId;
        SourceImage = sourceImage;
    }

    public int IdImage { get; set; }

    public int StepRecipeId { get; set; }

    public int RecipeId { get; set; }

    public string SourceImage { get; set; }
}
