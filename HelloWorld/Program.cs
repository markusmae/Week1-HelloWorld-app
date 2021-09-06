using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string UserName;
            UserName = Console.ReadLine();

            Console.Write("Hello, " + UserName);

            Console.Read();
        }
    }
}
