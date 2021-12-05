using System;

namespace usesimple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Call our gcd() function

            int x = 42;
            int y = 105;
            int g = simple.gcd(x, y);
            Console.WriteLine("The gcd of " + x + " and " + y + " is " + g);

            // Manipulate the Foo global variable

            // Output its current value
            Console.WriteLine("Foo = " + simple.Foo);

            // Change its value
            simple.Foo = 3.1415926;

            // See if the change took effect
            Console.WriteLine("Foo = " + simple.Foo);

            Console.ReadLine();
        }
    }
}
