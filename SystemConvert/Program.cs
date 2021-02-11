using System;

namespace SystemConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringTest = "1234567890";

            int intConverted = 0;
            if (Int32.TryParse(stringTest, out intConverted) == true)
            {
                Console.WriteLine(intConverted + 10);
            }

            intConverted = Convert.ToInt32(stringTest);
            Console.WriteLine(intConverted);
        }
    }
}