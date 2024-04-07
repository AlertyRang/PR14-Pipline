using System;
using System.Collections.Generic;

public partial class HistoryVisit
{
    public HistoryVisit(DateTime dateTimeHistory, bool favoriteHistory)
    {
        DateTimeHistory = dateTimeHistory;
        FavoriteHistory = favoriteHistory;
    }

    public HistoryVisit(int userId, int recipeId, DateTime dateTimeHistory, bool favoriteHistory)
    {
        UserId = userId;
        RecipeId = recipeId;
        DateTimeHistory = dateTimeHistory;
        FavoriteHistory = favoriteHistory;
    }

    public int UserId { get; set; }

    public int RecipeId { get; set; }

    public DateTime DateTimeHistory { get; set; }

    public bool FavoriteHistory { get; set; }
}
