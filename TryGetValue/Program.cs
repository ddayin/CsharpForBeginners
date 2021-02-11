using System;
using System.Collections.Generic;

namespace TryGetValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionaryTest = new Dictionary<string, int>();
            dictionaryTest.Add("first", 0);
            dictionaryTest.Add("second", 1);
            dictionaryTest.Add("third", 2);

            int value = 0;

            // ContainsKey()            
            if (dictionaryTest.ContainsKey("third") == true)
            {
                value = dictionaryTest["third"];
                Console.WriteLine("For key = \"third\", value = {0}.", value);
            }
            else
            {
                Console.WriteLine("Key = \"third\" is not found.");
            }
            
            // TryGetValue()            
            if (dictionaryTest.TryGetValue("third", out value))
            {
                Console.WriteLine("For key = \"third\", value = {0}.", value);
            }
            else
            {
                Console.WriteLine("Key = \"third\" is not found.");
            }
            
        }
    }
}
