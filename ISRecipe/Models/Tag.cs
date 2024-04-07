using System;
using System.Collections.Generic;

public partial class Tag
{
    public Tag(string nameTag)
    {
        NameTag = nameTag;
    }

    public Tag(int idTag, int categoryId, string nameTag)
    {
        IdTag = idTag;
        CategoryId = categoryId;
        NameTag = nameTag;
    }

    public int IdTag { get; set; }

    public int CategoryId { get; set; }

    public string NameTag { get; set; }
}
