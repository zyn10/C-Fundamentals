using System;

namespace ConsoleApp4

{

    class Program

    {

        static void Main(string[] args)

        {

            dynamic sum = 20 + 30;

            dynamic msg = "Hello";

            Console.WriteLine(sum.GetType());

            Console.WriteLine(msg.GetType());

        }

    }

}
