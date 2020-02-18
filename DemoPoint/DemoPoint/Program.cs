using System;

namespace DemoPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Point center = new Point();     // Default constructor

            Console.WriteLine("Center: " + center);

            center.Move(42, 42);
            Console.WriteLine("Moved Center: " + center);

            Point location = new Point(14, 32);
            Console.WriteLine("Location: " + location);
        }
    }
}
