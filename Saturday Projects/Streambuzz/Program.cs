using System;
using System.Collections.Generic;
class Program
{
    public static List<CreatorStats> EngagementBoard=new List<CreatorStats>();
    public static void Main()
    {
        int choice = 0;
        while(choice!=4)
        {
            Console.WriteLine("1.Creator Registration");
            Console.WriteLine("2.Get the top post counts");
            Console.WriteLine("3.Average Weekly likes");
            Console.WriteLine("4.Exit");
            choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    CreatorStats records = new CreatorStats();
                    RegisterCreator(records);
                    break;
                case 2:
                    Console.WriteLine("Enter like threshold");
                    double threshold=Convert.ToDouble(Console.ReadLine());
                    Dictionary<string,int> res= GetTopPostCounts(EngagementBoard,threshold);
                    if (res.Count == 0)
                    {
                        Console.WriteLine("No top-performing posts this week");
                    }
                    else
                    {
                        foreach(var p in res)
                        {
                            Console.WriteLine($"{p.Key}:{p.Value}");
                        }
                    }
                    
                    break;
                case 3:
                    Console.WriteLine("Overall Weekly likes: "+CalculateAverageLikes());
                    break;
                case 4:
                    Console.WriteLine("Logging off — Keep Creating with StreamBuzz!");
                    break;
                default:
                    Console.WriteLine("\t\t=======You have entered a wrong input=======\t\t");
                    break;
            }
        }

    }
    public static void RegisterCreator(CreatorStats record)
    {
        Console.WriteLine("Enter Creators name: ");
        record.CreatorName=Console.ReadLine();
        
        for(int i=0;i<4;i++)
        {
            Console.WriteLine($"Enter Creators {i+1} week likes:");
            record.WeeklyLikes[i]=Convert.ToDouble(Console.ReadLine());
        }
        EngagementBoard.Add(record);

    }
    public static Dictionary<string, int> GetTopPostCounts(List<CreatorStats> records, double likeThreshold)
    {
        Dictionary<string,int> result=new Dictionary<string, int>();
        foreach(var p in records)
        {
            int count=0;
            for(int i=0;i<4;i++)
            {
                if(p.WeeklyLikes[i]>=likeThreshold) count++;
            }
            
            if(count==0) return result;
            result.Add(p.CreatorName,count);
        }
        return result;
    }
    public static double CalculateAverageLikes()
    {
        double total=0;
        foreach(var p in EngagementBoard)
        {
            for(int i=0;i<4;i++)
            {
                total+=p.WeeklyLikes[i];
                
            }
        }
        return total/(EngagementBoard.Count*4);
    }
}