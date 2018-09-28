using System;
using static System.DateTime;

namespace ProCSharp7Book.Chapter5
{
    static class TimeUtilClass
    {
        public static void PrintTime() =>Console.WriteLine(Now.ToShortTimeString());
        public static void PrintDate() => Console.WriteLine(Now.ToShortDateString());
    }
}
