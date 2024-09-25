using System;
using System.Collections.Generic;
using System.Linq;

public class StringUtility
{
    public static List<List<string>> GroupAnagrams(string[] strs)
    {
        if (strs == null || strs.Length == 0)
        {
            return new List<List<string>>();
        }

        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
        foreach (string s in strs)
        {
            char[] charArray = s.ToCharArray();
            Array.Sort(charArray);
            string key = new string(charArray);
            if (!map.ContainsKey(key))
            {
                map[key] = new List<string>();
            }
            map[key].Add(s);
        }

        return map.Values.ToList();
    }
}