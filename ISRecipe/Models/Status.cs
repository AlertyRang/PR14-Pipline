using System;
using System.Collections.Generic;

public partial class Status
{
    public Status(string nameStatus)
    {
        NameStatus = nameStatus;
    }

    public Status(int idStatus, string nameStatus)
    {
        IdStatus = idStatus;
        NameStatus = nameStatus;
    }

    public int IdStatus { get; set; }

    public string NameStatus { get; set; }
}
