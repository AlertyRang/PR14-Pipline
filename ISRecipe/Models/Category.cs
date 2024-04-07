using System;
using System.Collections.Generic;

public partial class Category
{
    public Category(string nameCategory)
    {
        NameCategory = nameCategory;
    }

    public Category(int idCategory, string nameCategory)
    {
        IdCategory = idCategory;
        NameCategory = nameCategory;
    }

    public int IdCategory { get; set; }

    public string NameCategory { get; set; }
}
