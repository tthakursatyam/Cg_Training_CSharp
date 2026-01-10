using System;
using DialingCodesApp;
class Program
{
    public static void Main()
    {
        Dictionary<int, string> dict = new Dictionary<int, string>();
        dict.Add(91,"India");
        
        
        DialingCodesApp.DialingCodes.GetEmptyDictionary();
        display(DialingCodesApp.DialingCodes.GetExistingDictionary());
        
        display(DialingCodesApp.DialingCodes.AddCountryToEmptyDictionary(81,"Japan"));

        display(DialingCodes.AddCountryToExistingDictionary(dict,44,"UK"));

        Console.WriteLine(DialingCodes.GetCountryNameFromDictionary(dict,44));

        Console.WriteLine(DialingCodes.CheckCodeExists(dict,44));
        Console.WriteLine(DialingCodes.CheckCodeExists(dict,90));

        display(DialingCodes.UpdateDictionary(dict,44,"United Kingdom"));
        
        display(DialingCodes.RemoveCountryFromDictionary(dict,44));
        
        Console.WriteLine(DialingCodes.FindLongestCountryName(dict));



    }
    public static void display(Dictionary<int, string> existingDictionary)
    {
        foreach(var i in existingDictionary)
        {
            Console.WriteLine($"({i.Key},{i.Value})");
        }
    }
}