using System;

namespace AlexIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hi, Enter your name below;");
            var teacherName = Console.ReadLine();

            Console.WriteLine($"Hello, {teacherName}! How are you today?");
        }
    }
}
