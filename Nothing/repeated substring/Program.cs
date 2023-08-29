using System.Collections.Generic;

namespace repeated_substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "aba";
            int a = s.Length;
            Console.WriteLine(a);
            Dictionary<string, int> dic = new Dictionary<string, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s.Substring(i, 1)))
                {
                    dic[s.Substring(i, 1)]++;
                }
                else
                {
                    dic.Add(s.Substring(i, 1), 1);
                }
            }

            ICollection<int> values = dic.Values;
            int firstValueCount = values.First();

            bool hasEqualValueCount = values.All(value => value == firstValueCount);

            if (hasEqualValueCount)
            {
                Console.WriteLine("Все значения в словаре встречаются одинаковое количество раз.");
            }
            else
            {
                Console.WriteLine("Значения в словаре имеют разное количество вхождений.");
            }

        }
    }
}