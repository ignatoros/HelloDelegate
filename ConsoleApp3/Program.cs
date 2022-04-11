using System;

namespace ConsoleApp3
{ 
    public delegate void HelloDelegate();



    class Program
    {
        static void Main(string[] args)
        {
            HelloDelegate hD = () => Console.WriteLine("Hello");
            hD();
            Console.ReadKey();
        }
    }
}
