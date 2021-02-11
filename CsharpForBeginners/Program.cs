using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.
            string test = "";

            // 2.
            test = String.Empty;

            // 3.
            if (String.IsNullOrEmpty(test) == true)
            {
                Console.WriteLine("string test is empty or null");
            }
        }
    }
}
