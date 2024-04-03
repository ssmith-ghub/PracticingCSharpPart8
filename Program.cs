using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Math. will bring up methods for the Math class
            double x = 3.84;
            double y = 5;
            double a = Math.Pow(x, 2); //to the power of Math.Pow

            Console.WriteLine(a);
            Console.ReadKey();

            double b = Math.Sqrt(x); //squre root of Math.Sqrt

            Console.WriteLine(b);
            Console.ReadKey();

            double c = Math.Abs(x); // absolute value of a number Math.Abs

            Console.WriteLine(c);
            Console.ReadKey();

            double d = Math.Round(x); //rounding to nearest whole number Math.Round

            Console.WriteLine(d);
            Console.ReadKey();

            double e = Math.Ceiling(x); // will always round up Math.Ceiling

            Console.WriteLine(e);
            Console.ReadKey();

            double f = Math.Floor(x); // will always round down Math.Floor

            Console.WriteLine(f);
            Console.ReadKey();

            double g = Math.Max(x, y); // display maximum value between two variables Math.Max

            Console.WriteLine(g);
            Console.ReadKey();

            double h = Math.Min(x, y); // displays minimum value between two variables Math.Min

            Console.WriteLine(h);
            Console.ReadKey();
        }
    }
}
