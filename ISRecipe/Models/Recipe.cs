using System;
using System.Collections.Generic;

public partial class Recipe
{
    public Recipe(string nameRecipe, string portionRecipe, string timeCookRecipe, string descriptionRecipe, string tagId, string catecoryId, string statusId, string userId)
    {
        NameRecipe = nameRecipe;
        PortionRecipe = portionRecipe;
        TimeCookRecipe = timeCookRecipe;
        DescriptionRecipe = descriptionRecipe;
        TagId = tagId;
        CatecoryId = catecoryId;
        StatusId = statusId;
        UserId = userId;
    }

    public Recipe(int idRecipe, string nameRecipe, string portionRecipe, string timeCookRecipe, string descriptionRecipe, string tagId, string catecoryId, string statusId, string userId)
    {
        IdRecipe = idRecipe;
        NameRecipe = nameRecipe;
        PortionRecipe = portionRecipe;
        TimeCookRecipe = timeCookRecipe;
        DescriptionRecipe = descriptionRecipe;
        TagId = tagId;
        CatecoryId = catecoryId;
        StatusId = statusId;
        UserId = userId;
    }

    public int IdRecipe { get; set; }

    public string NameRecipe { get; set; }

    public string PortionRecipe { get; set; }

    public string TimeCookRecipe { get; set; }

    public string DescriptionRecipe { get; set; }

    public string TagId { get; set; }

    public string CatecoryId { get; set; }

    public string StatusId { get; set; }

    public string UserId { get; set; }
}
