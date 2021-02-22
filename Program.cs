using System;

namespace Geometri
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square1 = new Square();
            Square square2 = new Square();
            Square square3 = new Square();
            Square square4 = new Square();
            Square square5 = new Square();
            square1.Side = 12;
            square2.Side = 2;
            square3.Side = 8;
            square4.Side = 5;
            square5.Side = 10;

            Console.WriteLine(square1.omkres());
            Console.WriteLine(square2.omkres());
            Console.WriteLine(square3.omkres());
            Console.WriteLine(square4.omkres());
            Console.WriteLine(square5.omkres());
            Console.WriteLine(square1.areal());
            Console.WriteLine(square2.areal());
            Console.WriteLine(square3.areal());
            Console.WriteLine(square4.areal());
            Console.WriteLine(square5.areal());
        }
    }
    
}
