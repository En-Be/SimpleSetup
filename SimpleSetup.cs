using System;

namespace SimpleSetup
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeting greeting = new Greeting(args);
        }
    }

    class Greeting
    {
        public Greeting(string[] args)
        {
            foreach(string arg in args)
            {
                Console.WriteLine($"Hello {arg}");
            }
        }
    }
}