using System;

namespace homework1
{
    static class Program1
    {
        static void Main(string[] args)
        {
            string c = "";
            int a = 0;
            int b = 0;
            int d = 0;
            System.Console.Write("Please input first number:");
            c = Console.ReadLine();
            a = Int32.Parse(c);
            System.Console.Write("Please input second number:");
            c = Console.ReadLine();
            b = Int32.Parse(c);
            d = a * b;
            Console.WriteLine("You have got:" + d);
        }
    }
}
