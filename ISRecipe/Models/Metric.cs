using System;
using System.Collections.Generic;

public partial class Metric
{
    public Metric(string nameMetric)
    {
        NameMetric = nameMetric;
    }

    public Metric(int idMetric, string nameMetric)
    {
        IdMetric = idMetric;
        NameMetric = nameMetric;
    }

    public int IdMetric { get; set; }

    public string NameMetric { get; set; }
}
