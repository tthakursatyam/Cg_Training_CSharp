namespace DialingCodesApp
{
    public static class DialingCodes
    {
        public static Dictionary<int, string> GetEmptyDictionary()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            return dict;
        }
        public static Dictionary<int, string> GetExistingDictionary()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "United States of America");
            dict.Add(55, "Brazil");
            dict.Add(91,"India");
            return dict;
            
        }
        public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(countryCode,countryName);
            return dict;
        }
        public static Dictionary<int, string> AddCountryToExistingDictionary(Dictionary<int, string> existingDictionary, int countryCode, string countryName)
        {
            existingDictionary.Add(countryCode,countryName);
            return existingDictionary;
        }
        public static string GetCountryNameFromDictionary(Dictionary<int, string> existingDictionary, int countryCode)
        {
            return existingDictionary[countryCode];
        }
        public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
        {
            return existingDictionary.ContainsKey(countryCode);
        }
        public static Dictionary<int, string> UpdateDictionary(Dictionary<int, string> existingDictionary, int countryCode, string countryName)
        {
            if(existingDictionary.ContainsKey(countryCode))
            {
                existingDictionary[countryCode]=countryName;
            }
            return existingDictionary;
        }
        public static Dictionary<int, string> RemoveCountryFromDictionary(Dictionary<int, string> existingDictionary, int countryCode)
        {
            if(existingDictionary.ContainsKey(countryCode))
            {
                existingDictionary.Remove(countryCode);
                Console.WriteLine("Dictionary no longer contains the removed country.");
            }
            return existingDictionary;
        }
        public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
        {
            string ans="";
            foreach(var i in existingDictionary)
            {
                if(i.Value.Length>ans.Length)
                {
                    ans=i.Value;
                }
            }
            return ans;
        }
    }
}
public class student
{
    public int a=11;
}