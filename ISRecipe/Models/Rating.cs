using System;
using System.Collections.Generic;

public partial class Rating
{
    public Rating(int recipeId, int starsRating)
    {
        RecipeId = recipeId;
        StarsRating = starsRating;
    }

    public Rating(int idRating, int userId, int recipeId, int starsRating)
    {
        IdRating = idRating;
        UserId = userId;
        RecipeId = recipeId;
        StarsRating = starsRating;
    }

    public int IdRating { get; set; }

    public int UserId { get; set; }

    public int RecipeId { get; set; }

    public int StarsRating { get; set; }
}
