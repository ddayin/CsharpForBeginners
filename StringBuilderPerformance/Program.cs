using System;
using System.Text;

namespace StringBuilderPerformance
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestString();
            TestStringBuilder();
        }

        private static void TestString()
        {
            var stopWatch = System.Diagnostics.Stopwatch.StartNew();

            string test = String.Empty;
            for (int i = 0; i < 10000; i++)
            {
                test += "HELLO WORLD! ";
            }
            long elapsed = stopWatch.ElapsedMilliseconds;
            Console.WriteLine(elapsed);
        }

        private static void TestStringBuilder()
        {
            var stopWatch = System.Diagnostics.Stopwatch.StartNew();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 1000000; i++)
            {
                sb.Append("HELLO WORLD! ");
            }
            long elapsed = stopWatch.ElapsedMilliseconds;
            Console.WriteLine(elapsed);
        }
    }
}
