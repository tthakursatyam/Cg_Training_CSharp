using System;
public class CreatorStats
{
    public string CreatorName { get; set; }
    public double[] WeeklyLikes { get; set; }

    public CreatorStats()
    {
        WeeklyLikes = new double[4];
    }
}
