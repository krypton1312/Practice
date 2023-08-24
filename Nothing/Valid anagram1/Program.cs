using System;
using System.Reflection.Emit;

namespace Valid_anagram1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "anagram";
            string t = "nagaram";
            Dictionary<string, int> annagram = new Dictionary<string, int>();
            for(int i = 0; i <s.Length; i++)
            {
                if (annagram.ContainsKey(s.Substring(i,1)))
                {
                    annagram[s.Substring(i, 1)]++;
                }
                else
                {
                    annagram.Add(s.Substring(i, 1), 1);
                }
            }
            
            Dictionary<string, int> dic2 = new Dictionary<string, int>();
            for (int j = 0; j < t.Length; j++)
            {
                if (dic2.ContainsKey(t.Substring(j, 1)))
                {
                    dic2[t.Substring(j, 1)]++;
                }
                else
                {
                    dic2.Add(t.Substring(j, 1), 1);
                }
            }
            
            var sortedDict1 = annagram.OrderBy(kvp => kvp.Key);
            var sortedDict2 = dic2.OrderBy(kvp => kvp.Key);
            bool areEqual = sortedDict1.SequenceEqual(sortedDict2);
        }
    }
}