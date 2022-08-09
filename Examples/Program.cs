using System;
using System.IO;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseExportAddress = Directory.GetCurrentDirectory();
            DateTime startTime = DateTime.Now;

            //////////////////////////////// Beginning of LDF Examples ////////////////////////////////

            Example1.Code.Run(baseExportAddress + "/../../../Example1");

            ////////////////////////////////  Ending of LDF Examples   ////////////////////////////////

            DateTime endTime = DateTime.Now;
            Console.WriteLine("Done in {0}.", endTime - startTime);
        }
    }
}
