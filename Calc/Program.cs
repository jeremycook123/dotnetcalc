using System;
using AddService;

namespace PrimeTester
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = Adder.Add(3, 6);

            Console.WriteLine(sum);
        }
    }
}