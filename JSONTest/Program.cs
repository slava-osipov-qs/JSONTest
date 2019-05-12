using System;
using Newtonsoft.Json;

namespace JSONTest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Environment version: " + Environment.Version);
            Console.WriteLine("Json.NET version: " + typeof(JsonSerializer).Assembly.FullName);

            Console.WriteLine("With private setter:");
            Tests.Test1();


            Console.WriteLine("Without setter:");
            Tests.Test2();

        }
    }
}
