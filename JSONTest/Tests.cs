using System;

namespace JSONTest
{
    public class Tests
    {
        public static void Test1()
        {
            var orig = new LE1();
            string json = orig.Serialize();
            var result = LogEntry1.Deserialize(json);
            Console.WriteLine("{0:O} {2} {1:O}", orig.TimeStamp, result.TimeStamp, result.TimeStamp==orig.TimeStamp?"equal":"not equal");
        }

        public static void Test2()
        {
            var orig = new LE2();
            string json = orig.Serialize();
            var result = LogEntry2.Deserialize(json);
            Console.WriteLine("{0:O} {2} {1:O}", orig.TimeStamp, result.TimeStamp, result.TimeStamp==orig.TimeStamp?"equal":"not equal");

        }
    }
}
