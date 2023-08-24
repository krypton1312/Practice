global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;



class Program
{
    static void Main(string[] args)
    {
        string str1 = "sadbut";
        string str2 = "sad";

        int StrStr(string haystack, string needle)
        {

            return haystack.IndexOf(needle);

        }
        Console.WriteLine(StrStr(str1, str2));
    }
}
